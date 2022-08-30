using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmellyDirtyApp.Models.RoleTypes;

namespace SmellyDirtyApp.LoginClassesChainOfResponsibily
{
    
    public class User
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public RoleType Role { get; set; }

        public User(string username, string password, RoleType role)
        {
            Username = username;
            Password = password;
            Role = role; ;
        }

        
    }
}
