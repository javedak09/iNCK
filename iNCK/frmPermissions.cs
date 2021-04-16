using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iNCK
{
    public partial class frmPermissions : Form
    {
        static string var_user_id;
        static bool IsUpdate;
        static bool IsUpdatePermission;
        static string var_perm_id;


        public frmPermissions()
        {
            InitializeComponent();
        }

        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == "")
                {
                    MessageBox.Show("User ID required field", "User ID Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Focus();
                }
                else if (txtPasswd.Text == "")
                {
                    MessageBox.Show("Password required field", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswd.Focus();
                }
                else if (txtPasswd.Text != txtConfirmPasswd.Text)
                {
                    MessageBox.Show("Password and confirm password are not same ", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswd.Focus();
                }
                else if (txtAkuID.Text == "")
                {
                    MessageBox.Show("Aku ID cannot be left blank ", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAkuID.Focus();
                }
                else if (txtEmpNo.Text == "")
                {
                    MessageBox.Show("Emp No cannot be left blank ", "AKU ID Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpNo.Focus();
                }
                else
                {
                    if (IsUpdate == true)
                    {
                        if (cboLocation.SelectedValue.ToString() == "0")
                        {
                            MessageBox.Show("Please select location ", "Location not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cboLocation.Focus();
                        }
                        else
                        {
                            if (cboStatus.SelectedValue.ToString() == "0")
                            {
                                MessageBox.Show("Please select status ", "Status not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboStatus.Focus();
                            }
                            else
                            {
                                UpdateRecord();
                                GetUser();
                                ClearFields();
                                IsUpdate = false;
                            }
                        }
                    }
                    else
                    {
                        if (IsUserExists() == true)
                        {
                            MessageBox.Show("User already exists", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUserID.Focus();
                        }
                        else
                        {
                            if (cboLocation.SelectedValue.ToString() == "0")
                            {
                                MessageBox.Show("Please select location ", "Location not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cboLocation.Focus();
                            }
                            else
                            {
                                if (cboStatus.SelectedValue.ToString() == "0")
                                {
                                    MessageBox.Show("Please select status ", "Status not selected ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cboStatus.Focus();
                                }
                                else
                                {
                                    AddUser();
                                    GetUser();
                                    ClearFields();
                                }
                            }
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

            }
        }

        private bool IsUserExists()
        {
            CDBOperations obj_op = null;
            bool IsLogin = false;

            try
            {
                string[] fldname = { "UserID", "Passwd" };
                string[] fldvalue = { txtUserID.Text, txtPasswd.Text };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Login");

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        IsLogin = true;
                    }
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                obj_op = null;
            }

            return IsLogin;
        }

        private void AddUser()
        {
            CDBOperations obj_op = null;
            DataSet ds = null;

            try
            {
                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                ds = new DataSet();
                obj_op = new CDBOperations();


                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", txtUserID.Text, txtPasswd.Text, cboStatus.SelectedValue.ToString(), "0", "0", cboLocation.SelectedValue.ToString(), txtAkuID.Text, txtEmpNo.Text, EntryDate.ToShortDateString() };

                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");


                if (ds.Tables.Count > 0)
                {
                    DGUser.DataSource = ds.Tables[0];
                }

                IsUpdate = false;
                var_user_id = "";
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
            }

            finally
            {
                obj_op = null;
                ds = null;
            }
        }

        private void UpdateRecord()
        {
            CDBOperations obj_op = null;
            DataSet ds = null;

            try
            {
                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                ds = new DataSet();
                obj_op = new CDBOperations();

                if (var_user_id != "")
                {
                    if (cboStatus.SelectedValue.ToString() == "3")
                    {
                        string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                        string[] fldvalue = { var_user_id, txtUserID.Text, txtPasswd.Text, "False", "", "1", cboLocation.SelectedValue.ToString(), txtAkuID.Text, txtEmpNo.Text, EntryDate.ToShortDateString() };

                        ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");
                    }
                    else
                    {
                        string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                        string[] fldvalue = { var_user_id, txtUserID.Text, txtPasswd.Text, "True", "", "1", cboLocation.SelectedValue.ToString(), txtAkuID.Text, txtEmpNo.Text, EntryDate.ToShortDateString() };

                        ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");
                    }
                }
                else
                {
                    MessageBox.Show("Please select any record from User Management Grid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (ds.Tables.Count > 0)
                {
                    DGUser.DataSource = ds.Tables[0];
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmdAddUser.Text = "Add User";
            }
        }


        private void ClearFields()
        {
            txtUserID.Text = "";
            txtPasswd.Text = "";
            txtConfirmPasswd.Text = "";
            cboStatus.SelectedValue = 1;
            cboLocation.SelectedValue = 1;
            txtAkuID.Text = "";
            txtEmpNo.Text = "";
            txtUserID.Focus();
        }


        private void cmdDeleteUser_Click(object sender, EventArgs e)
        {
            CDBOperations obj_op = null;

            try
            {
                obj_op = new CDBOperations();

                if (var_user_id != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to delete user ? Deletion of a user will also delete the permissions ", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.ToString() == "Yes")
                    {
                        string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                        string[] fldvalue = { var_user_id, "", "", "", "", "2", "", "", "", "" };

                        obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                        cmdAddUser.Text = "Add User";

                        GetUsersData();
                        GetUser();
                    }
                }
                else
                {
                    MessageBox.Show("Please select record from the grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                IsUpdate = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                ClearFields();
                obj_op = null;
            }
        }

        private void frmPermissions_Load(object sender, EventArgs e)
        {
            GetUsersData();
            GetUser();
            GetForms();
            GetPermissions();
            GetPermissionData(2);
            GetLocation();
            GetStatus();
        }

        private void frmPermissions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void DGUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IsUpdate = true;

            cmdAddUser.Text = "Update User";

            var_user_id = DGUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserID.Text = DGUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPasswd.Text = DGUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtConfirmPasswd.Text = DGUser.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (DGUser.Rows[e.RowIndex].Cells[3].Value.ToString() == "False")
            {
                cboStatus.SelectedValue = 3;
            }
            else
            {
                cboStatus.SelectedValue = 2;
            }

            if (DGUser.Rows[e.RowIndex].Cells[5].Value.ToString() == "2")
            {
                cboLocation.SelectedValue = 2;
            }
            else
            {
                cboLocation.SelectedValue = 3;
            }


            txtAkuID.Text = DGUser.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmpNo.Text = DGUser.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void cmdCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsUpdate = true;

            cmdAddUser.Text = "Update User";

            var_user_id = DGUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserID.Text = DGUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPasswd.Text = DGUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtConfirmPasswd.Text = DGUser.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (DGUser.Rows[e.RowIndex].Cells[3].Value.ToString() == "False")
            {
                cboStatus.SelectedValue = 3;
            }
            else
            {
                cboStatus.SelectedValue = 2;
            }


            if (DGUser.Rows[e.RowIndex].Cells[5].Value.ToString() == "2")
            {
                cboLocation.SelectedValue = 2;
            }
            else
            {
                cboLocation.SelectedValue = 3;
            }

            txtAkuID.Text = DGUser.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmpNo.Text = DGUser.Rows[e.RowIndex].Cells[7].Value.ToString();
        }


        private void GetUsersData()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "", "", "3", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                if (ds.Tables.Count > 0)
                {
                    DGUser.DataSource = ds.Tables[0];

                    DGUser.Columns[0].Visible = false;
                    DGUser.Columns[0].ReadOnly = true;
                    DGUser.Columns[1].ReadOnly = true;
                    DGUser.Columns[2].ReadOnly = true;
                    DGUser.Columns[3].ReadOnly = true;
                    DGUser.Columns[4].ReadOnly = true;
                    DGUser.Columns[5].ReadOnly = true;
                }

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }

        private void GetUser()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "1", "", "3", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                cboUser.DisplayMember = ds.Tables[0].Columns[1].ToString();
                cboUser.ValueMember = ds.Tables[0].Columns[0].ToString();
                cboUser.DataSource = ds.Tables[0];

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }


        private void GetLocation()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "1", "", "6", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                cboLocation.DisplayMember = ds.Tables[0].Columns[1].ToString();
                cboLocation.ValueMember = ds.Tables[0].Columns[0].ToString();
                cboLocation.DataSource = ds.Tables[0];

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }


        private void GetStatus()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "1", "", "7", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                cboStatus.DisplayMember = ds.Tables[0].Columns[1].ToString();
                cboStatus.ValueMember = ds.Tables[0].Columns[0].ToString();
                cboStatus.DataSource = ds.Tables[0];

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }


        private void GetForms()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "1", "", "4", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                cboForms.DisplayMember = ds.Tables[0].Columns[1].ToString();
                cboForms.ValueMember = ds.Tables[0].Columns[0].ToString();
                cboForms.DataSource = ds.Tables[0];

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }

        private void cmdGrantPermission_Click(object sender, EventArgs e)
        {
            if (IsUpdatePermission == true)
            {
                ChangePermissions();
            }
            else
            {
                if (IsPermissionExists() == false)
                {
                    GrantPermissions();
                }
                else
                {
                    MessageBox.Show("Permission already exists for this user", "Permission Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void GrantPermissions()
        {
            CDBOperations obj_op = null;
            DataSet ds = null;

            try
            {

                ds = new DataSet();
                obj_op = new CDBOperations();

                if (cboUser.SelectedValue == "" || cboUser.SelectedValue == null)
                {
                    MessageBox.Show("Please select users ", "User Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cboForms.SelectedValue == "" || cboForms.SelectedValue == null)
                {
                    MessageBox.Show("Please select forms ", "Form Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cboPermissions.SelectedValue == "" || cboPermissions.SelectedValue == null)
                {
                    MessageBox.Show("Please select permissions ", "Permission Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] fldname = { "@ID", "@UserID", "@FormID", "@Permission", "@fldvalue" };
                    string[] fldvalue = { "0", cboUser.SelectedValue.ToString(), cboForms.SelectedValue.ToString(), cboPermissions.SelectedValue.ToString(), "0" };

                    ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Permissions");

                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            DGPermissions.DataSource = ds.Tables[0];

                            DGPermissions.Columns[0].Visible = false;
                            DGPermissions.Columns[1].ReadOnly = true;
                            DGPermissions.Columns[2].ReadOnly = true;
                            DGPermissions.Columns[3].ReadOnly = true;
                        }
                    }
                }

                GetPermissionData(2);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Focus();
            }

            finally
            {
                obj_op = null;
                ds = null;
            }
        }

        private void ChangePermissions()
        {
            CDBOperations obj_op = null;
            DataSet ds = null;

            try
            {

                if (var_perm_id != "")
                {

                    ds = new DataSet();
                    obj_op = new CDBOperations();

                    if (cboUser.SelectedValue == "" || cboUser.SelectedValue == null)
                    {
                        MessageBox.Show("Please select users ", "User Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cboForms.SelectedValue == "" || cboForms.SelectedValue == null)
                    {
                        MessageBox.Show("Please select forms ", "Form Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cboPermissions.SelectedValue == "" || cboPermissions.SelectedValue == null)
                    {
                        MessageBox.Show("Please select permissions ", "Permission Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string[] fldname = { "@ID", "@UserID", "@FormID", "@Permission", "@fldvalue" };
                        string[] fldvalue = { "0", cboUser.SelectedValue.ToString(), cboForms.SelectedValue.ToString(), cboPermissions.SelectedValue.ToString(), "1" };

                        ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Permissions");

                        cmdGrantPermission.Text = "Grant Permission";


                        if (ds.Tables.Count > 0)
                        {
                            DGPermissions.DataSource = ds.Tables[0];

                            DGPermissions.Columns[0].Visible = false;
                            DGPermissions.Columns[1].ReadOnly = true;
                            DGPermissions.Columns[2].ReadOnly = true;
                            DGPermissions.Columns[3].ReadOnly = true;
                        }

                        IsUpdatePermission = false;
                        var_perm_id = "";
                    }

                    GetPermissionData(2);
                }
                else
                {
                    MessageBox.Show("Please select a record from the grid ", "Update Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ds = null;
            }
        }

        private void GetPermissions()
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "ID", "UserID", "Passwd", "UserStatus", "IsUserOrAdmin", "fldvalue", "LocationID", "AkuID", "EmpNo", "CreationDate" };
                string[] fldvalue = { "0", "", "", "1", "", "5", "", "", "", "" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_UserManagement");

                cboPermissions.DisplayMember = ds.Tables[0].Columns[1].ToString();
                cboPermissions.ValueMember = ds.Tables[0].Columns[0].ToString();
                cboPermissions.DataSource = ds.Tables[0];

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }


        private void GetPermissionData(int id)
        {
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "@ID", "@UserID", "@FormID", "@Permission", "@fldvalue" };
                string[] fldvalue = { "0", "", "", "1", id.ToString() };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Permissions");

                if (ds.Tables.Count > 0)
                {
                    DGPermissions.DataSource = ds.Tables[0];

                    DGPermissions.Columns[0].Visible = false;
                    DGPermissions.Columns[1].ReadOnly = true;
                    DGPermissions.Columns[2].ReadOnly = true;
                    DGPermissions.Columns[3].ReadOnly = true;
                }

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }
        }

        private void DGPermissions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsUpdatePermission = true;

            cmdGrantPermission.Text = "Change Permission";


            var_perm_id = DGPermissions.Rows[e.RowIndex].Cells[0].Value.ToString();

            for (int a = 0; a <= cboUser.Items.Count - 1; a++)
            {
                if (cboUser.SelectedItem == DGPermissions.Rows[e.RowIndex].Cells[1].Value.ToString())
                {
                    cboStatus.SelectedIndex = a;
                }
            }


            for (int a = 0; a <= cboForms.Items.Count - 1; a++)
            {
                if (cboForms.Items[a] == DGPermissions.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    cboForms.SelectedIndex = a;
                }
            }


            for (int a = 0; a <= cboPermissions.Items.Count - 1; a++)
            {
                if (cboPermissions.Items[a] == DGPermissions.Rows[e.RowIndex].Cells[3].Value.ToString())
                {
                    cboPermissions.SelectedIndex = a;
                }
            }
        }

        private void RevokePermissions_Click(object sender, EventArgs e)
        {
            CDBOperations obj_op = null;

            try
            {
                if (var_perm_id != "")
                {

                    obj_op = new CDBOperations();

                    DialogResult = MessageBox.Show("Are you sure you want to revoke the permission ? ", "Reveoke Permissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.ToString() == "Yes")
                    {
                        string[] fldname = { "ID", "UserID", "FormID", "Permission", "fldvalue" };
                        string[] fldvalue = { var_perm_id, "", "", "", "3" };

                        obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Permissions");

                        cmdGrantPermission.Text = "Grant Permission";

                        GetPermissionData(2);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record from the grid ", "Delete Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                ClearFields();
                obj_op = null;
            }
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPermissionData(5);
        }

        private void cboForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPermissionData(6);
        }


        private bool IsPermissionExists()
        {
            bool IsExists = false;
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "@ID", "@UserID", "@FormID", "@Permission", "@fldvalue" };
                string[] fldvalue = { "0", cboUser.SelectedValue.ToString(), cboForms.SelectedValue.ToString(), cboPermissions.SelectedValue.ToString(), "7" };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_Permissions");

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            IsExists = true;
                        }
                    }
                }

                ds = null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return IsExists;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }        
    }
}
