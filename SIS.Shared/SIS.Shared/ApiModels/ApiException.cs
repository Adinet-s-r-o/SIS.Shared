using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.ApiModels
{
    public class ApiException : Exception
    {
        public ApiException(string message, Severity severity) : base(message)
        {
            Level = severity;
        }

        public ApiException(string message) : this(message, Severity.Error)
        { }

        public Severity Level { get; set; }
    }
}
