using SmellyDirtyApp.LoginClassesChainOfResponsibily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp
{
    public abstract class LoginChecker
    {
        string _txtInput;
        User _user ;
        public LoginChecker(string txtInput, User user)
        {
            this._txtInput = txtInput;
            this._user = user;
        }

        protected LoginChecker successor;

        abstract public void Check(string txtInput, User user,loginStatus status);
        
        public void SuccessWith(LoginChecker successor)
        {
            this.successor = successor;
        }

        public void Next(loginStatus status)
        {
            if (this.successor != null)
            {
                this.successor.Check(_txtInput, _user, status);
            }
        }

    }
}
