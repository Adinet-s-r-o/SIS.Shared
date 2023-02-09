using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class PlovakRequest
    {
        public int PlovakId { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public PlovakDto Plovak { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public PlovakRequest()
        {
            Plovak = new PlovakDto();
        }
    }
}
