using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class CerpaniRequest
    {
        public int CerpaniId { get; set; }
        public int ObjektId { get; set; }
        public List<int?> ObjektIds { get; set; } = new List<int?>();
        public DateTime? Mereno { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public CerpaniDto Cerpani { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        
        public CerpaniRequest()
        {
            Cerpani = new CerpaniDto();
        }
    }
}
