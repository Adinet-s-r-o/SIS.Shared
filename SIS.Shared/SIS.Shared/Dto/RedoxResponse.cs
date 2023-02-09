using SIS.Shared.Enum;
using SIS.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class RedoxResponse : IExportable
    {
        public List<RedoxDto> Data { get; set; }
        public int RedoxId { get; set; }
        public bool DeleteRedox { get; set; }
        public ExportResult ExportResult { get; set; }
        public string ExportMessage { get; set; }
        public RedoxResponse()
        {
            Data = new List<RedoxDto>();
        }
    }
}
