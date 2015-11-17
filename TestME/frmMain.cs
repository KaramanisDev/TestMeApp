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

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserMessage.Text += Globals.logUser.user + " !";
            tabUser.SelectTab(1);
            autocompleteMenu1.Items = Globals.colTags.ToArray();

            Functionality.RefreshMyQuestions();

        }

        private void dgvMyQ_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Utilities.rightClickSelect(dgvMyQ, e);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question TempQuest = new Question();
            TempQuest.id = int.Parse(dgvMyQ.SelectedRows[0].Cells[1].Value.ToString());
            TempQuest.question = dgvMyQ.SelectedRows[0].Cells[2].Value.ToString();
            TempQuest.anwsers = JsonConvert.DeserializeObject<List<Answer>>(dgvMyQ.SelectedRows[0].Cells[3].Value.ToString());
            TempQuest.dlevel = int.Parse(dgvMyQ.SelectedRows[0].Cells[4].Value.ToString());
            TempQuest.prive = Boolean.Parse(dgvMyQ.SelectedRows[0].Cells[5].Value.ToString());

            new frmAnswers(TempQuest).Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question TempQuest = new Question();
            TempQuest.id = int.Parse(dgvMyQ.SelectedRows[0].Cells[1].Value.ToString());
            TempQuest.question = dgvMyQ.SelectedRows[0].Cells[2].Value.ToString();
            TempQuest.anwsers = JsonConvert.DeserializeObject<List<Answer>>(dgvMyQ.SelectedRows[0].Cells[3].Value.ToString());
            TempQuest.dlevel = int.Parse(dgvMyQ.SelectedRows[0].Cells[4].Value.ToString());
            TempQuest.prive = Boolean.Parse(dgvMyQ.SelectedRows[0].Cells[5].Value.ToString());

            new frmEdit(TempQuest).Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgbResult = MessageBox.Show("Are you sure that you want to\nPermanatly delete the selected Question ?", "Delete Question",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (msgbResult == DialogResult.Yes)
            {
                int sid = int.Parse(dgvMyQ.SelectedRows[0].Cells[1].Value.ToString());
                Utilities.runInThread(() =>
                {
                    Utilities.AsyncDB().nQuery("DELETE FROM questions WHERE id = " + sid);
                    Utilities.AsyncDB().nQuery("DELETE FROM tags WHERE qid = " + sid);
                }).Start();
                dgvMyQ.Rows.Remove(dgvMyQ.SelectedRows[0]);
                Utilities.notifyThem(ntfMyQ, "Successfully Deleted !", NotificationBox.Type.Success);
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

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            btnDeleteSelected.Focus();
            string idsForDelete = "";
            List<int> cids = new List<int>();
            for (int i = 0; i < dgvMyQ.Rows.Count; i++)
            {
                if (bool.Parse(dgvMyQ.Rows[i].Cells[0].Value.ToString()))
                {
                    cids.Add(i);
                    idsForDelete += dgvMyQ.Rows[i].Cells[1].Value.ToString() + ",";
                }
            }
            if (cids.Count > 0)
            {
                var msgbResult = MessageBox.Show("Are you sure that you want to\nPermanatly delete the selected Questions ?", "Delete Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msgbResult == DialogResult.Yes)
                {
                    for (int k = (cids.Count-1); k >= 0; k--)
                    {
                        dgvMyQ.Rows.RemoveAt(int.Parse(cids[k].ToString()));
                    }
                    idsForDelete = idsForDelete.TrimEnd(',');
                    Utilities.runInThread(() =>
                    {
                        Utilities.AsyncDB().nQuery("DELETE FROM questions WHERE id IN (" + idsForDelete + ")");
                        Utilities.AsyncDB().nQuery("DELETE FROM tags WHERE qid IN (" + idsForDelete + ")");
                        Utilities.notifyThem(ntfMyQ, "Successfully Deleted " + cids.Count + " Questions !", NotificationBox.Type.Success);
                    }).Start();
                }
            }
            else
            {
                Utilities.notifyThem(ntfMyQ, "You didn't select any questions.", NotificationBox.Type.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddQ.Text.Trim()) == true || string.IsNullOrEmpty(txtAddTags.Text.Trim()) == true || (dgvAnswerlist.Rows.Count < 1))
            {
                Utilities.notifyThem(ntfAdd, "You must fill some info about your question first.", NotificationBox.Type.Error);
            }
            else
            {
                List<Answer> Answers = new List<Answer>();
                for(int i=0; i < dgvAnswerlist.Rows.Count; i++)
                {
                    Answers.Add(new Answer(dgvAnswerlist.Rows[i].Cells[0].Value.ToString().TrimEnd().TrimStart(), bool.Parse(dgvAnswerlist.Rows[i].Cells[1].Value.ToString())));
                }
                Utilities.runInThread(() =>
                {
                    DB TempDB = Utilities.AsyncDB(true);
                    TempDB.bind(new string[] {"Question",txtAddQ.Text.TrimEnd().TrimStart(), "Answers", JsonConvert.SerializeObject(Answers).ToString(), "Dlevel", difficultyLvl.Value.ToString(), "Prive", (switchPrivate.isOn ? 1 : 0).ToString(), "UID", Globals.logUser.id.ToString() });
                    string qid = TempDB.single("INSERT INTO questions (question, answers, dlevel, prive, uid) VALUES (@Question, @Answers, @Dlevel, @Prive, @UID); select last_insert_id();");

                    int qAddTag = 0;
                    string[] tags = txtAddTags.Text.TrimEnd(',').Split(',');
                    foreach (string tag in tags)
                    {
                        TempDB.bind(new string[] { "TAG", tag, "QID", qid });
                        qAddTag += TempDB.nQuery("INSERT INTO tags (nametag, qid) VALUES (@TAG, @QID)");
                    }

                    if (string.IsNullOrEmpty(qid) == false && qAddTag > 0)
                    {
                        Utilities.notifyThem(ntfAdd, "Successfull Added Question !", NotificationBox.Type.Success);
                        Functionality.RefreshMyQuestions();
                        Utilities.InvokeMe(txtAddQ, () =>
                         {
                             txtAddQ.Text = "";
                         });
                        Utilities.InvokeMe(dgvAnswerlist, () =>
                        {
                            dgvAnswerlist.Rows.Clear();
                            dgvAnswerlist.Refresh();
                        });
                        Utilities.InvokeMe(txtAddTags, () =>
                        {
                            txtAddTags.Text = "";
                        });
                        Utilities.InvokeMe(difficultyLvl, () =>
                        {
                            difficultyLvl.Value = 1;
                        });
                        Utilities.InvokeMe(switchPrivate, () =>
                        {
                            switchPrivate.isOn = false;
                        });

                        Functionality.LoadTags(autocompleteMenu1);
                    }
                }).Start();

            }
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnswer.Text.Trim()))
            {
                Utilities.notifyThem(ntfAdd, "Write your answer first.", NotificationBox.Type.Warning);
            }
            else
            {
                dgvAnswerlist.Rows.Add(txtAnswer.Text.TrimEnd().TrimStart(), switchCorrectAnswer.isOn);
                txtAnswer.Text = "";
                switchCorrectAnswer.isOn = true;
            }
        }

        private void dgvAnswerlist_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvAnswerlist.CurrentCell != null && dgvAnswerlist.CurrentCell.ColumnIndex == dgvAnswerlist.Columns["answer"].Index)
            {
                Control cntObject = new Control();
                e.Control.TextChanged += new EventHandler((object sse, EventArgs se) => Cell_TextChanged(sse, dgvAnswerlist, cntObject));
                cntObject = e.Control;
                cntObject.TextChanged += (object sse, EventArgs se) => Cell_TextChanged(sse, dgvAnswerlist, cntObject);
            }
        }

        private void Cell_TextChanged(object sender,DataGridView dgv, Control e)
        {
            if (e != null)
            {
                Utilities.txtBoxReplaceNewLine((TextBox)e);
                dgv.CurrentCell.Value = e.Text;
            }
        }
    }
}
