using System;
using System.Text;

namespace SIS.Shared.Dto
{
    public class LocalityDto
    {
        public int LocalityId { get; set; }
        public string LocalityName { get; set; } = null!;
        public string? LocalityDescription { get; set; }
        public string? Note { get; set; }
        public DateTime NewD { get; set; }
        public int NewU { get; set; }
        public DateTime? DeleteD { get; set; }
        public int? DeleteU { get; set; }
        public string? RestApiEndpoint { get; set; }
        public string? Db { get; set; }
        public string? Srv { get; set; }
        public string? Sistcurl { get; set; }
        public string? Uname { get; set; }
        public string? Pwd { get; set; }
        public string? Type { get; set; }

    }
}
