using SIS.Shared.ApiModels;

namespace SIS.Shared.Dto
{
    public class HodnoceniResponse
    {
        public HodnoceniDto Hodnoceni { get; set; }
        public List<DateTime> DatumyHdz { get; set; } = new List<DateTime>();
    }
}
