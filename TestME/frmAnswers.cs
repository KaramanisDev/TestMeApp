using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestME
{
    public partial class frmAnswers : Form
    {
        Question Q;

        public frmAnswers(Question quest)
        {
            InitializeComponent();
            Q = quest;
        }

        private void frmAnswers_Load(object sender, EventArgs e)
        {
            txtAddQ.Text = Q.question;
            lblDifficultylvl.Text = Q.dlevel.ToString();
            for (int i = 0; i < Q.anwsers.Count; i++)
            {
                dgvAnswerList.Rows.Add(Q.anwsers[i].text, Q.anwsers[i].correct);
            }
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
            this.Close();
        }
    }
}
