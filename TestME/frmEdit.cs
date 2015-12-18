using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TestME
{
    public partial class frmEdit : Form
    {

        public Question _quest;
        bool change = false;

        public frmEdit(Question quest)
        {
            
            InitializeComponent();
            _quest = quest;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (change == true)
            {
                var msgbResult = MessageBox.Show("You don't save the change\nAre you sure to leave ?", "Close EditForm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (msgbResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void txtAddQ_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtBoxReplaceNewLine(txtAddQ);
        }

        private void txtAddTags_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtBoxReplaceSpaceNewLine(txtAddTags);
        }

        private void dgvAnswerlist_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Utilities.dgvCellEditing(dgvAnswerlist, "answer", e);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Focus();
            bool tagsdel = false;
            Utilities.runInThread(() =>
            {
                if (string.IsNullOrEmpty(txtAddQ.Text.Trim()) == true || string.IsNullOrEmpty(txtAddTags.Text.Trim()) == true || (dgvAnswerlist.Rows.Count < 1))
                {
                    Utilities.notifyThem(ntfEdit, "You must fill some info about your edit first.", NotificationBox.Type.Error);
                }
                else
                {

                    List<Answer> Answers = new List<Answer>();
                    for (int a = 0; a < dgvAnswerlist.Rows.Count - 1; a++)
                    {
                        bool correct;
                        if (dgvAnswerlist.Rows[a].Cells[1].Value == null)
                        {
                            correct = false;
                        }
                        else
                        {
                            correct = bool.Parse(dgvAnswerlist.Rows[a].Cells[1].Value.ToString());
                        }
                        Answers.Add(new Answer(dgvAnswerlist.Rows[a].Cells[0].Value.ToString().TrimEnd().TrimStart(), correct));
                    }


                    DB TempDB = Utilities.AsyncDB(true);
                    TempDB.bind(new string[] { "Question", txtAddQ.Text.TrimEnd().TrimStart(), "Answers", JsonConvert.SerializeObject(Answers).ToString(), "Dlevel", difficultyLvl.Value.ToString(), "Prive", (switchPrivate.isOn ? 1 : 0).ToString(), "UID", Globals.logUser.id.ToString() });

                    string qid = TempDB.single("UPDATE questions SET question = @Question, answers = @Answers, dlevel = @Dlevel, prive = @Prive, uid = @UID WHERE id=" + _quest.id + ";");

                    int qAddTag = 0;
                    string[] tags = txtAddTags.Text.TrimEnd(',').Split(',');
                    foreach (string tag in tags)
                    {
                        if (!string.IsNullOrEmpty(tag))
                        {
                            if (tagsdel == true)
                            {
                                TempDB.bind(new string[] { "TAG", tag.ToLower(), "QID", _quest.id.ToString() });
                                qAddTag += TempDB.nQuery("INSERT INTO tags (nametag, qid) VALUES (@TAG, @QID)");
                            }
                            else
                            {
                                TempDB.nQuery("DELETE FROM tags WHERE qid = " + _quest.id);
                                TempDB.bind(new string[] { "TAG", tag.ToLower(), "QID", _quest.id.ToString() });
                                qAddTag += TempDB.nQuery("INSERT INTO tags (nametag, qid) VALUES (@TAG, @QID)");
                                tagsdel = true;
                            }
                        }
                    }
                    Utilities.notifyThem(ntfEdit, "Successfully Saved.", NotificationBox.Type.Success);
                    Functionality.RefreshMyQuestions();
                    change = false;
                }
            }).Start();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

            autocompleteMenu1.Items = Globals.colTags.ToArray();

            string questtags = "";
            txtAddQ.Text = _quest.question;
            Utilities.runInThread(() => { 
                DB TempDB = Utilities.AsyncDB(true);
                DataTable dt = new DataTable();
                dt = TempDB.query("select nametag from tags where qid='" + _quest.id + "'");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == dt.Rows.Count - 1)
                    {
                        questtags += dt.Rows[i][0].ToString();
                    }
                    else
                    {
                        questtags += dt.Rows[i][0].ToString() + ",";
                    }
                }

                Utilities.InvokeMe(txtAddTags, () =>
                {
                    txtAddTags.Text = "" + questtags;
                });
            }).Start();
            for (int k = 0; k < _quest.anwsers.Count; k++)
            {
                dgvAnswerlist.Rows.Add(_quest.anwsers[k].text.ToString(), _quest.anwsers[k].correct);
            }
        }

        private void txtAddQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            change = true;
        }

        private void txtAddTags_KeyPress(object sender, KeyPressEventArgs e)
        {
            change = true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvAnswerlist.Rows.Remove(dgvAnswerlist.SelectedRows[0]);
        }

        private void dgvAnswerlist_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            change = true;
        }

        private void rcmAnswer_Opening(object sender, CancelEventArgs e)
        {
            Utilities.contextMenuEnable(dgvAnswerlist, removeToolStripMenuItem);
        }
    }
}
