using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class PumpingRequest
    {
        public string ConnectionString { get; set; } = String.Empty;
        public DateTime? PumpingFrom { get; set; }
        public DateTime? PumpingTo { get; set; }
        public string WellsObjects { get; set; } = String.Empty;
    }
}
