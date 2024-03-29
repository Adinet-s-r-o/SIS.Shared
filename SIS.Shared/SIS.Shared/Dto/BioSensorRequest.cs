﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class BioSensorRequest
    {
        public int BioSensorId { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public string ObjektName { get; set; } = String.Empty;
        public List<int?>? ObjectIds { get; set; }
        public int ObjectId { get; set; }
        public int? RecordCnt { get; set; }
        public DateTime? DateFrom { get; set; } 
        public DateTime? DateTo { get; set; } 
        public BioSensorDto BioSensor { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public BioSensorRequest()
        {
            BioSensor = new BioSensorDto();
        }
    }
}
