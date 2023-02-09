using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class OpatreniResponse
    {
        public List<OpatreniDto> Data { get; set; }
        public int OpatreniId { get; set; }

        public bool DeleteOpatreni { get; set; }
        public bool IsNameUsed { get; set; }
        public bool IsPriorityUsed { get; set; }

        public OpatreniResponse()
        {
            Data = new List<OpatreniDto>();
        }
    }
}
