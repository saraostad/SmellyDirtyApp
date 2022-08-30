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

namespace SmellyDirtyApp
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
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

        private void btnInsertResult_Click(object sender, EventArgs e)
        {
            InsertResult();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
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
            //Calculate salary based on work years.
            if (!string.IsNullOrWhiteSpace(txtWorkDay.Text))
            {
                IElement employee = new Employee();
                employee.WorkingDay = Convert.ToInt32(txtWorkDay.Text);

                var fine = new FinancialSystem();
                fine.Attach(employee);

                MessageBox.Show(fine.Accept(new SalaryCalculator()).ToString());
            }
            else MessageBox.Show("اطلاعات روز کارکرد را وارد نمایید");


        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
