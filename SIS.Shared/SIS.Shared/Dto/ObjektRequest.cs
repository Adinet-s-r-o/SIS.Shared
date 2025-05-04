using SIS.Shared.ApiModels;

namespace SIS.Shared.Dto
{
    public class ObjektRequest : BaseApiRequest
    {
        public string ObjektName { get; set; } = String.Empty;
        public int ObjektId { get; set; }
    }
}
