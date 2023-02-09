using SIS.Shared.Enum;
using SIS.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class ProvozniParametryResponse : IExportable
    {
        public List<ProvozniParametryDto> Data { get; set; }
        public int ProvozniParametryId { get; set; }
        public bool DeleteProvozniParametry{ get; set; }
        public ExportResult ExportResult { get; set; }
        public string ExportMessage { get; set; }
        public ProvozniParametryResponse()
        {
            Data = new List<ProvozniParametryDto>();
        }
    }
}
