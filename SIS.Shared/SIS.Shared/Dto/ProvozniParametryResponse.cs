using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class ProvozniParametryResponse
    {
        public List<ProvozniParametryDto> Data { get; set; }
        public int ProvozniParametryId { get; set; }
        public bool ExistsForObjects { get; set; }
        public bool DeleteProvozniParametry{ get; set; }
        public ProvozniParametryResponse()
        {
            Data = new List<ProvozniParametryDto>();
        }
    }
}
