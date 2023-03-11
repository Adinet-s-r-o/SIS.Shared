using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class BioSensorResponse
    {
        public List<BioSensorDto> Data { get; set; }
        public int BioSensorId { get; set; }
        public bool ExistsForObject { get; set; }
        public bool DeleteBioSensor { get; set; }
        
        public BioSensorResponse()
        {
            Data = new List<BioSensorDto>();
        }
    }
}
