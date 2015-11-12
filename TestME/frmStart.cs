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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            tabMain.SelectTab(1);
            string[] fill=Utilities.loadSettings("StoredSettings",4);
            txthost.Text = fill[0];
            txtuname.Text = fill[1];
            txtpasswd.Text = fill[2];
            txtDatabase.Text = fill[3];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Globals.Connected)
            {
                frmStart cFRM = this;

                Utilities.runInThread(() => {            
                    //Test Logged User
                    Globals.logUser = new User(1, "demo", "fe01ce2a7fbac8fafaed7c982a04e229", "demo@email.com");

                    //Load Tags
                    Globals.colTags = Utilities.AsyncDB().column("SELECT DISTINCT nametag FROM tags");

                    //Add also some extra Tags in case db is empty
                    Globals.colTags.Add("TestTag");
                    Globals.colTags.Add("DemoTag");
                    Globals.colTags.Add("UserTag");
                    Globals.colTags.Add("SomeTag");
                    Globals.colTags.Add("SomeTag");

                    cFRM.Invoke((MethodInvoker)(() =>
                    {
                        cFRM.Hide();
                        new frmMain().Show();
                    }));

                }).Start();
            }
            else
            {
                Utilities.notifyThem(ntfBox1, "Not connected to DB!", NotificationBox.Type.Warning);
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            Utilities.runInThread(() => {
                Globals.ConnectionStr(txthost.Text, txtuname.Text, txtpasswd.Text, txtDatabase.Text);
                if (Utilities.AsyncDB().Connected())
                {
                    Globals.Connected = true;                   
                }
                if (Globals.Connected)
                {
                    if (checkBoxRemember.Checked)
                    {
                        Utilities.saveSettings("StoredSettings", txthost.Text, txtuname.Text, txtpasswd.Text, txtDatabase.Text);
                    }
                    Utilities.notifyThem(ntfBox3, "Successfully Connected !", NotificationBox.Type.Success);

                }
                else
                {
                    Utilities.notifyThem(ntfBox3, "Could not Connect to the Database.", NotificationBox.Type.Error);
                }
            }).Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Globals.Connected)
            {
                if (txtusername.Text == "" || txtpass.Text == "" || txtrepeatpass.Text == "" || txtemail.Text == "")
                {
                    Utilities.notifyThem(ntfBox2, "All fields are necessary.", NotificationBox.Type.Warning);
                }else if (txtpass.Text != txtrepeatpass.Text)
                {
                    Utilities.notifyThem(ntfBox2, "Passwords don't match.", NotificationBox.Type.Warning);
                }else if (!Validation.IsValidEmail(txtemail.Text))
                {
                    Utilities.notifyThem(ntfBox2, "Email is not valid.", NotificationBox.Type.Warning);
                }else
                {
                    Utilities.runInThread(() =>
                    {
                        DB tDB = Utilities.AsyncDB();
                        tDB.bind(new string[] { "usern", txtusername.Text, "pass1", txtpass.Text , "email1", txtemail.Text });
                        
                        int qreg = tDB.nQuery("INSERT INTO users (user, pass, email) VALUES (@usern, @pass1, @email1)");
                        
                        if (qreg>0)
                        {
                            Utilities.notifyThem(ntfBox2, "Successfull Registration.", NotificationBox.Type.Success);
                        }

                    }).Start();
                }

            }
            else
            {
                Utilities.notifyThem(ntfBox2, "Not connected to DB!", NotificationBox.Type.Warning);
            }
        }
    }
}
