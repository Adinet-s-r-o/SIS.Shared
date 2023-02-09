using System;
using System.Collections.Generic;
using System.Text;
using SIS.Shared.Enum;

namespace SIS.Shared.ApiModels
{
    
    public partial class ApiResponse : IApiResponse
    {
        public ApiResponse() { }

        public ApiResponse(bool success)
        {
            Success = success;
        }

        public ApiResponse(string errorMessage)
        {
            Success = string.IsNullOrEmpty(errorMessage);
            ErrorMessage = errorMessage;
            if (Success == false && ErrorType == ErrorType.NotSet)
                ErrorType = ErrorType.InternalServerError;
        }

        public ApiResponse(string errorMessage, ErrorType errorType)
        {
            Success = string.IsNullOrEmpty(errorMessage);
            ErrorMessage = errorMessage;
            ErrorType = errorType;
        }

        public bool Success { get; set; }

        private string errorMessage;

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                Success = string.IsNullOrEmpty(value);
                errorMessage = value;
            }
        }
        public ErrorType ErrorType { get; set; }


    }
}
