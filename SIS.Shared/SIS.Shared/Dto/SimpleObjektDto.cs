using System;

namespace SIS.Shared.Dto
{
    public class SimpleObjektDto
    {
        public int ObjektId { get; set; }
        public string? Objekt { get; set; }
        public string? Typ { get; set; }
        public bool HasCerpani { get; set; }
        public bool HasHladiny { get; set; }
        public bool HasRedox { get; set; }
        public bool HasProvozniParametry { get; set; }
        public bool HasPrilohy { get; set; }
        public bool HasPlovaky { get; set; }
        public bool HasPlovakyFyzChem { get; set; }
        public bool HasBiosensory { get; set; }
        public bool HasFyzChemMega { get; set; }
    }
}

