using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

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
            CDBOperations obj_op = null;
            bool IsLogin = false;

            try
            {

                if (rdoUser1.Checked == false && rdoUser2.Checked == false)
                {
                    MessageBox.Show("Please select User1 or User2", "User Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    string[] fldname = { "UserID", "Passwd" };
                    string[] fldvalue = { txtUserID.Text, txtPassword.Text };

                    obj_op = new CDBOperations();
                    DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Login");

                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            CVariables.UserID = ds.Tables[0].Rows[0][0].ToString();
                            CVariables.UserName = ds.Tables[0].Rows[0][1].ToString();
                            CVariables.GetPassword = ds.Tables[0].Rows[0]["Passwd"].ToString();
                            CVariables.GetDBName = "kap";
                            CVariables.PilotPhaseEntry = true;

                            if (ds.Tables[0].Rows[0]["IsUserOrAdmin"].ToString() == "True")
                            {
                                CVariables.IsAdmin = true;
                            }
                            else
                            {
                                CVariables.IsAdmin = false;
                            }



                            if (rdoUser1.Checked == true)
                            {
                                CVariables.IsUserFirstOrSecond = "User1";
                            }
                            else if (rdoUser2.Checked == true)
                            {
                                CVariables.IsUserFirstOrSecond = "User2";
                            }

                            IsLogin = true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid userid or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            CVariables.UserID = "";
                            CVariables.UserName = "";
                            txtUserID.Focus();
                        }
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
                obj_op = null;
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
