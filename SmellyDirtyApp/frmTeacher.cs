using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmellyDirtyApp.CalcSalaryVisitor;
using SmellyDirtyApp.Models;

namespace SmellyDirtyApp
{
    public partial class frmTeacher : SmellyDirtyApp.BaseForm
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void tbMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalsSalary_Click(object sender, EventArgs e)
        {
            CalculateSalary();
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

        private void btnRegisterScore_Click(object sender, EventArgs e)
        {
            InsertResult();
        }

        private void InsertResult()
        {
            // Insert results to db.
        }

        private void btnOfferCourses_Click(object sender, EventArgs e)
        {
            OfferCourses();
        }

        private void OfferCourses()
        {
            // Complicated process to offer courses.
        }
    }

}
