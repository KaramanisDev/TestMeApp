using Newtonsoft.Json;
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
                    DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                    checkColumn.Name = "selectq";
                    checkColumn.HeaderText = "Select";
                    checkColumn.Width = 50;
                    checkColumn.ReadOnly = false;
                    checkColumn.Visible = true;

                    dgvMyQ.Columns.Add(checkColumn);
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

        private void dgvMyQ_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Utilities.rightClickSelect(dgvMyQ, e);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question TempQuest = new Question();
            TempQuest.id = Int32.Parse(dgvMyQ.SelectedRows[0].Cells[1].Value.ToString());
            TempQuest.question = dgvMyQ.SelectedRows[0].Cells[2].Value.ToString();
            TempQuest.anwsers = JsonConvert.DeserializeObject<List<Answer>>(dgvMyQ.SelectedRows[0].Cells[3].Value.ToString());
            TempQuest.dlevel = Int32.Parse(dgvMyQ.SelectedRows[0].Cells[4].Value.ToString());
            TempQuest.prive = Boolean.Parse(dgvMyQ.SelectedRows[0].Cells[5].Value.ToString());

            new frmAnswers(TempQuest).Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question TempQuest = new Question();
            TempQuest.id = Int32.Parse(dgvMyQ.SelectedRows[0].Cells[1].Value.ToString());
            TempQuest.question = dgvMyQ.SelectedRows[0].Cells[2].Value.ToString();
            TempQuest.anwsers = JsonConvert.DeserializeObject<List<Answer>>(dgvMyQ.SelectedRows[0].Cells[3].Value.ToString());
            TempQuest.dlevel = Int32.Parse(dgvMyQ.SelectedRows[0].Cells[4].Value.ToString());
            TempQuest.prive = Boolean.Parse(dgvMyQ.SelectedRows[0].Cells[5].Value.ToString());

            new frmEdit(TempQuest).Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgbResult = MessageBox.Show("Are you sure that you want to\nPermanatly delete the selected Question ?", "Delete Question",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (msgbResult == DialogResult.Yes)
            {
                dgvMyQ.Rows.RemoveAt(0);
                Utilities.runInThread(() =>
                {
                    Utilities.AsyncDB().nQuery("Delete Query Here");
                });
            }
        }

        private void txtAddTags_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtBoxReplaceSpaceNewLine(txtAddTags);
        }

        private void txtAddQ_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtBoxReplaceNewLine(txtAddQ);
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtBoxReplaceNewLine(txtAnswer);
        }

        private void txtTags_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtBoxReplaceSpaceNewLine(txtTags);
        }
    }
}
