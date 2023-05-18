using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class KampanRequest
    {
        public int KampanId { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public KampanDto Kampan { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public string Nazev { get; set; } = String.Empty;

        public KampanRequest()
        {
            Kampan = new KampanDto();
        }
    }
}
