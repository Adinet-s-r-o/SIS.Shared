using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class CerpaniResponse
    {
        public List<CerpaniDto> Data { get; set; }
        public int CerpaniId { get; set; }
        public bool ExistsForObjects { get; set; }
        public bool DeleteCerpani { get; set; }
        public CerpaniResponse()
        {
            Data = new List<CerpaniDto>();
        }
    }
}
