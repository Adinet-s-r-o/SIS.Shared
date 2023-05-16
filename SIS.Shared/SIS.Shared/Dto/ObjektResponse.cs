using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class ObjektResponse
    {
        public List<SimpleObjektDto> SimpleObjekts { get; set; }

        public ObjektResponse()
        {
            SimpleObjekts = new List<SimpleObjektDto>();
        }
    }
}
