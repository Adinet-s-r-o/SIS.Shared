﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class FyzChemMegaDto
    {
        public int FyzChemMegaId { get; set; }
        public int? ObjektId { get; set; }
        public string? ObjektName { get; set; }
        public DateTime? Mereno { get; set; }
        public double? Hloubka { get; set; }
        public double? ZHloubka { get; set; }
        public double? TeplotaPh { get; set; }
        public double? TeplotaU { get; set; }
        public double? TeplotaCond { get; set; }
        public double? Konduktivita { get; set; }
        public double? ORP { get; set; }
        public double? Ph { get; set; }
        public bool PlatnostAutomaticka { get; set; }
        public bool? PlatnostManualni { get; set; }
        public string? Poznamka { get; set; }

        #region NON_MODEL_ATTRIBUTES
        public double? Eh { get => ORP + 220; }
        public double? Teplota { get => Math.Round((TeplotaPh.Value + TeplotaU.Value + TeplotaCond.Value) / 3, 1); }
        #endregion
        public string? NewU { get; set; }
        public DateTime? NewD { get; set; }
        public string? ModifU { get; set; }
        public DateTime? ModifD { get; set; }
        public string? DeleteU { get; set; }
        public DateTime? DeleteD { get; set; }

    }
}
