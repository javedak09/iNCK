using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guifreaks.NavigationBar;
using System.Xml;
using Microsoft.Xml.Serialization.GeneratedAssembly;
using System.IO;


namespace iNCK
{
    public partial class frmMain : Form
    {
        private static string mynode = "";


        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            //CDBOperations obj_op = null;
            //DataSet ds = null;

            try
            {
                this.Text = CVariables.AppName1;
                toolStripStatusLabel1.Text = "          " + DateTime.Now.ToLongDateString();
                toolStripStatusLabel2.Text = "                    " + DateTime.Now.ToShortTimeString() + "                                        ";

                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    toolStripStatusLabel3.Text = "         Logged in as:   " + CVariables.UserName.ToUpper() + "  -  (User 1) ";
                }
                else if (CVariables.IsUserFirstOrSecond == "User2")
                {
                    toolStripStatusLabel3.Text = "         Logged in as:   " + CVariables.UserName.ToUpper() + "  -  (User 2) ";
                }
                //timer1.Enabled = true;


                treeView1.Nodes[0].ExpandAll();

                naviBar1.ActiveBand = naviBand6;


                if (CVariables.IsAdmin == true)
                {
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                    entryStatusToolStripMenuItem.Visible = true;


                    //obj_op = new CDBOperations();
                    //ds = obj_op.GetFormData_VisitID("sp_GetRecords", "0", "", "");

                    //NaviBand band = null;

                    //for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                    //{
                    //    band = new NaviBand();

                    //    band.Name = ds.Tables[0].Rows[a]["ID"].ToString();
                    //    band.Text = ds.Tables[0].Rows[a]["BandText"].ToString();
                    //    band.SmallImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\images\\" + ds.Tables[0].Rows[a]["BandSmallImage"].ToString());
                    //    band.LargeImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\images\\" + ds.Tables[0].Rows[a]["BandLargeImage"].ToString());

                    //    naviBar1.LayoutStyle = NaviLayoutStyle.Office2007Silver;

                    //    naviBar1.Bands.Add(band);
                    //}

                    //naviBar1.ShowMoreOptionsButton = false;

                    //naviBar1.VisibleLargeButtons = ds.Tables[0].Rows.Count;

                    //naviBar1.ActiveBand = naviBar1.Bands[0];



                }
                else
                {
                    if (CVariables.IsAdmin == false)
                    {
                        if (CVariables.IsUserFirstOrSecond == "User1")
                        {
                            menuStrip1.Items[1].Visible = false;
                            menuStrip1.Items[2].Visible = false;
                            entryStatusToolStripMenuItem.Visible = false;
                        }
                        else if (CVariables.IsUserFirstOrSecond == "User2")
                        {
                            menuStrip1.Items[1].Visible = false;
                            menuStrip1.Items[2].Visible = false;
                            entryStatusToolStripMenuItem.Visible = false;
                        }

                    }
                    else if (CVariables.IsAdmin == false)
                    {

                    }
                    else
                    {
                        menuStrip1.Items[1].Visible = false;
                        menuStrip1.Items[2].Visible = false;
                        entryStatusToolStripMenuItem.Visible = true;
                    }

                }


            }


            catch (Exception ex)
            {

            }

