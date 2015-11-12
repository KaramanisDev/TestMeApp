using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestME
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void frmUser_Load(object sender, EventArgs e)
        {
            lblUserMessage.Text += Globals.logUser.user + " !";
            tabUser.SelectTab(1);
            autocompleteMenu1.Items = Globals.colTags.ToArray();

            Utilities.runInThread(() =>
            {
                DataTable dt = Utilities.AsyncDB().query("SELECT * FROM questions WHERE uid=1");
                if (dt.Rows.Count > 0)
                {
                    lblRegQ.Invoke((MethodInvoker)(() =>
                    {
                        lblRegQ.Visible = false;
                    }));
                }
                dgvMyQ.Invoke((MethodInvoker)(() =>
                {
                    dgvMyQ.DataSource = dt;
                    dgvMyQ.Columns[1].Visible = false;
                    dgvMyQ.Columns[2].HeaderText = "Questions";
                    dgvMyQ.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvMyQ.Columns[2].Width = 390;
                    dgvMyQ.Columns[3].Visible = false;
                    dgvMyQ.Columns[4].Visible = false;
                    dgvMyQ.Columns[5].HeaderText = "Private";
                    dgvMyQ.Columns[5].Width = 60;
                    dgvMyQ.Columns[6].Visible = false;
                }));
                
            }).Start();

        }

    }
}
