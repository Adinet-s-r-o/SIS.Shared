using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class HpvFazeRequest
    {
        public int HpvId{ get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public HpvFazeDto Hpv { get; set; }
        public string? ObjektName { get; set; }
        public int ObjektId { get; set; }
        public int KampanId { get; set; }
        public List<int?> ObjektIds { get; set; } = new List<int?>();
        public DateTime? Mereno { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public HpvFazeRequest()
        {
            Hpv= new HpvFazeDto();
        }
    }
}
