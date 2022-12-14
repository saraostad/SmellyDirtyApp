using SmellyDirtyApp.LoginClassesChainOfResponsibily;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmellyDirtyApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (!UsersDatabase.Where(q => q.Username.Contains(txtUsername.Text)).Any())
                {
                    MessageBox.Show("نام کاربری و کلمه عبور صحیح نمی باشد.");
                    return;
                }
                foreach (var user in UsersDatabase)
                {
                    CheckUserName userName = new CheckUserName(txtUsername.Text, user);
                    CheckPassword password = new CheckPassword(txtPassword.Text, user);
                    CheckRole role = new CheckRole(txtUsername.Text, user);

                    userName.SuccessWith(password);
                    password.SuccessWith(role);

                    RealChecker status = new RealChecker();
                    userName.Check(txtUsername.Text, user, status);

                    
                    //if (user.Username == txtUsername.Text)
                    //{
                    //    if (user.Password == txtPassword.Text)
                    //    {
                    //        if (user.Role == "Student")
                    //        {
                    //            new StudentForm().ShowDialog();
                    //        }
                    //        else if (user.Role == "Teacher")
                    //        {
                    //            new TeacherForm().ShowDialog();
                    //        }
                    //        else if (user.Role == "Employee")
                    //        {
                    //            new EmployeeForm().ShowDialog();
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("نوع کاربری، در سیستم تعریف نشده است.");
                    //        }
                    //        return;
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("نام کاربری و کلمه عبور صحیح نمیباشد.");
                    //        return;
                    //    }
                    //}
                }
                //MessageBox.Show("نام کاربری و کلمه عبور صحیح نمیباشد.");
                //return;
            }
            MessageBox.Show("نام کاربری و کلمه عبور اجباری است..");
            return;
        }

        private List<User> UsersDatabase = new List<User>
        {
            new User("std1", "123", Models.RoleTypes.RoleType.Student),
            new User("tch1", "456", Models.RoleTypes.RoleType.Teacher),
            new User("emp1", "789", Models.RoleTypes.RoleType.Employee),
            new User("man1", "1234", Models.RoleTypes.RoleType.Manager)
        };

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }

    //internal class User
    //{
    //    public User(string username, string password, string role)
    //    {
    //        Username = username;
    //        Password = password;
    //        Role = role; ;
    //    }

    //    public string Password { get; set; }
    //    public string Username { get; set; }
    //    public string Role { get; set; }
    //}
}
