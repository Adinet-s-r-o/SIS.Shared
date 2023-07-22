using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class MereniMegaDto
    {
        public int MereniMegaId { get; set; }
        public int? ObjektId { get; set; }
        public DateTime? DatumMereni { get; set; }
        public double? ZHladina { get; set; }
        public double? Hladina { get; set; }
        public string? NewU { get; set; }
        public DateTime? NewD { get; set; }
        public string? ModifU { get; set; }
        public DateTime? ModifD { get; set; }
        public string? DeleteU { get; set; }
        public DateTime? DeleteD { get; set; }

    }
}
