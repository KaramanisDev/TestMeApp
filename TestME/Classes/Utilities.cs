using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography;

namespace TestME
{
    public static class Utilities
    {
        public static void txtBoxReplaceNewLine(TextBox txtb)
        {
            int cpos = txtb.SelectionStart;
            txtb.Text = txtb.Text.Replace(Environment.NewLine, "");
            txtb.SelectionStart = cpos;
        }

        public static void txtBoxReplaceSpaceNewLine(TextBox txtb)
        {
            int cpos = txtb.SelectionStart;
            txtb.Text = txtb.Text.Replace(Environment.NewLine, "");
            txtb.Text = txtb.Text.Replace(" ", "");
            txtb.SelectionStart = cpos;
        }
    
        public static void txtCustomReplaceSpace(XylosTextBox txtb)
        {
            int cpos = txtb.SelectionStart;
            txtb.Text = txtb.Text.Replace(Environment.NewLine, "");
            txtb.Text = txtb.Text.Replace(" ", "");
            txtb.SelectionStart = cpos;
        }

        public static void Cell_TextChanged(object sender, DataGridView dgv, Control e)
        {
            if (e != null)
            {
                Utilities.txtBoxReplaceNewLine((TextBox)e);
                dgv.CurrentCell.Value = e.Text;
            }
        }
        public static void dgvCellEditing(DataGridView dgv,string columnName, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == dgv.Columns[columnName].Index)
            {
                Control cntObject = new Control();
                e.Control.TextChanged += new EventHandler((object sse, EventArgs se) => Utilities.Cell_TextChanged(sse, dgv, cntObject));
                cntObject = e.Control;
                cntObject.TextChanged += (object sse, EventArgs se) => Utilities.Cell_TextChanged(sse, dgv, cntObject);
            }
            dgv.RefreshEdit();
        }

        public static Question dgvRowIntoQuestion(DataGridViewRow dgvRow)
        {
            Question TempQuest = new Question();
            TempQuest.id = int.Parse(dgvRow.Cells[1].Value.ToString());
            TempQuest.question = dgvRow.Cells[2].Value.ToString();
            TempQuest.anwsers = JsonConvert.DeserializeObject<List<Answer>>(dgvRow.Cells[3].Value.ToString());
            TempQuest.dlevel = int.Parse(dgvRow.Cells[4].Value.ToString());
            TempQuest.prive = Boolean.Parse(dgvRow.Cells[5].Value.ToString());

            return TempQuest;
        }

        public static void dgvRowMoveUpDown(DataGridView dgv,bool moveDown)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int rowCount = dgv.Rows.Count;
                int index = dgv.SelectedCells[0].OwningRow.Index;

                if (moveDown)
                {
                    if (index == (rowCount - 1)) // include the header row
                    {
                        return;
                    }
                }
                else
                {
                    if (index == 0)
                    {
                        return;
                    }
                }

                DataGridViewRowCollection rows = dgv.Rows;
                DataGridViewRow tempRow;

                if (moveDown)
                {
                    tempRow = rows[index + 1];
                }
                else
                {
                    tempRow = rows[index - 1];
                }

                rows.Remove(tempRow);
                tempRow.Frozen = false;
                rows.Insert(index, tempRow);
                dgv.ClearSelection();
                if (moveDown)
                {
                    dgv.Rows[index + 1].Selected = true;
                }
                else
                {
                    dgv.Rows[index - 1].Selected = true;
                }

            }
        }

        public static void dgvRandomShuffle(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Selected = true;

                Random rnd = new Random();
                int timesToShuffle = rnd.Next(1, dgv.Rows.Count);
                for (int k = 0; k < timesToShuffle; k++)
                {
                    int upOrDown = rnd.Next(1, 10);
                    if (upOrDown <= 5)
                    {
                        dgvRowMoveUpDown(dgv, true);
                    }
                    else
                    {
                        dgvRowMoveUpDown(dgv, false);
                    }
                }
            }
        }

        public static void contextMenuEnable(DataGridView dgv,params ToolStripMenuItem[] controls)
        {
            bool qExists;
            if (dgv.Rows.Count < 1)
            {
                qExists = false;
            }
            else
            {
                qExists = true;
            }
            foreach (ToolStripMenuItem ctrl in controls)
            {
                ctrl.Enabled = qExists;
            }
        }

        public static void rightClickSelect(DataGridView dgv, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex >=0 && e.RowIndex >=0)
            {
                dgv.CurrentCell = dgv[e.ColumnIndex, e.RowIndex];
            }
        }

        public static void notifyThem(NotificationBox ntfbox,string msg,NotificationBox.Type ntype)
        {
            InvokeMe(ntfbox, () =>
            { 
                ntfbox.Text = msg;
                ntfbox.NotificationType = ntype;
                ntfbox.Visible = true;
                ntfbox.Show();
                switch (ntype)
                {
                    case NotificationBox.Type.Success:
                        ntfbox.Image = TestME.Properties.Resources.tick;
                        break;
                    case NotificationBox.Type.Error:
                        ntfbox.Image = TestME.Properties.Resources.error;
                        break;
                    case NotificationBox.Type.Warning:
                        ntfbox.Image = TestME.Properties.Resources.warning;
                        break;
                    case NotificationBox.Type.Notice:
                        ntfbox.Image = TestME.Properties.Resources.notice;
                        break;
                    case NotificationBox.Type.Other:
                        ntfbox.Image = TestME.Properties.Resources.star;
                        break;
                }
            });
        }

        public static Thread runInThread(Action func)
        {
            return new Thread(new ThreadStart(func));
        }

        public static DB AsyncDB(bool DebugMe = false)
        {
            DB tempDB = new DB(Globals.ConnectionStr());
            tempDB.Debug = DebugMe;
            return tempDB;
        }

        public static void InvokeMe(Control ctrl, MethodInvoker mInvoke)
        {
            try
            {
                ctrl.Invoke((MethodInvoker) (mInvoke));
            }
            catch (Exception){}
        }

        public static Control FindControl(Form form, string name)
        {
            foreach (Control control in form.Controls)
            {
                Control result = FindControl(form, control, name);
                if (result != null)
                    return result;
            }

            return null;
        }

        private static Control FindControl(Form form, Control control, string name)
        {
            if (control.Name == name)
            {
                return control;
            }

            foreach (Control subControl in control.Controls)
            {
                Control result = FindControl(form, subControl, name);
                if (result != null)
                    return result;
            }

            return null;
        }

        public static void clearText(params Control[] controls)
        {
            for (int i= 0; i < controls.Length; i++) {
                InvokeMe(controls[i], () => {
                    switch (controls[i].GetType().ToString())
                    {
                        case "XylosTextBox":
                            controls[i].Text = "";
                            break;
                        case "System.Windows.Forms.TextBox":
                            controls[i].Text = "";
                            break;
                    }
                });
            }
        }

        public static string MD5Hash(string txt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(txt));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }


    } //end of class Utilities
}
