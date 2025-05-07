using System;
using System.Collections.Generic;
using System.Text;
using SIS.Shared.ApiModels;

namespace SIS.Shared.Dto
{
    public class CerpaniRequest : BaseApiRequest
    {
        public int CerpaniId { get; set; }
        public int ObjektId { get; set; }
        public int KampanId { get; set; }
        public int PocetDni { get; set; }
        public List<int?> ObjektIds { get; set; } = new List<int?>();
        public List<int?> KampanIds { get; set; } = new List<int?>();
        public DateTime? Mereno { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public CerpaniDto Cerpani { get; set; }
        public CerpaniRequest()
        {
            Cerpani = new CerpaniDto();
        }
    }
}
