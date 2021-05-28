using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

namespace iNCK
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login() == true)
            {
                CVariables.frmlogin1 = this;
                this.Hide();

                frmMain obj_main = new frmMain();
                obj_main.Show();
            }
        }

        private bool Login()
        {
            bool IsLogin = false;

            try
            {

                if (rdoUser1.Checked == false && rdoUser2.Checked == false)
                {
                    MessageBox.Show("Please select User1 or User2", "User Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    CConnection cn = new CConnection();

                    SQLiteDataAdapter da = new SQLiteDataAdapter("select * from users where username='" + txtUserID.Text + "' and passwd='" + txtPassword.Text + "'", cn.cn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {

                                CVariables.UserID = ds.Tables[0].Rows[0]["id"].ToString();
                                CVariables.UserName = ds.Tables[0].Rows[0]["username"].ToString();
                                CVariables.GetPassword = ds.Tables[0].Rows[0]["passwd"].ToString();
                                //CVariables.GetDBName = "gbdata";

                                CVariables.IsUserFirstOrSecond = "User1";


                                CVariables.frmlogin1 = this;
                                this.Hide();

                                frmMain obj_main = new frmMain();
                                obj_main.Show();
                            }
                            else
                            {
                                MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtUserID.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUserID.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserID.Focus();
                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
            }

            finally
            {

            }

            return IsLogin;
        }


        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login Window - " + CVariables.AppName1;
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
