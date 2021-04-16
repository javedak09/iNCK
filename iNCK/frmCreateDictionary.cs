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
    public partial class frmCreateDictionary : Form
    {

        public frmCreateDictionary()
        {
            InitializeComponent();
        }

        private void frmCreateDictionary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void frmCreateDictionary_Load(object sender, EventArgs e)
        {
            GetTables();
        }

        private void GetTables()
        {
            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            try
            {
                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "0" };

                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");

                tabname.DisplayMember = ds.Tables[0].Columns["TABLE_NAME"].ColumnName;
                tabname.ValueMember = ds.Tables[0].Columns["TABLE_NAME"].ColumnName;
                tabname.DataSource = ds.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                ds = null;
            }
        }

        private void tabname_SelectedIndexChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            try
            {
                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { tabname.SelectedValue.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "1" };


                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");

                varid.DisplayMember = ds.Tables[0].Columns["COLUMN_NAME"].ColumnName;
                varid.ValueMember = ds.Tables[0].Columns["COLUMN_NAME"].ColumnName;
                varid.DataSource = ds.Tables[0];

                cmdSave.Visible = true;
                cmdDelete.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                ds = null;
            }
        }

        private void varid_SelectedIndexChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            try
            {

                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { tabname.SelectedValue.ToString(), "", varid.SelectedValue.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "2" };


                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            datatype.Enabled = true;
                            datatype.Text = ds.Tables[0].Rows[0]["data_type"].ToString();
                            datatype.Enabled = false;


                            //if (datatype.Text == "real" || datatype.Text == "REAL")
                            //{
                            //    label11.Visible = true;
                            //    integerpart.Visible = true;

                            //    label12.Visible = true;
                            //    realpart.Visible = true;
                            //}
                            //else
                            //{
                            //    label11.Visible = false;
                            //    integerpart.Visible = false;

                            //    label12.Visible = false;
                            //    realpart.Visible = false;
                            //}

                            cmdSave.Visible = true;
                            cmdDelete.Visible = true;
                        }
                    }
                }

                GetRecords();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                ds = null;
            }
        }



        private void GetRecords()
        {
            string[] arr_min;
            string[] arr_max;
            string[] arr_val1;
            string[] arr_val2;
            string[] arr_val3;
            string[] arr_val4;

            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            try
            {

                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { tabname.SelectedValue.ToString(), "", varid.SelectedValue.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "6" };


                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            varname.Text = ds.Tables[0].Rows[0]["var_name"].ToString();
                            varid.SelectedValue = ds.Tables[0].Rows[0]["var_id"].ToString();
                            varseq.Text = ds.Tables[0].Rows[0]["var_seq"].ToString();
                            fielddesc.Text = ds.Tables[0].Rows[0]["field_desc"].ToString();
                            remarks.Text = ds.Tables[0].Rows[0]["remarks"].ToString();
                            datatype.Text = ds.Tables[0].Rows[0]["data_type"].ToString();
                            //integerpart.Text = ds.Tables[0].Rows[0]["integerpart"].ToString();
                            //realpart.Text = ds.Tables[0].Rows[0]["realpart"].ToString();
                            fieldlen.Text = ds.Tables[0].Rows[0]["field_len"].ToString();
                            fielddecimal.Text = ds.Tables[0].Rows[0]["field_decimal"].ToString();

                            if (ds.Tables[0].Rows[0]["minvalue"].ToString().IndexOf(".") == -1)
                            {
                                minvalue.Text = ds.Tables[0].Rows[0]["minvalue"].ToString();
                                maxvalue.Text = ds.Tables[0].Rows[0]["maxvalue"].ToString();
                                value1.Text = ds.Tables[0].Rows[0]["value1"].ToString();
                                value2.Text = ds.Tables[0].Rows[0]["value2"].ToString();
                                value3.Text = ds.Tables[0].Rows[0]["value3"].ToString();
                                value4.Text = ds.Tables[0].Rows[0]["value4"].ToString();
                                value5.Text = ds.Tables[0].Rows[0]["value5"].ToString();

                                mychar.Text = "";

                                chkRealValue.Checked = false;
                            }
                            else
                            {

                                arr_min = ds.Tables[0].Rows[0]["minvalue"].ToString().Split('.');

                                if (arr_min[0] != "" && arr_min[1] != "")
                                {
                                    integerpart_min.Text = arr_min[0];
                                    realpart_min.Text = arr_min[1];
                                }



                                arr_max = ds.Tables[0].Rows[0]["maxvalue"].ToString().Split('.');

                                if (arr_max[0] != "" && arr_max[1] != "")
                                {
                                    integerpart_max.Text = arr_max[0];
                                    realpart_max.Text = arr_max[1];
                                }



                                arr_val1 = ds.Tables[0].Rows[0]["value1"].ToString().Split('.');

                                if (arr_val1[0] != "" && arr_val1[1] != "")
                                {
                                    integerpart1.Text = arr_val1[0];
                                    realpart1.Text = arr_val1[1];
                                }



                                arr_val2 = ds.Tables[0].Rows[0]["value2"].ToString().Split('.');

                                if (arr_val2[0] != "" && arr_val2[1] != "")
                                {
                                    integerpart2.Text = arr_val2[0];
                                    realpart2.Text = arr_val2[1];
                                }
                                



                                arr_val3 = ds.Tables[0].Rows[0]["value3"].ToString().Split('.');

                                if (arr_val3[0] != "" && arr_val3[1] != "")
                                {
                                    integerpart3.Text = arr_val3[0];
                                    realpart3.Text = arr_val3[1];
                                }
                                


                                arr_val4 = ds.Tables[0].Rows[0]["value4"].ToString().Split('.');

                                if (arr_val4[0] != "" && arr_val4[1] != "")
                                {
                                    integerpart4.Text = arr_val4[0];
                                    realpart4.Text = arr_val4[1];
                                }
                                


                                mychar.Text = ".";

                                //value5.Text = ds.Tables[0].Rows[0]["value5"].ToString();

                                chkRealValue.Checked = true;
                            }


                            taborder.Text = ds.Tables[0].Rows[0]["taborder"].ToString();
                            message.Text = ds.Tables[0].Rows[0]["msg"].ToString();

                            cmdSave.Text = "Update";
                        }
                        else
                        {
                            cmdSave.Text = "Save";
                            ClearFields1();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                ds = null;
            }
        }



        private void cmdSave_Click(object sender, EventArgs e)
        {
            string int_part_min = "";
            string int_part_max = "";
            string int_part1 = "";
            string int_part2 = "";
            string int_part3 = "";
            string int_part4 = "";


            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            try
            {

                if (chkRealValue.Checked == true)
                {
                    int_part_min = integerpart_min.Text + mychar.Text + realpart_min.Text;
                    int_part_max = integerpart_max.Text + mychar.Text + realpart_max.Text;
                    int_part1 = integerpart1.Text + mychar.Text + realpart1.Text;
                    int_part2 = integerpart2.Text + mychar.Text + realpart2.Text;
                    int_part3 = integerpart3.Text + mychar.Text + realpart3.Text;
                    int_part4 = integerpart4.Text + mychar.Text + realpart4.Text;


                    string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                    string[] fldvalue = { tabname.SelectedValue.ToString(), varname.Text, varid.SelectedValue.ToString(), varname.Text, varseq.Text, fielddesc.Text, remarks.Text, datatype.Text, fieldlen.Text, fielddecimal.Text, int_part_min, int_part_max, int_part1, int_part2, int_part3, int_part4, "", taborder.Text, message.Text, "", "", "", "", "3" };

                    ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");

                }
                else
                {

                    string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                    string[] fldvalue = { tabname.SelectedValue.ToString(), varname.Text, varid.SelectedValue.ToString(), varname.Text, varseq.Text, fielddesc.Text, remarks.Text, datatype.Text, fieldlen.Text, fielddecimal.Text, minvalue.Text, maxvalue.Text, value1.Text, value2.Text, value3.Text, value4.Text, value5.Text, taborder.Text, message.Text, "", "", "", "", "3" };

                    ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");

                }


                MessageBox.Show("Record saved successfully ", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                cmdSave.Visible = false;
                cmdDelete.Visible = false;


                obj_op.DisableControls(integerpart_min);
                obj_op.DisableControls(integerpart_max);
                obj_op.DisableControls(integerpart1);
                obj_op.DisableControls(integerpart2);
                obj_op.DisableControls(integerpart3);
                obj_op.DisableControls(integerpart4);

                obj_op.DisableControls(realpart_min);
                obj_op.DisableControls(realpart_max);
                obj_op.DisableControls(realpart1);
                obj_op.DisableControls(realpart2);
                obj_op.DisableControls(realpart3);
                obj_op.DisableControls(realpart4);

                obj_op.EnableControls(minvalue);
                obj_op.EnableControls(maxvalue);
                obj_op.EnableControls(value1);
                obj_op.EnableControls(value2);
                obj_op.EnableControls(value3);
                obj_op.EnableControls(value4);
                obj_op.EnableControls(value5);

                varid.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                ds = null;
                cmdSave.Text = "Save";
            }
        }


        private bool IsRecordExists()
        {
            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            bool IsExists = false;

            try
            {
                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { tabname.SelectedValue.ToString(), "", varid.SelectedValue.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "4" };

                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");

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
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                ds = null;
            }

            return IsExists;
        }

        private void integerpart_Leave(object sender, EventArgs e)
        {
            if (integerpart_min.Text == "")
            {
                MessageBox.Show("Required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                integerpart_min.Focus();
            }
        }

        private void realpart_Leave(object sender, EventArgs e)
        {
            if (realpart_min.Text == "")
            {
                MessageBox.Show("Required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                realpart_min.Focus();
            }
        }

        private void fielddesc_Leave(object sender, EventArgs e)
        {
            if (fielddesc.Text == "")
            {
                MessageBox.Show("Required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fielddesc.Focus();
            }
        }


        private void ClearFields()
        {
            varname.Text = "";
            fielddesc.Text = "";
            remarks.Text = "";
            datatype.Text = "";
            integerpart_max.Text = "";
            realpart_max.Text = "";
            integerpart_min.Text = "";
            realpart_min.Text = "";
            integerpart1.Text = "";
            realpart1.Text = "";
            integerpart2.Text = "";
            realpart2.Text = "";
            integerpart3.Text = "";
            realpart3.Text = "";
            integerpart4.Text = "";
            realpart4.Text = "";
            fieldlen.Text = "";
            fielddecimal.Text = "";
            minvalue.Text = "";
            maxvalue.Text = "";
            value1.Text = "";
            value2.Text = "";
            value3.Text = "";
            value4.Text = "";
            value5.Text = "";
            mychar.Text = "";
            chkRealValue.Checked = false;
            taborder.Text = "";
            message.Text = "";
        }



        private void ClearFields1()
        {
            fielddesc.Text = "";
            remarks.Text = "";
            datatype.Text = "";
            integerpart_max.Text = "";
            realpart_max.Text = "";
            integerpart_min.Text = "";
            realpart_min.Text = "";
            integerpart1.Text = "";
            realpart1.Text = "";
            integerpart2.Text = "";
            realpart2.Text = "";
            integerpart3.Text = "";
            realpart3.Text = "";
            integerpart4.Text = "";
            realpart4.Text = "";
            fieldlen.Text = "";
            fielddecimal.Text = "";
            minvalue.Text = "";
            maxvalue.Text = "";
            value1.Text = "";
            value2.Text = "";
            value3.Text = "";
            value4.Text = "";
            value5.Text = "";
            taborder.Text = "";
            message.Text = "";
            chkRealValue.Checked = false;
            mychar.Text = "";
        }


        private void cmdDelete_Click(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            try
            {
                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { tabname.SelectedValue.ToString(), "", varid.SelectedValue.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "5" };

                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");

                MessageBox.Show("Record deleted successfully ", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                cmdSave.Visible = false;
                cmdDelete.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                ds = null;
                cmdSave.Text = "Save";
            }
        }

        private void minvalue_Leave(object sender, EventArgs e)
        {
            if (minvalue.Text == "")
            {
                MessageBox.Show("Required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                minvalue.Focus();
            }
        }

        private void maxvalue_Leave(object sender, EventArgs e)
        {
            if (maxvalue.Text == "")
            {
                MessageBox.Show("Required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maxvalue.Focus();
            }
        }

        private void message_Leave(object sender, EventArgs e)
        {
            if (message.Text == "")
            {
                MessageBox.Show("Required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                message.Focus();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void chkRealValue_CheckedChanged(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            if (chkRealValue.Checked == true)
            {
                obj_op.EnableControls(integerpart_min);
                obj_op.EnableControls(integerpart_max);
                obj_op.EnableControls(integerpart1);
                obj_op.EnableControls(integerpart2);
                obj_op.EnableControls(integerpart3);
                obj_op.EnableControls(integerpart4);

                obj_op.EnableControls(realpart_min);
                obj_op.EnableControls(realpart_max);
                obj_op.EnableControls(realpart1);
                obj_op.EnableControls(realpart2);
                obj_op.EnableControls(realpart3);
                obj_op.EnableControls(realpart4);

                obj_op.DisableControls(minvalue);
                obj_op.DisableControls(maxvalue);
                obj_op.DisableControls(value1);
                obj_op.DisableControls(value2);
                obj_op.DisableControls(value3);
                obj_op.DisableControls(value4);
                obj_op.DisableControls(value5);

                integerpart_min.Focus();
            }
            else
            {
                obj_op.DisableControls(integerpart_min);
                obj_op.DisableControls(integerpart_max);
                obj_op.DisableControls(integerpart1);
                obj_op.DisableControls(integerpart2);
                obj_op.DisableControls(integerpart3);
                obj_op.DisableControls(integerpart4);

                obj_op.DisableControls(realpart_min);
                obj_op.DisableControls(realpart_max);
                obj_op.DisableControls(realpart1);
                obj_op.DisableControls(realpart2);
                obj_op.DisableControls(realpart3);
                obj_op.DisableControls(realpart4);

                obj_op.EnableControls(minvalue);
                obj_op.EnableControls(maxvalue);
                obj_op.EnableControls(value1);
                obj_op.EnableControls(value2);
                obj_op.EnableControls(value3);
                obj_op.EnableControls(value4);
                obj_op.EnableControls(value5);

                minvalue.Focus();
            }

            obj_op = null;
        }


    }
}
