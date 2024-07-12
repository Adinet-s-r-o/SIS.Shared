
namespace SIS.Shared.Dto
{
    public class LocalityResponse
    {
        public string? LocalityConnectionString { get; set; } = string.Empty;
        public string? RestApiEndpoint { get; set; } = string.Empty;
        public List<LocalityDto>? LocalityList { get; set; }
        public List<SimpleObjektDto>? ObjectList { get; set; }
    }
}
