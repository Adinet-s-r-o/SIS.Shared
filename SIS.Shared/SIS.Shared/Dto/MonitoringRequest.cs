using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class MonitoringRequest
    {
        public MonitoringDto monitoring;

        public MonitoringRequest()
        {
            monitoring = new MonitoringDto();
        }
    }
}
