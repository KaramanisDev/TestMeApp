using System;
using System.Collections.Generic;
using System.IO;
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

       public static void saveSettings(string filename, params string[] details)
        {
            if (!Directory.Exists(Globals.FilesPath + "\\TestME"))
            {
                Directory.CreateDirectory(Globals.FilesPath + "\\TestME");
            }
            // Write the string array to a new file named "StoredSettings.txt". If file exists overwrite data.
            using (StreamWriter outputFile = new StreamWriter(Globals.FilesPath + "\\TestME\\" + filename,false))
            {
                foreach (string line in details)
                    outputFile.WriteLine(line);
            }
        }

        public static string[] loadSettings(string filename, int size)
        {
            string[] details = new string[size];
            // Open the text file using a stream reader.
            if (File.Exists(Globals.FilesPath +"\\TestME\\" + filename))
            {
                using (StreamReader file = new StreamReader(Globals.FilesPath + "\\TestME\\" + filename))
                {
                    // Read the stream to a string, and write the string to the console.
                    for (int i=0; i<details.Length; i++)
                    {
                        details[i]=file.ReadLine();
                    }
                    
                }
            }
            return details;
        }

        public static DB AsyncDB(bool DebugMe = false)
        {
            DB tempDB = new DB(Globals.ConnectionStr());
            tempDB.Debug = DebugMe;
            return tempDB;
        }

    } //end of class Utilities
}
