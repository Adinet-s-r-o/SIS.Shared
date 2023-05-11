using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class KriteriumDto
    {
        public int KriteriumId { get; set; }
        public int VelicinaId { get; set; }
        public int? ObjektId { get; set; }
        public string? VzorekTyp { get; set; }
        public double? H12 { get; set; }
        public double? H23 { get; set; }
        public double? H34 { get; set; }
        public double? H45 { get; set; }
        public DateTime? NewD { get; set; }
        public string? NewU { get; set; }
        public DateTime? ModifD { get; set; }
        public string? ModifU { get; set; }
        public DateTime? DeleteD { get; set; }
        public string? DeleteU { get; set; }
    }
}
