using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using SIS.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.Managers
{
    public class HttpManager
    {
        HttpClient httpClient;

        public HttpManager(string apiKey = null)
        {
            httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            if (apiKey != null)
                httpClient.DefaultRequestHeaders.Add("ApiKey", apiKey);
            // after adding authorization header cannot use apikey
            //else
            //    httpClient.DefaultRequestHeaders.Add("ApiKey", "Isonsoft1234");

        }

        public void SetAuthorization(string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", token);
        }

        public async Task<ApiResponse<TResponse>> Post<TRequest, TResponse>(string url, TRequest request)
            where TResponse : class
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            try
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<TResponse>>(jsonString);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n HTTP Response: " + response.ToString());
            }
        }

        public async Task<ApiResponse<TResponse>> Get<TResponse>(string url)
        {
            var response = await httpClient.GetAsync(url);
            try
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiResponse<TResponse>>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\n HTTP Response: " + response.ToString());
            }
        }

        public async Task<ApiResponse<TResponse>> Get<TRequest, TResponse>(string url, TRequest request)
            where TRequest : class
            where TResponse : class
        {
            string bodyContent = JsonConvert.SerializeObject(request);
            var message = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Content = new StringContent(bodyContent, Encoding.UTF8, "application/json")
            };

            var responseMessage = await httpClient.SendAsync(message);

            try
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<ApiResponse<TResponse>>(jsonString);

                return response ?? new ApiResponse<TResponse>()
                {
                    Data = null,
                    ErrorMessage = $"Read from json async returned null",
                    Level = Severity.Error,
                    SuccessMessage = string.Empty
                };
            }
            catch (Exception ex)
            {
                return new ApiResponse<TResponse>()
                {
                    Data = null,
                    ErrorMessage = $"Frontend exception: {ex.Message}",
                    Level = Severity.Fatal,
                    SuccessMessage = string.Empty
                };
            }
        }

    }

}
