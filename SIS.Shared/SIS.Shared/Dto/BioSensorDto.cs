using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class BioSensorDto
    {
        public int BioSensorId { get; set; }
        public int? ObjektId { get; set; }
        public DateTime? Mereno { get; set; }
        public double? Bio1 { get; set; }
        public double? Bio2 { get; set; }
        public double? Bio3 { get; set; }
        public double? Bio4 { get; set; }
        public double? Bio5 { get; set; }
        public double? Bio6 { get; set; }
        public string? Poznamka { get; set; }
        public string? NewU { get; set; }
        public DateTime? NewD { get; set; }
        public string? ModifU { get; set; }
        public DateTime? ModifD { get; set; }
        public string? DeleteU { get; set; }
        public DateTime? DeleteD { get; set; }

    }
}
