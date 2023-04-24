using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class HpvFazeResponse
    {
        public List<HpvFazeDto> Data { get; set; }
        public int HpvId { get; set; }
        public bool ExistsForObjects { get; set; }
        public bool DeleteHpv { get; set; }
        public HpvFazeResponse() 
        {
            Data = new List<HpvFazeDto>();
        }
    }
}
