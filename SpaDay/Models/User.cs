using System;
namespace SpaDay.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(string userName, string password, string email)
        {
            UserName = userName;
            Email = email;
            Password = password;
        }

    }
}
