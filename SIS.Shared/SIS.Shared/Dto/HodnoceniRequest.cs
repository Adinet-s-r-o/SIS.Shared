using SIS.Shared.ApiModels;
using System;

namespace SIS.Shared.Dto
{
    public class HodnoceniRequest : BaseApiRequest
    {
        public int? ObjektId { get; set; }
        public int? KampanId { get; set; }
        public DateTime? DatumHdz { get; set; }
        public HodnoceniDto? Hodnoceni { get; set; }
    }
}