            finally
            {
                //obj_op = null;
                //ds = null;
            }
        }


        private void user1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            //timer2.Enabled = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            CVariables.frmlogin1.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermissions frm = new frmPermissions();
            CVariables.frm1 = this;
            frm.MdiParent = this;
            frm.Top = 0;
            frm.Left = 0;
            frm.Show();
        }

        private void user1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void errorCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DialogResult result = MessageBox.Show("Are you sure you want to run data error on all the forms ? ", "Run Data Error Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.ToString() == "Yes")
            {
                CDBOperations obj_op = new CDBOperations();

                //    delete records from tblErrors for new Entries               

                string[] fldname2 = { "iPOPID", "FormName", "FieldName", "FieldDescription", "ErrorDescription", "Archive", "fldvalue" };
                string[] fldvalue2 = { "0", "", "", "", "Missing", "0", "0" };
                obj_op.ExecuteNonQuery(fldname2, fldvalue2, "sp_Create_Error");


                //    end  delete records from tblErrors for new Entries


                obj_op.DataErrorCheck("Form1", "sp_DeleteForm", "IPOPFRM1_IPOPID", "13");
                obj_op.DataErrorCheck("Form2", "sp_DeleteForm", "IPOPFRM2_IPOPID", "14");
                obj_op.DataErrorCheck("Form3", "sp_DeleteForm", "IPOPFRM3_IPOPID", "15");
                obj_op.DataErrorCheck("Form4", "sp_DeleteForm", "IPOPFRM4_IPOPID", "16");
                obj_op.DataErrorCheck("Form5", "sp_DeleteForm", "IPOPFRM5_IPOPID", "17");
                obj_op = null;

                MessageBox.Show("Data error checking finished ", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }

        private void entryStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEntryStatus frm = new frmEntryStatus();
            //CVariables.frm1 = this;
            //frm.MdiParent = this;
            //frm.Top = 0;
            //frm.Left = 0;
            //frm.Show();
        }

        private void user1ToolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }


        private void dualEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDualEntry frm = new frmDualEntry();
            //CVariables.frm1 = this;
            //frm.MdiParent = this;
            //frm.Top = 0;
            //frm.Left = 0;
            //frm.Show();
        }

        private void user1ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void user1ToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {

        }

        private void user2ToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {

        }

        private void createCodeListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCreateDictionary frm = new frmCreateDictionary();
            //CVariables.frm1 = this;
            //frm.MdiParent = this;
            //frm.Top = 0;
            //frm.Left = 0;
            //frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            CVariables.frmlogin1.Show();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            //frmCreateDictionary frm = new frmCreateDictionary();
            //CVariables.frm1 = this;
            //frm.MdiParent = this;
            //frm.Top = 0;
            //frm.Left = 0;
            //frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmDualEntry frm = new frmDualEntry();
            //CVariables.frm1 = this;
            //frm.MdiParent = this;
            //frm.Top = 0;
            //frm.Left = 0;
            //frm.Show();
        }



        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Name == "Baseline Form")
                {
                    //Form1BL frm = new Form1BL();
                    
                    Form1BL_v31 frm = new Form1BL_v31();
                    OpenForm(frm);
                    frm = null;
                    naviBar1.Collapsed = true;
                }
                //else if (e.Node.Name == "IFU3")
                //{
                //    IFU frm = new IFU();
                //    OpenForm(frm);
                //    frm = null;
                //}
                //else if (e.Node.Name == "IFR")
                //{
                //    IFR frm = new IFR();
                //    OpenForm(frm);
                //    frm = null;
                //}
                //else if (e.Node.Name == "Lab")
                //{
                //    Lab frm = new Lab();
                //    OpenForm(frm);
                //    frm = null;
                //}

                ClearBackColor();


                //TreeNode[] tn = treeView1.Nodes[0].Nodes.Find(txtNodeSearch.Text, true);

                for (int i = 0; i < treeView1.Nodes[0].Nodes.Count - 1; i++)
                {
                    treeView1.SelectedNode = treeView1.Nodes[i];
                    treeView1.SelectedNode.BackColor = Color.White;
                }

            }

            catch (Exception ex)
            {

            }
        }



        private void OpenForm(Form frm)
        {
            bool IsFormOpen = false;

            if (this.MdiChildren.Length == 0)
            {
                CVariables.frm1 = this;
                frm.MdiParent = this;
                frm.Top = 0;
                frm.Left = 0;
                frm.Show();
            }
            else
            {

                for (int a = 0; a <= MdiChildren.Length - 1; a++)
                {
                    IsFormOpen = true;
                }


                if (!IsFormOpen)
                {
                    CVariables.frm1 = this;
                    frm.MdiParent = this;
                    frm.Top = 0;
                    frm.Left = 0;
                    frm.Show();
                }
            }
        }



        private void naviBand1_Click(object sender, EventArgs e)
        {
            if (CVariables.IsAdmin == true)
            {
                frmCreateDictionary frm = new frmCreateDictionary();
                CVariables.frm1 = this;
                frm.MdiParent = this;
                frm.Top = 0;
                frm.Left = 0;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to view this form ");
            }
        }


        private void naviBand3_Click(object sender, EventArgs e)
        {
            if (CVariables.IsAdmin == true)
            {

            }
            else
            {
                MessageBox.Show("You do not have permission to view this form ");
            }
        }

        private void naviBand4_Click(object sender, EventArgs e)
        {
            if (CVariables.IsAdmin == true)
            {
                frmPermissions frm = new frmPermissions();
                CVariables.frm1 = this;
                frm.MdiParent = this;
                frm.Top = 0;
                frm.Left = 0;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to view this form ");
            }
        }

        private void naviBand2_Click(object sender, EventArgs e)
        {
            if (CVariables.IsAdmin == true)
            {

            }
            else
            {
                MessageBox.Show("You do not have permission to view this form ");
            }
        }

        private void naviBand5_Click(object sender, EventArgs e)
        {
            if (CVariables.IsAdmin == true)
            {
                //frmDualEntry frm = new frmDualEntry();
                //CVariables.frm1 = this;
                //frm.MdiParent = this;
                //frm.Top = 0;
                //frm.Left = 0;
                //frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to view this form ");
            }
        }

        private void naviBand6_Click(object sender, EventArgs e)
        {

        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CVariables.IsAdmin == true)
            {
                //frmExport frm = new frmExport();
                //CVariables.frm1 = this;
                //frm.MdiParent = this;
                //frm.Top = 0;
                //frm.Left = 0;
                //frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to view this form ");
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            ClearBackColor();
        }



        private void ClearBackColor()
        {
            TreeNodeCollection nodes = treeView1.Nodes;

            foreach (TreeNode n in nodes)
            {
                ClearRecursive(n);
            }
        }

        private void ClearRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.BackColor = Color.White;
                ClearRecursive(tn);
            }
        }

        private void auditTrialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAudit frm = new frmAudit();
            //CVariables.frm1 = this;
            //frm.MdiParent = this;
            //frm.Top = 0;
            //frm.Left = 0;
            //frm.Show();
        }

        private void dataCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDataCheck_Dict frm = new frmDataCheck_Dict();
            //CVariables.frm1 = this;
            //frm.MdiParent = this;
            //frm.Top = 0;
            //frm.Left = 0;
            //frm.Show();
        }



    }
}
