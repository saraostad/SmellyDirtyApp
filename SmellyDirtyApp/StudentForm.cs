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
    public partial class StudentForm : Form
    {
        public StudentForm()
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
            SelectCourses();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeeResult();
        }

        private void EditProfile()
        {
            //Save changes to db.
        }

        private void SelectCourses()
        {
            // Complicated process to select courses.
        }

        private void SeeResult()
        {
            // Some reports to see exam result.
        }
    }
}
