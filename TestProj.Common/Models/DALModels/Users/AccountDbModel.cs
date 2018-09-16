using TestProj.Common.Enums;

namespace TestProj.Common.Models.DALModels.Users
{
    public class AccountDbModel : Entity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public PermissionTypes Permissions { get; set; }
    }
}