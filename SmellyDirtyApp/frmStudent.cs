using SmellyDirtyApp.UserControls;
using SmellyDirtyApp.UserControls.btn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmellyDirtyApp
{
    public partial class frmStudent : SmellyDirtyApp.BaseForm
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            ucBasicInfo_StudentCode ucDynamic = new ucBasicInfo_StudentCode();
            pnlucDynamicFild.Controls.Add(ucDynamic);
            ucDynamic.Dock = DockStyle.Fill;

            ucbtnShowResult ucbtnShowResult = new ucbtnShowResult();
            pnlUserControl.Controls.Add(ucbtnShowResult);
            ucbtnShowResult.Dock = DockStyle.Left;

            ucbtnOfferClass ucbtnOfferClass = new ucbtnOfferClass();
            pnlUserControl.Controls.Add(ucbtnOfferClass);
            ucbtnOfferClass.Dock = DockStyle.Right;


        }
    }
}
