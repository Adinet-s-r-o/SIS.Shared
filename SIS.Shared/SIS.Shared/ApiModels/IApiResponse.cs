using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.ApiModels
{
    public interface IApiResponse
    {
        bool Success { get; set; }
        string ErrorMessage { get; set; }
        ErrorType ErrorType { get; set; }
    }
}
