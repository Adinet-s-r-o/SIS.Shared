
namespace SIS.Shared.Dto
{
    public class HpvFazeDto 
    {
            public int HpvId { get; set; }
            public int? ObjektId { get; set; }
            public DateTime? Mereno { get; set; }
            public double? HladinaVoda { get; set; }
            public double? HladinaFaze { get; set; }
            public string? Poznamka { get; set; }
            public DateTime? NewD { get; set; }
            public string? NewU { get; set; }
            public DateTime? ModifD { get; set; }
            public string? ModifU { get; set; }
            public DateTime? Reftime { get; set; }
            public DateTime? DeleteD { get; set; }
            public string? DeleteU { get; set; }
            public string? Realizace { get; set; }
    }
}

