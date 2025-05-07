using System;
using System.Collections.Generic;
using System.Text;
using SIS.Shared.ApiModels;

namespace SIS.Shared.Dto
{
    public class KampanRequest : BaseApiRequest
    {
        public int KampanId { get; set; }
        public int ObjektId { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public KampanDto Kampan { get; set; }
        public string Nazev { get; set; } = String.Empty;

        public KampanRequest()
        {
            Kampan = new KampanDto();
        }
    }
}
