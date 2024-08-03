
namespace SIS.Shared.Dto
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        //public string Pwd { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Tel { get; set; }
        public bool Activation { get; set; }
        public bool Subscription { get; set; }
        //public DateTime NewD { get; set; }

        //public virtual ICollection<LocalitiesUser> LocalitiesUsers { get; } = new List<LocalitiesUser>();

        //public virtual ICollection<NotificationLocalitiesUsersExtendedRule> NotificationLocalitiesUsersExtendedRules { get; } = new List<NotificationLocalitiesUsersExtendedRule>();

        //public virtual ICollection<RoleUser> RoleUsers { get; } = new List<RoleUser>();

    }
}
