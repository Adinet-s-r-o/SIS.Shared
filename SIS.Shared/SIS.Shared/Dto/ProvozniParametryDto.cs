using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class ProvozniParametryDto
    {
        public int ProvozniParametrId { get; set; }
        public int? ObjektId { get; set; }
        public DateTime? Mereno { get; set; }
        public double? Hladina { get; set; }
        public double? HladinaKoagulantu { get; set; }
        public double? Ph { get; set; }
        public double? Vodivost { get; set; }
        public double? ProvozniCasDavkovacihoCerpadla { get; set; }
        public string? Poznamka { get; set; }
        public DateTime? NewD { get; set; }
        public string? NewU { get; set; }
        public DateTime? ModifD { get; set; }
        public string? ModifU { get; set; }
        public DateTime? DeleteD { get; set; }
        public string? DeleteU { get; set; }
    }
}
