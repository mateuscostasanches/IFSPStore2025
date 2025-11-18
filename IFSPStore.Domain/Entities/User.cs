using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User()
        {
        }
        public User(int id, string name, string password, string login, string email,
                    DateTime registerdate, DateTime logindate, bool active) : base(id)
        {
            Name = name;
            Password = password;
            Login = login;
            Email = email;
            RegisterDate = registerdate;
            LoginDate = logindate;
            IsActive = active;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsActive { get; set; }
    }
}
