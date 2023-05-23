using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class FyzChemMegaDto
    {
        public int FyzChemMegaId { get; set; }
        public int? ObjektId { get; set; }
        public DateTime? Mereno { get; set; }
        public double? Hloubka { get; set; }
        public double? Teplota1 { get; set; }
        public double? Teplota2 { get; set; }
        public double? Teplota3 { get; set; }
        public double? Konduktivita { get; set; }
        public double? ORP { get; set; }
        public double? Ph { get; set; }

        #region NON_MODEL_ATTRIBUTES
        public double? Eh { get => ORP + 220; }
        public double? Teplota { get => (Teplota1 + Teplota2 + Teplota3) / 3; }
        #endregion
        public string? NewU { get; set; }
        public DateTime? NewD { get; set; }
        public string? ModifU { get; set; }
        public DateTime? ModifD { get; set; }
        public string? DeleteU { get; set; }
        public DateTime? DeleteD { get; set; }

    }
}
