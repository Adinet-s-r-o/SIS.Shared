using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class OpatreniRequest
    {
        public int OpatreniId { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public OpatreniDto opatreni { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public OpatreniRequest()
        {
            opatreni = new OpatreniDto();
        }
    }
}
