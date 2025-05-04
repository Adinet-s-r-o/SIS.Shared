using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class ObjektResponse
    {
        public int? ObjektId { get; set; }
        public List<SimpleObjektDto> SimpleObjekts { get; set; }
        public ObjektDto? Objekt { get; set; }

        public ObjektResponse()
        {
            SimpleObjekts = new List<SimpleObjektDto>();
        }
    }
}
