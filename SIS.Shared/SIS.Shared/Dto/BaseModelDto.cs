namespace SIS.Shared.Dto
{
    public abstract class BaseModelDto
    {
        public string? NewU { get; set; }
        public DateTime? NewD { get; set; }
        public string? ModifU { get; set; }
        public DateTime? ModifD { get; set; }
        public string? DeleteU { get; set; }
        public DateTime? DeleteD { get; set; }
        public DateTime? RefTime { get; set; }
    }
}