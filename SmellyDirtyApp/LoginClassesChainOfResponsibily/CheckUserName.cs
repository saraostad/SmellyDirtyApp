using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmellyDirtyApp.LoginClassesChainOfResponsibily
{
    public class CheckUserName : LoginChecker
    {
        string _txt;
        User _user;
        public CheckUserName(string txtInput, User user) : base(txtInput, user)
        {
            this._txt = txtInput;
            this._user = user;
        }

       

        public override void Check(string txt , User user,loginStatus status)
        {
            RealChecker r = new RealChecker();
            if (!r.CheckUserName(txt, user))
            {
                //MessageBox.Show("نام کاربری صحیح نمی باشد.");
            }
            this.Next(status);
        }
    }
}
