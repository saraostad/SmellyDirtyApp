﻿using System;
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditProfile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OfferCourses();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertResult();
        }

        private void button6_Click(object sender, EventArgs e)
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
        }
    }
}
