using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmellyDirtyApp.CalcSalaryVisitor;
using SmellyDirtyApp.Models;
using SmellyDirtyApp.UserControls;

namespace SmellyDirtyApp
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOfferCourses_Click(object sender, EventArgs e)
        {
            OfferCourses();
        }

        private void btnRegisterScore_Click(object sender, EventArgs e)
        {
            InsertResult();
        }

        private void btnCalsSalary_Click(object sender, EventArgs e)
        {
            CalculateSalary();
        }

        private void EditProfile()
        {
            //Save changes to db.
        }

        private void OfferCourses()
        {
            // Complicated process to offer courses.
        }

        private void InsertResult()
        {
            // Insert results to db.
        }

        private void CalculateSalary()
        {
            if (!string.IsNullOrWhiteSpace(txtWorkHours.Text))
            {
                var workHours = Convert.ToInt32(txtWorkHours.Text);
                //Calculate salary based on work hours.

                IElement teacher = new Teacher();
                teacher.WorkingHour = workHours;

                var fine = new FinancialSystem();
                fine.Attach(teacher);

                MessageBox.Show(fine.Accept(new SalaryCalculator()).ToString());
            }
            else MessageBox.Show("اطلاعات ساعت کارکرد را وارد نمایید");
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            ucPersonBase uc = new ucPersonBase();
            pnlBaseInfo.Contains(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
