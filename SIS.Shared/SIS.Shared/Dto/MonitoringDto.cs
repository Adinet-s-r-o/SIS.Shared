using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.Dto
{
    public class MonitoringDto
    {
        public string? ApiKey { get; set; }
        public string? DeviceSerialNumber { get; set; }
        public DateTime MeasuringTimestamp { get; set; }
        public bool IsRepeated { get; set; }
        public RedoxDto? Redox { get; set; }
        public PlovakDto? Plovak { get; set; }
        public ProvozniParametryDto? ProvozniParametry { get; set; }
        public HpvFazeDto? HpvFaze { get; set; }

    }
}
