using SmellyDirtyApp.LoginClassesChainOfResponsibily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp
{
    public abstract class loginStatus
    {
        public abstract bool CheckUserName(string txtInput, User model);
        public abstract bool CheckPassword(string txtInput, User model);
        public abstract bool CheckRole(User model);
    }
}
