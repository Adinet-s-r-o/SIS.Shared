using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class FyzChemMegaRequest
    {
        public int FyzChemMegaId { get; set; }
        public int ObjectId { get; set; }
        public bool PlatnostManualni { get; set; }
        public List<int?> ObjectIds { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public List<DateTime> Dates { get; set; }
        public MereniMegaDto MereniMega { get; set; }
        public List<FyzChemMegaDto> FyzChemMegaList { get; set; }
        public string ModifU { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;

        public FyzChemMegaRequest()
        {
            MereniMega = new MereniMegaDto();
            FyzChemMegaList = new List<FyzChemMegaDto>();
            ObjectIds = new List<int?>();
            Dates = new List<DateTime>();
        }
    }
}
