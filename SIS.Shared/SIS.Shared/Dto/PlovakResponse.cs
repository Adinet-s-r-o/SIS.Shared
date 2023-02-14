using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class PlovakResponse
    {
        public List<PlovakDto> Data { get; set; }
        public int PlovakId { get; set; }
        public bool DeletePlovak { get; set; }
        public PlovakResponse() 
        {
            Data = new List<PlovakDto>();
        }
    }
}
