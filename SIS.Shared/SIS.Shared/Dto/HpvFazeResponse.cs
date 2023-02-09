using SIS.Shared.Enum;
using SIS.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class HpvFazeResponse : IExportable
    {
        public List<HpvFazeDto> Data { get; set; }
        public int HpvId { get; set; }
        public bool DeleteHpv { get; set; }
        public ExportResult ExportResult { get; set; }
        public string ExportMessage { get; set; }
        public HpvFazeResponse() 
        {
            Data = new List<HpvFazeDto>();
        }
    }
}
