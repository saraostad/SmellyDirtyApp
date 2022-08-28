using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmellyDirtyApp.LoginClassesChainOfResponsibily
{
    public class CheckRole : LoginChecker
    {
        string _txt;
        User _user;
        public CheckRole(string txtInput, User user) : base(txtInput, user)
        {
            this._txt = txtInput;
            this._user = user;
        }

        public override void Check(string txt, User user, loginStatus status)
        {
            RealChecker r = new RealChecker();
            if (r.CheckRole(user))
            {
                MessageBox.Show("نوع کاربری، در سیستم تعریف نشده است.");
            }

            this.Next(status);
        }
    }
}
