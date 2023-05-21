using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class KampanResponse
    {
        public List<KampanDto> Data { get; set; }
        public int? KampanId { get; set; }
        public bool IsNameUsed { get; set; }
        public bool DeleteKampan{ get; set; }
        public KampanResponse()
        {
            Data = new List<KampanDto>();
        }
    }
}
