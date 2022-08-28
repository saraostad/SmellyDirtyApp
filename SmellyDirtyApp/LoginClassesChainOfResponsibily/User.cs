using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.LoginClassesChainOfResponsibily
{
    public class User
    {
        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role; ;
        }

        public string Password { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
