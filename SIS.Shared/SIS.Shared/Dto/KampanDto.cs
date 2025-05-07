using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class KampanDto
    {
        public int KampanId { get; set; }
        public string Nazev { get; set; } = String.Empty;
        public string Popis { get; set; } = String.Empty;
        public DateTime? PlatnostOd { get; set; }
        public DateTime? PlatnostDo { get; set; }
        public DateTime NewD { get; set; }
        public string NewU { get; set; } = String.Empty;
        public DateTime? ModifD { get; set; }
        public string? ModifU { get; set; } = String.Empty;
        public DateTime? DeleteD { get; set; }
        public string? DeleteU { get; set; } = String.Empty;
    }
}
