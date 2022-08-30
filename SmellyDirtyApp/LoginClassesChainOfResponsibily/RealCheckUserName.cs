using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmellyDirtyApp.Models.RoleTypes;

namespace SmellyDirtyApp.LoginClassesChainOfResponsibily
{
    
internal class RealChecker : loginStatus
    {
        public override bool CheckPassword(string txtInput, User model)
        {
            if (txtInput != model.Password)
            {
                return false;
            }
            return true;
        }

        public override bool CheckRole(User model)
        {
            switch (model.Role)
            {
                case RoleType.Student:
                    {
                        new StudentForm().ShowDialog();
                        return true;
                    }
                case RoleType.Teacher:
                    {
                        new TeacherForm().ShowDialog();
                        return true;
                    }
                case RoleType.Employee:
                    {
                        new EmployeeForm().ShowDialog();
                        return true;
                    }
                default:
                    {
                        MessageBox.Show("نوع کاربری، در سیستم تعریف نشده است.");
                        return false;
                    }
            }
        }

        public override bool CheckUserName(string txtInput, User model)
        {
            if (txtInput != model.Username)
            {
                return false;
            }
            return true;
        }
    }
}
