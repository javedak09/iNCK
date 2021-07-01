using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

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

        private void cmdDownloadUsers_Click(object sender, EventArgs e)
        {
            cmdDownloadUsers.Text = "Please wait Downloading Data";

            downloadDictionary();

            cmdDownloadUsers.Text = "Download Data";
        }



        private void downloadDictionary()
        {
            try
            {
                //var request = (HttpWebRequest)WebRequest.CreateHttp("https://vcoe1.aku.edu/naunehal/api/getData.php");
                var request = (HttpWebRequest)WebRequest.CreateHttp(CVariables.getTestingURL + CVariables.getDataFileName);


                //string param_json = "{\"table\":\"camp\", \"check\":\"1\", \"locked\":\"0\", \"status\":\"e\", \"cdate\":\"03-04-2021\" }";


                //var postData = "table=" + Uri.EscapeDataString("camp");
                //postData += "&check=" + Uri.EscapeDataString("1");
                //postData += "&locked=" + Uri.EscapeDataString("0");
                //postData += "&status=" + Uri.EscapeDataString("e");
                //postData += "&cdate=" + Uri.EscapeDataString("03-04-2021");



                //var data = Encoding.ASCII.GetBytes(postData);



                int winBuild = Environment.OSVersion.Version.Build;
                String userAgent = "NET/5.0 (Windows; Build/" + winBuild + ")";


                //request.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";


                request.UserAgent = userAgent;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                //request.ContentLength = data.Length;

                //using (var stream = request.GetRequestStream())
                //{
                //    stream.Write(data, 0, data.Length);
                //}




                //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                //{
                //    string json = new JavaScriptSerializer().Serialize(new
                //    {
                //        table = "camps",
                //        filter = " camp_status = 'Conducted' AND execution_date <= '2021-04-13' AND dist_id='" + ddlDistrict.SelectedValue.ToString() + "'"

                //    });

                //    streamWriter.Write(json);
                //}



                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        table = "tblDict",
                        check = "",
                        orderby = " var_seq asc "

                    });

                    streamWriter.Write(json);
                }


                var response = (HttpWebResponse)request.GetResponse();


                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();




                var obj = JsonConvert.DeserializeObject<List<Model_Dictionary>>(responseString);


                CConnection cn = new CConnection();

                SQLiteDataAdapter da = null;
                DataSet ds = null;


                da = new SQLiteDataAdapter("delete from tbldict", cn.cn);
                ds = new DataSet();
                da.Fill(ds);


                string qry = "";


                for (int a = 0; a <= obj.Count - 1; a++)
                {

                    qry = "insert into tbldict (DictID, tabname, var_id, var_seq, field_desc_en, field_desc, MinValue, MaxValue, value1, value2, value3, value4, value5, msg, IsOthers, Others_Value, " +
                        " No_Options, Isblank, TabPageNo, func_name, " +
                        " IncludeInDual, IsAudit) " +
                        "values('" +
                        obj[a].DictID + "', '" +
                        obj[a].tabname + "', '" +
                        obj[a].var_id + "', '" +
                        obj[a].var_seq + "', '" +
                        obj[a].field_desc_en + "', '" +
                        obj[a].field_desc + "', '" +
                        obj[a].MinValue + "', '" +
                        obj[a].MaxValue + "', '" +
                        obj[a].value1 + "', '" +
                        obj[a].value2 + "', '" +
                        obj[a].value3 + "', '" +
                        obj[a].value4 + "', '" +
                        obj[a].value5 + "', '" +
                        obj[a].msg + "', '" +
                        obj[a].IsOthers + "', '" +
                        obj[a].Others_Value + "', '" +
                        obj[a].No_Options + "', '" +
                        obj[a].Isblank + "', '" +
                        obj[a].TabPageNo + "', '" +
                        obj[a].func_name + "', '" +
                        obj[a].IncludeInDual + "', '" +
                        obj[a].IsAudit + "')";

                    da = new SQLiteDataAdapter(qry, cn.cn);
                    ds = new DataSet();
                    da.Fill(ds);

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
        }



        class Model_Dictionary
        {
            public string DictID { get; set; }
            public string tabname { get; set; }
            public string var_id { get; set; }
            public string var_seq { get; set; }
            public string field_desc_en { get; set; }
            public string field_desc { get; set; }
            public string MinValue { get; set; }
            public string MaxValue { get; set; }
            public string value1 { get; set; }
            public string value2 { get; set; }
            public string value3 { get; set; }
            public string value4 { get; set; }
            public string value5 { get; set; }
            public string msg { get; set; }
            public string IsOthers { get; set; }
            public string Others_Value { get; set; }
            public string No_Options { get; set; }
            public string Isblank { get; set; }
            public string TabPageNo { get; set; }
            public string func_name { get; set; }
            public string IncludeInDual { get; set; }
            public string IsAudit { get; set; }
        }


    }
}
