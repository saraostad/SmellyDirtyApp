using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmellyDirtyApp.LoginClassesChainOfResponsibily
{

    public class CheckPassword : LoginChecker
    {
        string _txt;
        User _user;
        public CheckPassword(string txtInput, User user) : base(txtInput, user)
        {
            this._txt = txtInput;
            this._user = user;
        }

        public override void Check(string txt, User user, loginStatus status)
        {
            RealChecker r = new RealChecker();
            if (!r.CheckPassword(_txt, _user))
            {
                MessageBox.Show("کلمه عبور صحیح نمی باشد.");
                return;
            }

            this.Next(status);
        }
    }
}
