using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class KriteriumResponse
    {
        public List<KriteriumDto> Data { get; set; }
        public int KriteriumId { get; set; }
        public bool IsNameUsed { get; set; }
        public bool DeleteKriteriu { get; set; }
        public KriteriumResponse()
        {
            Data = new List<KriteriumDto>();
        }
    }
}
