using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace SIS.Shared.Dto
{
    public class FyzChemMegaResponse
    {
        public List<FyzChemMegaDto> Data { get; set; }
        public List<ObjektDto> Objekty { get; set; }
        public List<DateTime> AvailableDates { get; set; }
        public int FyzChemMegaId { get; set; }
        public bool ExistsForObjects { get; set; }
        public bool DeleteFyzChemMega { get; set; }
        public FyzChemMegaResponse()
        {
            Data = new List<FyzChemMegaDto>();
            Objekty = new List<ObjektDto>();
            AvailableDates = new List<DateTime>();
        }
    }
}
