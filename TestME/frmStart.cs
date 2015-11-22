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
            Globals.formStart = this;
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            tabMain.SelectTab(1);
            tabforgot.Text = "";
            tabforgot.Tag = "hide";

            string[] fillS=Settings.load("StoredSettings",6);
            if (fillS[0] == "True") { 
                txtSHost.Text = fillS[2];
                txtSUser.Text = fillS[3];
                txtSPass.Text = fillS[4];
                txtSDatabase.Text = fillS[5];
                checkBoxRemember.Checked = true;
            }
            if (fillS[1] == "True")
            {
                checkBoxAutoConnect.Checked = true;
                this.btnconnect_Click(this, new EventArgs());
            }

            string[] fillL = Settings.load("StoredAccount", 3);
            if (fillL[0] == "True")
            {
                txtLUser.Text = fillL[1];
                txtLPass.Text = fillL[2];
                ckbLRemember.Checked = true;
            }
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
                txtLUser.Text = txtLUser.Text.Trim();
                //elegxos gia kena pedia
                if (string.IsNullOrEmpty(txtLUser.Text) || string.IsNullOrEmpty(txtLPass.Text))
                {
                    Utilities.notifyThem(ntfBox1, "Empty username or password!", NotificationBox.Type.Warning);
                }
                else
                {
                    Utilities.runInThread(() => {

                        DB TempLogUser = Utilities.AsyncDB();
                        TempLogUser.bind(new string[] { "user", txtLUser.Text, "pass", txtLPass.Text });
                        DataTable dt = TempLogUser.query("select * from users where user = @user and pass = @pass");
                        if (dt.Rows.Count == 1)
                        {
                            if(ckbLRemember.Checked)
                            {
                                Settings.save("StoredAccount", ckbLRemember.Checked.ToString(), txtLUser.Text, txtLPass.Text);
                            }
                            else
                            {
                                Settings.delete("StoredAccount");
                            }

                            //Load Tags
                            Functionality.LoadTags();

                            int id = int.Parse(dt.Rows[0][0].ToString());
                            string user = dt.Rows[0][1].ToString();
                            string pass = dt.Rows[0][2].ToString();
                            string mail = dt.Rows[0][3].ToString();
                            string scode = dt.Rows[0][4].ToString();
                            Globals.logUser = new User(id, user, pass, mail, scode);

                            Utilities.InvokeMe(Globals.formStart, ()=>
                            {
                                Globals.formStart.Hide();
                                Globals.formMain.Show();
                            });
                        }
                        else
                        {
                            Utilities.notifyThem(ntfBox1, "Wrong username or pass", NotificationBox.Type.Error);
                        }

                    }).Start();
                }
            }
            else
            {
                Utilities.notifyThem(ntfBox1, "Not connected to DB!", NotificationBox.Type.Warning);
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            Utilities.runInThread(() => {
                Globals.ConnectionStr(txtSHost.Text, txtSUser.Text, txtSPass.Text, txtSDatabase.Text);
                if (Utilities.AsyncDB().Connected())
                {
                    Globals.Connected = true;                   
                }
                if (Globals.Connected)
                {
                    if (checkBoxRemember.Checked)
                    {
                        Settings.save("StoredSettings", checkBoxRemember.Checked.ToString(), checkBoxAutoConnect.Checked.ToString(), txtSHost.Text, txtSUser.Text, txtSPass.Text, txtSDatabase.Text);
                    }
                    else
                    {
                        Settings.delete("StoredSettings");
                    }
                    Utilities.InvokeMe(btnconnect,()=>
                    {
                        btnconnect.Text = "Reconnect";
                    });
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
                if (txtRUser.Text == "" || txtRPass.Text == "" || txtRrepeatPass.Text == "" || txtREmail.Text == "")
                {
                    Utilities.notifyThem(ntfBox2, "All fields are necessary.", NotificationBox.Type.Warning);
                }else if (txtRPass.Text != txtRrepeatPass.Text)
                {
                    Utilities.notifyThem(ntfBox2, "Passwords don't match.", NotificationBox.Type.Warning);
                }else if (!Validation.IsValidEmail(txtREmail.Text))
                {
                    Utilities.notifyThem(ntfBox2, "Email is not valid.", NotificationBox.Type.Warning);
                }else
                {
                    Utilities.runInThread(() =>
                    {
                        DB tDB = Utilities.AsyncDB();
                        tDB.bind(new string[] { "usern", txtRUser.Text, "pass1", txtRPass.Text , "email1", txtREmail.Text });
                        
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

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabforgot.Tag = "";
            tabMain.SelectTab(6);
        }

        private void tabforgot_Leave(object sender, EventArgs e)
        {
            tabforgot.Tag = "hide";
            txtPassCode.Text = "";
            txtPassPassword.Text = "";
            txtPassCode.Text = "";
            ntfForgot.Hide();
        }

        private void txtLUser_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtLUser);
        }

        private void txtRUser_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtRUser);
        }

        private void txtREmail_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtREmail);
        }

        private void txtRSecurityCode_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtRSecurityCode);
        }

        private void txtPassUser_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtPassUser);
        }

        private void txtPassCode_TextChanged(object sender, EventArgs e)
        {
            Utilities.txtCustomReplaceSpace(txtPassCode);
        }
    }
}
