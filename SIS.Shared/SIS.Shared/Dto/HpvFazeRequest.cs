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
        public string ConnectionString { get; set; } = String.Empty;
        public HpvFazeRequest()
        {
            Hpv= new HpvFazeDto();
        }
    }
}
