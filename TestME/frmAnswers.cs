using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestME
{
    public partial class frmAnswers : Form
    {
        public frmAnswers()
        {
            InitializeComponent();
        }

        private void frmAnswers_Load(object sender, EventArgs e)
        {
            switch (lblDifficultylvl.Text)
            {
                case "1":
                    lblDifficultylvl.ForeColor = Color.ForestGreen;
                break;
                case "2":
                    lblDifficultylvl.ForeColor = Color.ForestGreen;
                break;
                case "3":
                    lblDifficultylvl.ForeColor = Color.Goldenrod;
                break;
                case "4":
                    lblDifficultylvl.ForeColor = Color.OrangeRed;
                break;
                case "5":
                    lblDifficultylvl.ForeColor = Color.OrangeRed;
                break;

            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
