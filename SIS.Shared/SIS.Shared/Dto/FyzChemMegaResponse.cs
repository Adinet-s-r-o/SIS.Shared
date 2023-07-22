using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace SIS.Shared.Dto
{
    public class FyzChemMegaResponse
    {
        public List<FyzChemMegaDto> Data { get; set; }
        public List<ObjektDto> Objects { get; set; }
        public List<DateTime> MeasurementDates { get; set; }
        public Dictionary<int, List<DateTime>> MeasurementDateObjectMapping { get; set; }
        public FyzChemMegaResponse()
        {
            Data = new List<FyzChemMegaDto>();
            Objects = new List<ObjektDto>();
            MeasurementDates = new List<DateTime>();
            MeasurementDateObjectMapping = new Dictionary<int, List<DateTime>>();
        }
    }
}
