using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class OpatreniDto
    {
        public int OpatreniId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Priority { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public string Note { get; set; } = String.Empty;
        public DateTime NewD { get; set; }
        public string NewU { get; set; } = String.Empty;
        public DateTime? ModifD { get; set; }
        public string ModifU { get; set; } = String.Empty;
        public DateTime? DeleteD { get; set; }
        public string DeleteU { get; set; } = String.Empty;
    }
}
