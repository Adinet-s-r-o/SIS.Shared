using SIS.Shared.Enum;
using SIS.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class PlovakResponse : IExportable
    {
        public List<PlovakDto> Data { get; set; }
        public int PlovakId { get; set; }
        public bool DeletePlovak { get; set; }
        public ExportResult ExportResult { get; set; }
        public string ExportMessage { get; set; }
        public PlovakResponse() 
        {
            Data = new List<PlovakDto>();
        }
    }
}
