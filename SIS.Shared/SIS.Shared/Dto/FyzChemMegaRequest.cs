using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class FyzChemMegaRequest
    {
        public int FyzChemMegaId { get; set; }
        public int ObjektId { get; set; }
        public List<int> ObjektIds { get; set; }
        public List<DateTime> Dates { get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public FyzChemMegaDto FyzChemMega { get; set; }
        public List<FyzChemMegaDto> FyzChemMegaList { get; set; }
        public string ConnectionString { get; set; } = String.Empty;

        public FyzChemMegaRequest()
        {
            FyzChemMega = new FyzChemMegaDto();
            FyzChemMegaList = new List<FyzChemMegaDto>();
            ObjektIds = new List<int>();
            Dates = new List<DateTime>();
        }
    }
}
