﻿using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class RedoxResponse 
    {
        public List<RedoxDto> Data { get; set; }
        public List<double> ElectricPotential { get; set; }
        public List<DateTime?> MeasuredDates { get; set; }
        public int RedoxId { get; set; }
        public bool ExistsForObjects { get; set; }
        public bool DeleteRedox { get; set; }
        public RedoxResponse()
        {
            Data = new List<RedoxDto>();
        }
    }
}
