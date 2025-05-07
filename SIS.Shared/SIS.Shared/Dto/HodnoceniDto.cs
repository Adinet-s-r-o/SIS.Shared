namespace SIS.Shared.Dto
{
    public class HodnoceniDto : BaseModelDto
    {
        public int HodnoceniId { get; set; }
        public int CerpaciZkouskaId { get; set; }
        public string? Hodnotil { get; set; }
        public bool? BezNavrhu { get; set; }
        public string? RealizatorHdz { get; set; }
        public string? Hydrogeolog { get; set; }
        public string? ServisniSpolecnostZud { get; set; }
        public string? ProvozniSpolecnost { get; set; }
        public string? Investice { get; set; }
        public string? DetailNavrhu { get; set; }
        public string? OstatniPoznamky { get; set; }
        public string? DoporuceniDleCz { get; set; }
        public string? ZaveryProvozovateleVlastnika { get; set; }
    }
}