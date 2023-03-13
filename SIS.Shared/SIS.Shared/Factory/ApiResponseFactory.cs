using SIS.Shared.ApiModels;
using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Factory
{
    public static class ApiResponseFactory
    {
        public static ApiResponse<T> ApiOk<T>(T payload)
        {
            return new ApiResponse<T>() { Data = payload };
        }

        public static ApiResponse<T> ApiOkMessage<T>(T payload, string message)
        {
            return new ApiResponse<T>() { Data = payload, SuccessMessage = message, Level = Severity.Ok };
        }
        public static ApiResponse<T> ApiWarningMessage<T>(T payload, ErrorType errorType, string message)
        {
            return new ApiResponse<T>() { Data = payload, ErrorType = errorType, SuccessMessage = message, Level = Severity.Warning };
        }

        public static ApiResponse ApiException(ApiException e)
        {
            return new ApiResponse() { ErrorMessage = e.Message, Level = e.Level };
        }
        public static ApiResponse ApiException(ApiException e, ErrorType error)
        {
            return new ApiResponse() { ErrorMessage = e.Message, Level = e.Level, ErrorType = error };
        }

        public static ApiResponse<T> ApiException<T>(ApiException e)
        {
            return new ApiResponse<T>() { ErrorMessage = e.Message, Level = e.Level };
        }

        public static ApiResponse ApiFatalException(Exception e)
        {
            return new ApiResponse() { ErrorMessage = e.Message, Level = Severity.Error };
        }

        public static ApiResponse<T> ApiFatalException<T>(Exception e)
        {
            return new ApiResponse<T>()
            {
                ErrorMessage = e.InnerException == null ? e.Message : e.Message + "\n\n" + e.InnerException.Message,
                Level = Severity.Fatal
            };
        }
    }
}
