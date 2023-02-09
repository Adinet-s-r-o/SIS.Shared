using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public  class MonitoringResponse
    {
        public DateTime ExportTimestamp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExportResult ExportResult { get; set; }
        public String ExportMessage { get; set; } = String.Empty;
    }
}

