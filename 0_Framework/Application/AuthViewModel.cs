namespace _0_Framework.Application
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public AuthViewModel(long id, long roleId, string fullName, string userName, string role)
        {
            Id = id;
            RoleId = roleId;
            FullName = fullName;
            UserName = userName;
            Role = role;
        }
        }
    }
}