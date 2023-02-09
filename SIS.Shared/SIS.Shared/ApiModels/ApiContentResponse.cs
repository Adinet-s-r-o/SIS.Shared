using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.ApiModels
{
    public enum Severity
    {
        Ok = 0,
        Warning = 1,
        Error = 2,
        Fatal = 3
    };

    public class ApiContentResponse
    {
        #region Properties
        public Severity Level { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public ErrorType ErrorType { get; set; }

        #endregion

        #region C´tor
        public ApiContentResponse()
        {
            ErrorMessage = "";
            SuccessMessage = "";
        }
        #endregion
    }

    public sealed class ApiContentResponse<TResponsePayload> : ApiContentResponse
    {
        public TResponsePayload Data { get; set; }

        public ApiContentResponse()
        {
            // Data = new TResponsePayload();
        }
    }
}
