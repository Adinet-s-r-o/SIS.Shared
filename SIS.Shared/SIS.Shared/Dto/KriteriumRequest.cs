using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class KriteriumRequest
    {
        public int KriteriumId { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public KriteriumDto Kriterium { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public KriteriumRequest()
        {
            Kriterium = new KriteriumDto();
        }
    }
}
