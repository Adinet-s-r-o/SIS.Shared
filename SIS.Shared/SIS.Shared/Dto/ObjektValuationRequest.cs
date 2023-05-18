using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class ObjektValuationRequest
    {
        public int ObjektId { get; set; }
        public int KampanId { get; set; }
        public List<int?> KampanIds { get; set; }
        public DateTime KeDni { get; set; }
        public int PocetDni { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public DateTime Mereno { get; set; }
        
        public ObjektValuationRequest() 
        {
            KampanIds = new List<int?>();
        }
    }
}
