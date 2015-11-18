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
            string[] fill=Utilities.loadSettings("StoredSettings",6);
            if (fill[0] == "True") { 
                txthost.Text = fill[2];
                txtuname.Text = fill[3];
                txtpasswd.Text = fill[4];
                txtDatabase.Text = fill[5];
                checkBoxRemember.Checked = true;
            }
            if (fill[1] == "True")
            {
                checkBoxAutoConnect.Checked = true;
                this.btnconnect_Click(this, new EventArgs());
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
            
            /*
            //MIN TA SBISEI KANEIS EINAI GIA NA KANO MERIKA TEST NESTORAS

            List<Question> Mytest = new List<Question>();
            List<Answer> Yo = new List<Answer>();
            Yo.Clear();
            Yo.Add(new Answer("aaaaa",false));
            Yo.Add(new Answer("bbbb", true));
            Mytest.Add(new Question(1, "What?", Yo, false));
            Yo.Clear();
            Yo.Add(new Answer("cccc", false));
            Yo.Add(new Answer("dddd", true));
            Mytest.Add(new Question(2, "wut wut?", Yo, false));

            Utilities.printPDF("Allilepidrasi","14-11-2015",Mytest,false);
            */

            if (Globals.Connected)
            {
                txtUser.Text = txtUser.Text.Trim();
                //elenxs gia to an einai kena ta pedia
                if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    Utilities.notifyThem(ntfBox1, "Empty username or password!", NotificationBox.Type.Warning);
                }
                else
                {
                    Utilities.runInThread(() => {
                        //Test Logged User                

                        DB TempLogUser = Utilities.AsyncDB();
                        TempLogUser.bind(new string[] { "user", txtUser.Text, "pass", txtPassword.Text });
                        DataTable dt = TempLogUser.query("select * from users where user = @user and pass = @pass");
                        if (dt.Rows.Count == 1)
                        {

                            //Load Tags
                            Functionality.LoadTags();

                            int id = int.Parse(dt.Rows[0][0].ToString());
                            string user = dt.Rows[0][1].ToString();
                            string pass = dt.Rows[0][2].ToString();
                            string mail = dt.Rows[0][3].ToString();
                            Globals.logUser = new User(id, user, pass, mail);

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
                Globals.ConnectionStr(txthost.Text, txtuname.Text, txtpasswd.Text, txtDatabase.Text);
                if (Utilities.AsyncDB().Connected())
                {
                    Globals.Connected = true;                   
                }
                if (Globals.Connected)
                {
                    if (checkBoxRemember.Checked)
                    {
                        Utilities.saveSettings("StoredSettings", checkBoxRemember.Checked.ToString(), checkBoxAutoConnect.Checked.ToString(), txthost.Text, txtuname.Text, txtpasswd.Text, txtDatabase.Text);
                    }
                    else
                    {
                        if (System.IO.File.Exists(Globals.FilesPath + "\\TestME\\StoredSettings"))
                        {
                            System.IO.File.Delete(Globals.FilesPath + "\\TestME\\StoredSettings");
                        }
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
