using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SIS.Shared.ApiModels
{
    public class BaseApiRequest
    {
        public string? ConnectionString { get; set; } = null;
        public int? LocalityId { get; set; } = null;
    }
}
