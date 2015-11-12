using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestME
{
    public static class Utilities
    {
        public static void txtBoxReplaceSpace(TextBox txtb)
        {
            int cpos = txtb.SelectionStart;
            txtb.Text = txtb.Text.Replace(Environment.NewLine, "");
            txtb.SelectionStart = cpos;
        }

        public static void notifyThem(NotificationBox ntfbox,string msg,NotificationBox.Type ntype)
        {
            ntfbox.Invoke((MethodInvoker)(() => {
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
            }));
        }

        public static Thread runInThread(Action func)
        {
            return new Thread(new ThreadStart(func));
        }

       

    } //end of class Utilities
}
