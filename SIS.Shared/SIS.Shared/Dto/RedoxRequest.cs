using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public  class RedoxRequest
    {
        public int RedoxId { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public RedoxDto Redox{ get; set; }
        public string? ObjektName { get; set; }
        public string ConnectionString { get; set; } = String.Empty;

        public RedoxRequest() 
        {
            Redox = new RedoxDto();
        }
    }
}
