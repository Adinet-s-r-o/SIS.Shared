using SIS.Shared.ApiModels;
using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Factory
{
    public static class ApiResponseFactory
    {
        public static ApiContentResponse<T> ApiOk<T>(T payload)
        {
            return new ApiContentResponse<T>() { Data = payload };
        }

        public static ApiContentResponse<T> ApiOkMessage<T>(T payload, string message)
        {
            return new ApiContentResponse<T>() { Data = payload, ErrorMessage = message, Level = Severity.Ok };
        }

        public static ApiContentResponse ApiException(ApiException e)
        {
            return new ApiContentResponse() { ErrorMessage = e.Message, Level = e.Level };
        }
        public static ApiContentResponse ApiException(ApiException e, ErrorType error)
        {
            return new ApiContentResponse() { ErrorMessage = e.Message, Level = e.Level, ErrorType = error };
        }

        public static ApiContentResponse<T> ApiException<T>(ApiException e)
        {
            return new ApiContentResponse<T>() { ErrorMessage = e.Message, Level = e.Level };
        }

        public static ApiContentResponse ApiFatalException(Exception e)
        {
            return new ApiContentResponse() { ErrorMessage = e.Message, Level = Severity.Error };
        }

        public static ApiContentResponse<T> ApiFatalException<T>(Exception e)
        {
            return new ApiContentResponse<T>()
            {
                ErrorMessage = e.InnerException == null ? e.Message : e.Message + "\n\n" + e.InnerException.Message,
                Level = Severity.Fatal
            };
        }
    }
}
