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

            Utilities.runInThread(() =>
            {
                Functionality.RefreshMyQuestions();
            }).Start();

            pusername.Text = Globals.logUser.user;
            pemail.Text = Globals.logUser.email;

            Utilities.runInThread(() => 
            {
                Utilities.InvokeMe(pdatabase, () =>
                {
                    pdatabase.Text = Utilities.FindControl(Globals.formStart, "txtDatabase").Text;
                });

                string tmp = Utilities.AsyncDB().single("SELECT COUNT(*) FROM questions WHERE uid=" + Globals.logUser.id);


                Utilities.InvokeMe(pnumQ, () => 
                    {
                        pnumQ.Text = tmp;
                    });
            }).Start();
            
        }

        private void dgvMyQ_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Utilities.rightClickSelect(dgvMyQ, e);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAnswers(Utilities.dgvRowIntoQuestion(dgvMyQ.SelectedRows[0])).Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEdit(Utilities.dgvRowIntoQuestion(dgvMyQ.SelectedRows[0])).Show();
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
                        TempDB.bind(new string[] { "TAG", tag.ToLower(), "QID", qid });
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
                        Utilities.InvokeMe(txtAnswer, () =>
                        {
                            txtAnswer.Text = "";
                        });
                        Utilities.InvokeMe(switchCorrectAnswer, () =>
                        {
                            switchCorrectAnswer.isOn = true;
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
            Utilities.dgvCellEditing(dgvAnswerlist, "answer", e);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTags.Text))
            {
                Utilities.notifyThem(ntbfindQ, "You must add some tags first.", NotificationBox.Type.Error);
            }
            else
            {
                Utilities.runInThread(() =>
                {
                    DB TempDB = Utilities.AsyncDB(true);
                    string[] tags = txtTags.Text.TrimEnd(',').Split(',');
                    string conQuery = "";
                    for(int i = 0;i< tags.Length;i++)
                    {
                        conQuery += "@" + i + ",";
                    }

                    string fromall = "";
                    if (switchFindAll.isOn)
                    {
                        fromall = "(prive = 0 and uid != " + Globals.logUser.id + ") or ";
                    }

                    DataTable dt = new DataTable();

                    TempDB.qBind(tags);
                    if (!switchAllTags.isOn) {
                        dt = TempDB.query("select * from questions where (" + fromall + "uid = " + Globals.logUser.id + ") and dlevel >= "+ numericMin.Value + " and dlevel <= " + numericMax.Value + " and id in(select distinct qid from tags where nametag in (" + conQuery.TrimEnd(',') + "));");
                    }
                    else
                    {
                        dt = TempDB.query("SELECT * FROM  `questions` WHERE (" + fromall + "uid = " + Globals.logUser.id + ") and dlevel >= " + numericMin.Value + " and dlevel <= " + numericMax.Value + " and id IN (SELECT qid FROM  `tags` WHERE nametag IN (SELECT nametag FROM tags WHERE nametag IN (" + conQuery.TrimEnd(',') + ")) GROUP BY qid HAVING COUNT( qid ) = " + tags.Length +")");
                    }

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dt.Columns[i].ReadOnly = true;
                    }

                    Utilities.InvokeMe(dgvFoundQ, () =>
                    {
                        dgvFoundQ.DataSource = dt;
                        dgvFoundQ.Columns[0].Visible = true;
                        dgvFoundQ.Columns[0].Width = 50;
                        dgvFoundQ.Columns[1].Visible = false;
                        dgvFoundQ.Columns[2].HeaderText = "Questions";
                        dgvFoundQ.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvFoundQ.Columns[2].Width = 410;
                        dgvFoundQ.Columns[3].Visible = false;
                        dgvFoundQ.Columns[4].HeaderText = "Difficulty";
                        dgvFoundQ.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvFoundQ.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgvFoundQ.Columns[4].Width = 60;
                        dgvFoundQ.Columns[5].Visible = false;
                        dgvFoundQ.Columns[6].Visible = false;
                        for (int i = 0; i < dgvFoundQ.Rows.Count; i++)
                        {
                            dgvFoundQ.Rows[i].Cells[0].Value = "False";
                        }
                    });

                    if (dt.Rows.Count < 1) {
                        DataTable da = new DataTable();
                        Utilities.InvokeMe(dgvFoundQ, () =>
                        {
                            dgvFoundQ.DataSource = da;
                            dgvFoundQ.Columns[0].Visible = false;
                        });
                    }

                    Utilities.notifyThem(ntbfindQ, "Found " + dt.Rows.Count + " Questions.", NotificationBox.Type.Notice);

                }).Start();
            }
        }

        private void btnMakeTest_Click(object sender, EventArgs e)
        {
            btnMakeTest.Focus();

            int AddedQ = 0;

            for (int i = 0; i < dgvFoundQ.Rows.Count; i++)
            {
                int id = int.Parse(dgvFoundQ.Rows[i].Cells[1].Value.ToString());
                if (bool.Parse(dgvFoundQ.Rows[i].Cells[0].Value.ToString()) && !Globals.MyTestQids.Contains(id))
                {
                    AddedQ++;
                    string question = dgvFoundQ.Rows[i].Cells[2].Value.ToString();
                    string answers = dgvFoundQ.Rows[i].Cells[3].Value.ToString();
                    int dlevel = int.Parse(dgvFoundQ.Rows[i].Cells[4].Value.ToString());
                    dgvMyTest.Rows.Add("NONE",id, question, answers, dlevel,false);
                    Globals.MyTestQids.Add(id);
                }
            }
            if(AddedQ < 1)
            {
                Utilities.notifyThem(ntbfindQ, "No Questions selected to add.", NotificationBox.Type.Warning);
            }
            else
            {
                Utilities.notifyThem(ntbfindQ, AddedQ + " Questions Added to your Test !", NotificationBox.Type.Success);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = (dgvFoundQ.Rows.Count-1); i >= 0 ; i--)
            {
                dgvFoundQ.Rows.RemoveAt(i);
            }

            txtTags.Text = "";
            switchAllTags.isOn = false;
            switchFindAll.isOn = true;
            numericMin.Value = 1;
            numericMax.Value = 5;
            Utilities.notifyThem(ntbfindQ, "Cleared Search result and settings !", NotificationBox.Type.Other);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = (dgvAnswerlist.Rows.Count - 1); i >= 0; i--)
            {
                dgvAnswerlist.Rows.RemoveAt(i);
            }

            txtAddQ.Text = "";
            txtAddTags.Text = "";
            txtAnswer.Text = "";
            difficultyLvl.Value = 1;
            switchPrivate.isOn = false;
            switchCorrectAnswer.isOn = true;
            Utilities.notifyThem(ntfAdd, "Cleared Question info !", NotificationBox.Type.Other);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtopassword.Text) == true || string.IsNullOrEmpty(txtnpassword.Text) == true || string.IsNullOrEmpty(txtrnpassword.Text))
            {
                Utilities.notifyThem(ntfP, "You must fill all fields", NotificationBox.Type.Error);
            }
            else if (!txtnpassword.Text.Equals(txtrnpassword.Text))
            {
                Utilities.notifyThem(ntfP, "Different new Password fields", NotificationBox.Type.Error);
            }
            else if (!Globals.logUser.pass.Equals(txtopassword.Text))
            {
                Utilities.notifyThem(ntfP, "Wrong old Password", NotificationBox.Type.Error);
            }
            else
            {
                Utilities.runInThread(() =>
                {
                    DB TempDB = Utilities.AsyncDB();
                    TempDB.bind(new string[] { "Pass", txtnpassword.Text });
                    TempDB.nQuery("UPDATE users SET pass=@Pass WHERE id=" + Globals.logUser.id);
                    Utilities.InvokeMe(txtopassword, () =>
                    {
                        txtopassword.Text = "";
                    });
                    Utilities.InvokeMe(txtnpassword, () =>
                    {
                        txtnpassword.Text = "";
                    });
                    Utilities.InvokeMe(txtrnpassword, () =>
                    {
                        txtrnpassword.Text = "";
                    });
                }).Start();
                Utilities.notifyThem(ntfP, "Password Changed", NotificationBox.Type.Success);
            }
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtepassword.Text) == true || string.IsNullOrEmpty(txtnemail.Text.Trim()) == true)
            {
                Utilities.notifyThem(ntfE, "You must fill all fields", NotificationBox.Type.Error);
            }
            else if (!Globals.logUser.pass.Equals(txtepassword.Text))
            {
                Utilities.notifyThem(ntfE, "Wrong Password", NotificationBox.Type.Error);
            }
            else
            {
                Utilities.runInThread(() =>
                {
                    DB TempDB = Utilities.AsyncDB();
                    TempDB.bind(new string[] { "Email", txtnemail.Text.Trim() });
                    TempDB.nQuery("UPDATE users SET email=@Email WHERE id=" + Globals.logUser.id);
                    Utilities.InvokeMe(txtepassword, () =>
                    {
                        txtepassword.Text = "";
                    }); 
                    Utilities.InvokeMe(txtnemail, () =>
                    {
                        txtnemail.Text = "";
                    }); 
                }).Start();
                Utilities.notifyThem(ntfE, "Email Changed", NotificationBox.Type.Success);
            }
        }

        private void btnChangeSecurity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtspassword.Text) == true || string.IsNullOrEmpty(txtncode.Text.Trim()) == true)
            {
                Utilities.notifyThem(ntfC, "You must fill all fields", NotificationBox.Type.Error);
            }
            else if (!Globals.logUser.pass.Equals(txtspassword.Text))
            {
                Utilities.notifyThem(ntfC, "Wrong Password", NotificationBox.Type.Error);
            }
            else
            {
                Utilities.runInThread(() =>
                {
                    DB TempDB = Utilities.AsyncDB();
                    TempDB.bind(new string[] { "Code", txtncode.Text.Trim() });
                    TempDB.nQuery("UPDATE users SET securitycode=@Code WHERE id=" + Globals.logUser.id);
                    Utilities.InvokeMe(txtspassword, () =>
                    {
                        txtspassword.Text = "";
                    }); 
                    Utilities.InvokeMe(txtncode, () =>
                    {
                        txtncode.Text = "";
                    }); 
                }).Start();
                Utilities.notifyThem(ntfC, "Security Code Changed", NotificationBox.Type.Success);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Question> myTest = new List<Question>();
          
            if (string.IsNullOrWhiteSpace(txtTestTitle.Text))
            {
                Utilities.notifyThem(ntfTest, "No title found.", NotificationBox.Type.Warning);
            }
            else if (dgvMyTest.Rows.Count < 1)
            {
                Utilities.notifyThem(ntfTest, "No Questions Found.", NotificationBox.Type.Warning);
            }
            else
            {

                foreach (DataGridViewRow row in dgvMyTest.Rows)
                {
                    myTest.Add(Utilities.dgvRowIntoQuestion(row));
                }

                PrintTest.Initialize();
                PrintTest.SetTest(txtTestTitle.Text, datePicker.Value.ToShortDateString(), myTest, checkBoxAnsweredTest.Checked);
                Globals.formPrint.Document = PrintTest.Document;
                Globals.formPrint.ShowDialog();
            }
            
        }

        private void dgvAnswerlist_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Utilities.rightClickSelect(dgvAnswerlist, e);
        }

        private void dgvFoundQ_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Utilities.rightClickSelect(dgvFoundQ, e);
        }

        private void dgvMyTest_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Utilities.rightClickSelect(dgvMyTest, e);
        }

        private void dgvMyQ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMyQ.SelectedRows.Count > 0)
            {
                new frmAnswers(Utilities.dgvRowIntoQuestion(dgvMyQ.SelectedRows[0])).Show();
            }
        }

        private void txtncode_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtncode);
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmAnswers(Utilities.dgvRowIntoQuestion(dgvFoundQ.SelectedRows[0]));
        }

        private void dgvFoundQ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFoundQ.SelectedRows.Count > 0)
            {
                new frmAnswers(Utilities.dgvRowIntoQuestion(dgvFoundQ.SelectedRows[0])).Show();
            }
        }

        private void dgvMyTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMyTest.SelectedRows.Count > 0)
            {
                new frmAnswers(Utilities.dgvRowIntoQuestion(dgvMyTest.SelectedRows[0])).Show();
            }
        }

        private void txtnemail_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtnemail);
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            btnAddTest.Focus();

            int AddedQ = 0;

            for (int i = 0; i < dgvMyQ.Rows.Count; i++)
            {
                int id = int.Parse(dgvMyQ.Rows[i].Cells[1].Value.ToString());
                if (bool.Parse(dgvMyQ.Rows[i].Cells[0].Value.ToString()) && !Globals.MyTestQids.Contains(id))
                {
                    AddedQ++;
                    string question = dgvMyQ.Rows[i].Cells[2].Value.ToString();
                    string answers = dgvMyQ.Rows[i].Cells[3].Value.ToString();
                    int dlevel = int.Parse(dgvMyQ.Rows[i].Cells[4].Value.ToString());
                    dgvMyTest.Rows.Add("NONE", id, question, answers, dlevel, false);
                    Globals.MyTestQids.Add(id);
                }
            }
            if (AddedQ < 1)
            {
                Utilities.notifyThem(ntfMyQ, "No Questions added.", NotificationBox.Type.Warning);
            }
            else
            {
                Utilities.notifyThem(ntfMyQ, AddedQ + " Questions Added to your Test !", NotificationBox.Type.Success);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundQ.Rows.Count > 0)
            {
                for (int i = 0; i < dgvFoundQ.Rows.Count; i++)
                {
                    dgvFoundQ.Rows[i].Cells[0].Value = "True";
                }
            }
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvMyQ.Rows.Count > 0)
            {
                for (int i = 0; i < dgvMyQ.Rows.Count; i++)
                {
                    dgvMyQ.Rows[i].Cells[0].Value = "True";
                }
            }
        }
    }
}
