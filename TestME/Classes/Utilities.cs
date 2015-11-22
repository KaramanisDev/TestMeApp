using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            ctrl.Invoke((MethodInvoker)(mInvoke));
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
        
    } //end of class Utilities
}
