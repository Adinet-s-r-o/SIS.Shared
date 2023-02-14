using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.ApiModels
{
    public class ApiException : Exception
    {
        public ApiException(ErrorType errorType, string message, Severity severity, int httpStatus) : base(message)
        {
            ErrorType = errorType;
            Level = severity;
            HttpStatus = httpStatus;
        }

        // TODO: create factory


        //public ApiException(string message, Severity severity) : base(message)
        //{
        //    Level = severity;
        //}

        //public ApiException(string message) : this(message, Severity.Error)
        //{ }

        //public ApiException(ErrorType errorType) : this(errorType, "", Severity.Error)
        //{ }
        //public ApiException(ErrorType errorType, string message) : this(errorType, message, Severity.Error)
        //{ }

        public Severity Level { get; set; }

        public ErrorType ErrorType { get; set; }

        public int HttpStatus { get; set; }
    }
}
