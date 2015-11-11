using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestME
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabMain.SelectTab(1);
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
            //Test Logged User
            Globals.logUser = new User(1, "demo", "demo", "demo@email.com");



            this.Hide();
            new frmMain().Show();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            Utilities.runInThread(() => {
                Globals.db = new DB(txthost.Text, txtuname.Text, txtpasswd.Text, txtDatabase.Text);
                if (Globals.db.Connected())
                {
                    Utilities.notifyThem(ntfBox3, "Successfully Connected !", NotificationBox.Type.Success);

                }
                else
                {
                    Utilities.notifyThem(ntfBox3, "Could not Connect to the Database.", NotificationBox.Type.Error);
                }
            }).Start();
        }
    }
}
