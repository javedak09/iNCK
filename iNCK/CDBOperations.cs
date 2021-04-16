using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace iNCK
{
    class CDBOperations
    {
        public DataSet ExecuteNonQuery(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "." || fieldValues[a] == "  .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "a111" || fieldName[a] == "EntryDate" || fieldName[a] == "CreationDate"
                            )
                        {
                            if (fieldValues[a].ToString() == "01/01/0001" || fieldValues[a].ToString() == "  /  /")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                if (ex.Message == "String was not recognized as a valid DateTime.")
                {
                    MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_Vaccination(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "." || fieldValues[a] == "  .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "EntryDate")
                        {
                            if (fieldValues[a].ToString() == "01/01/0001" || fieldValues[a].ToString() == "  /  /")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;

                CVariables.ChildCountDtl = CVariables.ChildCountDtl + 1;
            }

            catch (Exception ex)
            {
                if (ex.Message == "String was not recognized as a valid DateTime.")
                {
                    MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_Minutes(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "F2_Q6" || fieldName[a] == "F2_Q8" || fieldName[a] == "F2_Q49A" || fieldName[a] == "F2_Q50A" || fieldName[a] == "F2_Q51A" || fieldName[a] == "F2_Q52A" || fieldName[a] == "EntryDate" || fieldName[a] == "F3_Q4" || fieldName[a] == "F3_Q13A" || fieldName[a] == "F3_Q14A" || fieldName[a] == "F3_Q15A" || fieldName[a] == "F3_Q16A")
                        {
                            if (fieldValues[a].ToString() == "01/01/0001" || fieldValues[a].ToString() == "  /  /")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }





        public DataSet ExecuteNonQuery_Ultrasound(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "01/01/0001" || fieldValues[a] == "    -" || fieldValues[a] == " .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q1_9" || fieldName[a] == "QC_RA_DT" || fieldName[a] == "EDIT_DT" || fieldName[a] == "QC_AKU_DT" || fieldName[a] == "DEO1_DT" || fieldName[a] == "DEO2_DT" || fieldName[a] == "Q3_1a" || fieldName[a] == "EntryDate")
                        {
                            if (fieldValues[a] == "01/01/0001")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_CRF6(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "    -" || fieldValues[a] == " .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q1" || fieldName[a] == "EntryDate" || fieldName[a] == "Q6" || fieldName[a] == "Q5_iiic" || fieldName[a] == "Q5_ivc" || fieldName[a] == "Q5_vc" || fieldName[a] == "Q5_vic")
                        {
                            if (fieldValues[a] == "01/01/0001")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_Ultrasound_Scan1(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "01/01/0001" || fieldValues[a] == "    -" || fieldValues[a] == " .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q16" || fieldName[a] == "EntryDate")
                        {
                            if (fieldValues[a] == "01/01/0001")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }





        public DataSet ExecuteNonQuery_VA_Maternal(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsError = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "EntryDate" || fieldName[a] == "Q1211" || fieldName[a] == "Q1212" || fieldName[a] == "Q1213" || fieldName[a] == "Q1_22b" || fieldName[a] == "Q18" || fieldName[a] == "Q27" || fieldName[a] == "Q364" || fieldName[a] == "Q365")
                        {
                            if (fieldValues[a] == "01/01/0001")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsError = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_VA_StillBirth(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "EntryDate" || fieldName[a] == "Q1211" || fieldName[a] == "Q1212" || fieldName[a] == "Q1213" || fieldName[a] == "Q1_22b")
                        {
                            if (fieldValues[a] == "01/01/0001")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_VA_NEONATAL(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "EntryDate" || fieldName[a] == "Q1211" || fieldName[a] == "Q1212" || fieldName[a] == "Q1213" || fieldName[a] == "Q5b")
                        {
                            if (fieldValues[a] == "01/01/0001")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }



        public DataSet ExecuteNonQuery_CRF2b(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "EntryDate" || fieldName[a] == "StartDate" || fieldName[a] == "EndDate" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q7" || fieldName[a] == "Q9" || fieldName[a] == "Q55" || fieldName[a] == "Q57")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_CRF2b_Final(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "01/01/0001" || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "Q121a" || fieldName[a] == "Q121b" || fieldName[a] == "EntryDate" || fieldName[a] == "StartDate" || fieldName[a] == "EndDate" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q7" || fieldName[a] == "Q9" || fieldName[a] == "Q55" || fieldName[a] == "Q57" || fieldName[a] == "Q7a")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_CRF2a_Final(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "01/01/0001" || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "Q121a" || fieldName[a] == "Q121b" || fieldName[a] == "Q5_PH" || fieldName[a] == "EntryDate" || fieldName[a] == "StartDate" || fieldName[a] == "EndDate" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q7" || fieldName[a] == "Q9" || fieldName[a] == "Q3_MCH" || fieldName[a] == "Q5_MCH" || fieldName[a] == "Q7a")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_CRF2a(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "Q5_PH" || fieldName[a] == "EntryDate" || fieldName[a] == "StartDate" || fieldName[a] == "EndDate" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q7" || fieldName[a] == "Q9" || fieldName[a] == "Q3_MCH" || fieldName[a] == "Q5_MCH")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public DataSet ExecuteNonQuery_CRF11(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "EntryDate" || fieldName[a] == "Q121" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q121a" || fieldName[a] == "Q2c" || fieldName[a] == "Q2d")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_CRF10(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "Q9" || fieldName[a] == "EntryDate" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }





        public DataSet ExecuteNonQuery_CRF10_Final(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "Q121a" || fieldName[a] == "Q121b" || fieldName[a] == "Q9" || fieldName[a] == "EntryDate" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q7a")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_CRF1A(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "EntryDate" || fieldName[a] == "Q7" || fieldName[a] == "Q10a" || fieldName[a] == "Q10b" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q56" || fieldName[a] == "Q58")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_CRF1A_Final(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "01/01/0001" || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q121" || fieldName[a] == "Q121a" || fieldName[a] == "Q121b" || fieldName[a] == "EntryDate" || fieldName[a] == "Q7" || fieldName[a] == "Q10a" || fieldName[a] == "Q10b" || fieldName[a] == "EDITED_DT" || fieldName[a] == "CHECKED_DT" || fieldName[a] == "ENTRY1_DT" || fieldName[a] == "ENTRY2_DT" || fieldName[a] == "Q56" || fieldName[a] == "Q58")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }






        public DataSet ExecuteNonQuery_Mismatch(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "MP_SA_Q4" || fieldName[a] == "MP_SA_Q11" || fieldName[a] == "MP_SA_Q15" || fieldName[a] == "MP_SA_Q17" || fieldName[a] == "MP_MEDICAL_OFF_DATE" || fieldName[a] == "MP_SUPER_DATE" || fieldName[a] == "MP_F7_Q4" || fieldName[a] == "MP_F7_Q5" || fieldName[a] == "MP_F56_Q4" || fieldName[a] == "MP_F56_Q5" || fieldName[a] == "MP_F56_SE_Q5" || fieldName[a] == "MP_MEDICAL_OFF_DATE" || fieldName[a] == "MP_SUPER_DATE" || fieldName[a] == "MP_SE_Q5" || fieldName[a] == "MP_SE_Q5a" || fieldName[a] == "MP_IPT_DATE_URINE" || fieldName[a] == "MP_IPT_DATE_URINE_DISPATCH" || fieldName[a] == "MP_IPT_SENDER_SIGN_DATE" || fieldName[a] == "MP_IPT_RECV_DATE" || fieldName[a] == "MP_IPT_RECVER_DATE" || fieldName[a] == "MP_SENDER_DATE" || fieldName[a] == "MP_RECV_DATE" || fieldName[a] == "MP_RECEIVER_DATE" || fieldName[a] == "MP_SENDER_DATE" || fieldName[a] == "MP_RECEIVED_DATE" || fieldName[a] == "MP_Q5" || fieldName[a] == "MP_Q6")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }



        public DataSet ExecuteNonQuery_New2(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            string[] dt;

            CVariables.IsSuccess = false;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "MP_SE_Q7c" || fieldName[a] == "MP_SE_Q8c" || fieldName[a] == "MP_SE_Q9c")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public DataSet ExecuteNonQuery_New(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            string[] dt;

            CVariables.IsSuccess = false;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "MP_SA_Q4" || fieldName[a] == "MP_SA_Q11" || fieldName[a] == "MP_SA_Q15" || fieldName[a] == "MP_SA_Q17" || fieldName[a] == "MP_MEDICAL_OFF_DATE" || fieldName[a] == "MP_SUPER_DATE" || fieldName[a] == "MP_F7_Q4" || fieldName[a] == "MP_F7_Q5" || fieldName[a] == "MP_F56_Q4" || fieldName[a] == "MP_F56_Q5" || fieldName[a] == "MP_F56_SE_Q4" || fieldName[a] == "MP_MEDICAL_OFF_DATE" || fieldName[a] == "MP_SUPER_DATE" || fieldName[a] == "MP_SE_Q5" || fieldName[a] == "MP_SE_Q5a" || fieldName[a] == "MP_IPT_DATE_URINE" || fieldName[a] == "MP_IPT_DATE_URINE_DISPATCH" || fieldName[a] == "MP_IPT_SENDER_SIGN_DATE" || fieldName[a] == "MP_IPT_U_Q2" || fieldName[a] == "MP_IPT_U_Q3" || fieldName[a] == "MP_IPT_RECV_DATE" || fieldName[a] == "MP_IPT_RECVER_DATE" || fieldName[a] == "MP_SENDER_DATE" || fieldName[a] == "MP_RECV_DATE" || fieldName[a] == "MP_RECEIVER_DATE" || fieldName[a] == "MP_SENDER_DATE" || fieldName[a] == "MP_RECEIVED_DATE" || fieldName[a] == "MP_Q5" || fieldName[a] == "MP_Q6" || fieldName[a] == "MP_SA_Q1" || fieldName[a] == "MP_SA_Q8" || fieldName[a] == "MP_SE_Q7c" || fieldName[a] == "MP_SE_Q8c" || fieldName[a] == "MP_SE_Q9c")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }



        public bool Validate_Dictionary_SpecialCode(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value5"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString() && formno != ds.Tables[0].Rows[0]["value5"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value5"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public string[] Validate_Dictionary_SpecialCode_Multiple(string fldval, string spName, string criteria, string formno)
        {
            string[] arr = { "" };

            DataSet ds = null;
            //bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value5"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString() && formno != ds.Tables[0].Rows[0]["value5"].ToString())
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            arr[0] = ds.Tables[0].Rows[0]["value1"].ToString();
                                            arr[1] = ds.Tables[0].Rows[0]["value2"].ToString();
                                            arr[2] = ds.Tables[0].Rows[0]["value3"].ToString();
                                            arr[3] = ds.Tables[0].Rows[0]["value4"].ToString();
                                            arr[4] = ds.Tables[0].Rows[0]["value5"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value5"]) == Convert.ToDouble(formno))
                                    {

                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                arr[0] = ds.Tables[0].Rows[0]["MinValue"].ToString();
                                                arr[1] = ds.Tables[0].Rows[0]["MaxValue"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString())
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            arr[0] = ds.Tables[0].Rows[0]["value1"].ToString();
                                            arr[1] = ds.Tables[0].Rows[0]["value2"].ToString();
                                            arr[2] = ds.Tables[0].Rows[0]["value3"].ToString();
                                            arr[3] = ds.Tables[0].Rows[0]["value4"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno))
                                    {

                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                arr[0] = ds.Tables[0].Rows[0]["MinValue"].ToString();
                                                arr[1] = ds.Tables[0].Rows[0]["MaxValue"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString())
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            arr[0] = ds.Tables[0].Rows[0]["value1"].ToString();
                                            arr[1] = ds.Tables[0].Rows[0]["value2"].ToString();
                                            arr[2] = ds.Tables[0].Rows[0]["value3"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno))
                                    {

                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                arr[0] = ds.Tables[0].Rows[0]["MinValue"].ToString();
                                                arr[1] = ds.Tables[0].Rows[0]["MaxValue"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString())
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            arr[0] = ds.Tables[0].Rows[0]["value1"].ToString();
                                            arr[1] = ds.Tables[0].Rows[0]["value2"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno))
                                    {

                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                arr[0] = ds.Tables[0].Rows[0]["MinValue"].ToString();
                                                arr[1] = ds.Tables[0].Rows[0]["MaxValue"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString())
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            arr[0] = ds.Tables[0].Rows[0]["value1"].ToString();
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            arr[0] = ds.Tables[0].Rows[0]["MinValue"].ToString();
                                            arr[1] = ds.Tables[0].Rows[0]["MaxValue"].ToString();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (formno.ToString().IndexOf('.') == -1)
                            {
                                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        arr[0] = ds.Tables[0].Rows[0]["MinValue"].ToString();
                                        arr[1] = ds.Tables[0].Rows[0]["MaxValue"].ToString();
                                    }
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                {
                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        arr[0] = ds.Tables[0].Rows[0]["MinValue"].ToString();
                                        arr[1] = ds.Tables[0].Rows[0]["MaxValue"].ToString();
                                    }
                                }
                            }
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
                ds = null;
            }

            return arr;
        }






        public DataSet GetFieldValue_FromDictionary(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }







        public bool Validate_Dictionary_SpecialCode_WithOutBlank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    //MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value5"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString() && formno != ds.Tables[0].Rows[0]["value5"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value5"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_CRF6(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value5"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString() && formno != ds.Tables[0].Rows[0]["value5"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value5"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_Ultrasound(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value5"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString() && formno != ds.Tables[0].Rows[0]["value5"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value5"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString() && formno != ds.Tables[0].Rows[0]["value4"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value4"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString() && formno != ds.Tables[0].Rows[0]["value3"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value3"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString() && formno != ds.Tables[0].Rows[0]["value2"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["value1"]) == Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["value2"]) == Convert.ToDouble(formno))
                                        {

                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                            {
                                                if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                                {
                                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    IsError = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false)
                            {
                                if (formno != ds.Tables[0].Rows[0]["value1"].ToString())
                                {
                                    if (formno.ToString().IndexOf('.') == -1)
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                        {
                                            if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                            {
                                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                IsError = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (formno.ToString().IndexOf('.') == -1)
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                    {
                                        if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_Ultrasound_WithOutBlank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value5"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() || formno != ds.Tables[0].Rows[0]["value2"].ToString() || formno != ds.Tables[0].Rows[0]["value3"].ToString() || formno != ds.Tables[0].Rows[0]["value4"].ToString() || formno != ds.Tables[0].Rows[0]["value5"].ToString())
                            {
                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                IsError = true;
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value4"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() || formno != ds.Tables[0].Rows[0]["value2"].ToString() || formno != ds.Tables[0].Rows[0]["value3"].ToString() || formno != ds.Tables[0].Rows[0]["value4"].ToString())
                            {
                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                IsError = true;
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() || formno != ds.Tables[0].Rows[0]["value2"].ToString() || formno != ds.Tables[0].Rows[0]["value3"].ToString())
                            {
                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                IsError = true;
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString() || formno != ds.Tables[0].Rows[0]["value2"].ToString())
                            {
                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                IsError = true;
                            }
                        }
                        else if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()) == false)
                        {
                            if (formno != ds.Tables[0].Rows[0]["value1"].ToString())
                            {
                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                IsError = true;
                            }
                        }
                        else
                        {
                            if (formno.ToString().IndexOf('.') == -1)
                            {
                                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MinValue"].ToString()) == false && string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaxValue"].ToString()) == false)
                                {
                                    if (Convert.ToDouble(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDouble(formno) || Convert.ToDouble(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDouble(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_SpecialValues8Or9(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 8)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 9)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_SpecialValues88Or9(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 88)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 9)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues88Or99(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 88)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 99)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues88Or99Or66(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 88)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 99)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value3"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 66)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues6Or8(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 6)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 8)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_SpecialValues66Or88(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 66)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 88)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues66(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 66)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }





        public bool Validate_Dictionary_SpecialValues6Or8Or9(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 6)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 8)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 9)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value3"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues4Or8Or9(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 8)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 9)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues99Or66(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 66)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 99)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues88Or66(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 66)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 88)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues99Or77(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 77)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 99)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues888Or999(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 888)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 999)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues88Or99_new(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (Convert.ToInt32(formno) == 88)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
                            else if (Convert.ToInt32(formno) == 99)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues88Or99_WithOutBlank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (Convert.ToInt32(formno) == 88)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
                            else if (Convert.ToInt32(formno) == 99)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues888Or999_WithOutBlank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (Convert.ToInt32(formno) == 888)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
                            else if (Convert.ToInt32(formno) == 999)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues88(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 88)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues888(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 888)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues99(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 99)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues77(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 77)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_SpecialValues999(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 999)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_SpecialValues8888Or9999(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 8888)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 9999)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_SpecialValues88_WithOutBlank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (Convert.ToInt32(formno) == 88)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues888_WithOutBlank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (Convert.ToInt32(formno) == 888)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_SpecialValues999_WithOutBlank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (Convert.ToInt32(formno) == 999)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues8(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 8)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues8Or99(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 8)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 99)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_SpecialValues6(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 6)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_SpecialValues9(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 9)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public DataSet Validate_Dictionary_Others(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    //MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                {
                                    //MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);                                    
                                }
                            }
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

            }

            return ds;
        }





        public bool Validate_Dictionary_EqualToSign(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) != Convert.ToInt32(formno) && Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) != Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_WithOut_Blank(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);


                if (formno != "")
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }


        public bool Validate_Dictionary_DoubleValues(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "  .")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToDecimal(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDecimal(formno) || Convert.ToDecimal(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDecimal(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_DoubleValues_SpecialValues(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "  .")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (formno == Convert.ToString(Convert.ToDecimal(ds.Tables[0].Rows[0]["value1"])))
                            {
                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                IsError = true;
                            }
                            else
                            {
                                if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                                {
                                    if (Convert.ToDecimal(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDecimal(formno) || Convert.ToDecimal(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDecimal(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }



        public bool Validate_Dictionary_DoubleValues_WithBlankValues(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno != "   .")
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToDecimal(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDecimal(formno) || Convert.ToDecimal(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDecimal(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public DataSet ExecuteNonQuery_New9(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            string[] dt;

            CVariables.IsSuccess = false;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "MP_SE_Q5" || fieldName[a] == "MP_SE_Q5a")
                        {
                            dt = fieldValues[a].Split(' ');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[0] + "/" + dt[1]);
                        }
                        else if (fieldName[a] == "MP_MEDICAL_OFF_DATE" || fieldName[a] == "MP_SUPER_DATE")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public DataSet ExecuteNonQuery_New1(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            string[] dt;

            CVariables.IsSuccess = false;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   .")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "MP_SA_Q1" || fieldName[a] == "MP_SA_Q8" || fieldName[a] == "MP_SE_Q7c" || fieldName[a] == "MP_SE_Q8c" || fieldName[a] == "MP_SE_Q9c" || fieldName[a] == "EntryDate")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);

                            /*System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                            DateTime dt1 = Convert.ToDateTime(fieldValues[a]);
                            cmd.Parameters.AddWithValue(fieldName[a], dt1.Date);*/
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }



        public DataSet ExecuteNonQuery2(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            string[] dt;


            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  -   -  -      -  - -" || fieldValues[a] == "3-     -" || fieldValues[a] == "  ." || fieldValues[a] == "  -   -  -    -  - -")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "IPOPFRM1_Q1_1")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                cmd.ExecuteNonQuery();

                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }




        public DataSet ExecuteNonQuery_Dual(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            string[] dt;


            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  -   -  -      -  - -" || fieldValues[a] == "3-     -" || fieldValues[a] == "  ." || fieldValues[a] == "  -   -  -    -  - -")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "upd_date")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                cmd.ExecuteNonQuery();

                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }





        public DataSet ExecuteNonQuery1(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            string[] dt;


            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  -   -  -      -  - -" || fieldValues[a] == "3-     -" || fieldValues[a] == "  ." || fieldValues[a] == "UU-UUU-  -    -UU- -")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "IPOPFRM1_Q1_1")
                        {
                            dt = fieldValues[a].Split('/');
                            cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }


                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public DataSet ExecuteNonQuery(Array fldname, Array fldvalue, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            string[] dt;


            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fldname.Length - 1; a++)
                {
                    if (fldname.GetValue(a).ToString() == " -" || fldname.GetValue(a).ToString() == "  /  /" || fldname.GetValue(a).ToString() == "  :" || fldname.GetValue(a).ToString() == "" || fldname.GetValue(a).ToString() == "  -   -  -      -  - -" || fldname.GetValue(a).ToString() == "3-     -" || fldname.GetValue(a).ToString() == "  ." || fldname.GetValue(a).ToString() == "UU-UUU-  -    -UU- -")
                    {
                        cmd.Parameters.AddWithValue(fldname.GetValue(0).ToString(), fldvalue.GetValue(a).ToString());
                    }
                    else
                    {
                        if (fldname.GetValue(a).ToString() == "IPOPFRM1_Q1_1")
                        {
                            dt = fldvalue.GetValue(a).ToString().Split('/');
                            cmd.Parameters.AddWithValue(fldname.GetValue(a).ToString(), dt[1] + "/" + dt[0] + "/" + dt[2]);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fldname.GetValue(0).ToString(), fldvalue.GetValue(a).ToString());
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);


                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public DataSet AddUpdateForm1(string IPOPFRM1_EAID, string IPOPFRM1_IPOPID, string IPOPFRM1_Q1_1, string IPOPFRM1_Q1_2, string IPOPFRM1_Q1_3, string IPOPFRM1_Q1_4, string IPOPFRM1_Q2_1, string IPOPFRM1_Q2_2, string IPOPFRM1_Q2_3, string IPOPFRM1_Q2_4, string IPOPFRM1_Q3_1, string IPOPFRM1_Q3_2, string IPOPFRM1_Q3_3, string IPOPFRM1_Q3_4, string IPOPFRM1_Q3_5, string IPOPFRM1_Q3_6, string IPOPFRM1_Q3_7, string spName)
        {
            string[] arr;

            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            try
            {
                cn = new CConnection();
                cn.MConnOpen();


                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                if (IPOPFRM1_EAID == " -")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_EAID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_EAID", IPOPFRM1_EAID);
                }


                if (IPOPFRM1_IPOPID == " -")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_IPOPID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_IPOPID", IPOPFRM1_IPOPID);
                }

                DateTime dt = new DateTime();

                arr = IPOPFRM1_Q1_1.ToString().Split('/');


                if (IPOPFRM1_Q1_1 == "  /  /")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_1", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_1", arr[1] + "/" + arr[0] + "/" + arr[2]);
                }



                if (IPOPFRM1_Q1_2 == "  :")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_2", IPOPFRM1_Q1_2);
                }


                if (IPOPFRM1_Q1_3 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_3", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_3", IPOPFRM1_Q1_3);
                }



                if (IPOPFRM1_Q1_4 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_4", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q1_4", IPOPFRM1_Q1_4);
                }



                if (IPOPFRM1_Q2_1 == " -")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_1", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_1", IPOPFRM1_Q2_1);
                }


                if (IPOPFRM1_Q2_2 == "  -   -  -      -  - -")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_2", IPOPFRM1_Q2_2);
                }



                if (IPOPFRM1_Q2_3 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_3", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_3", IPOPFRM1_Q2_3);
                }


                if (IPOPFRM1_Q2_4 == "3-     -")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_4", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q2_4", IPOPFRM1_Q2_4);
                }


                if (IPOPFRM1_Q3_1 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_1", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("IPOPFRM1_Q3_1", IPOPFRM1_Q3_1);
                }



                if (IPOPFRM1_Q3_2 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_2", IPOPFRM1_Q3_2);
                }



                if (IPOPFRM1_Q3_3 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_3", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_3", IPOPFRM1_Q3_3);
                }



                if (IPOPFRM1_Q3_4 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_4", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_4", IPOPFRM1_Q3_4);
                }



                if (IPOPFRM1_Q3_5 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_5", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_5", IPOPFRM1_Q3_5);
                }



                if (IPOPFRM1_Q3_6 == "")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_6", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_6", IPOPFRM1_Q3_6);
                }



                if (IPOPFRM1_Q3_7 == " -")
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_7", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IPOPFRM1_Q3_7", IPOPFRM1_Q3_7);
                }


                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);


                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public DataSet DeleteForm1(string FormID, string spName, string fldvalue, string visitid)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                if (FormID == "")
                {
                    cmd.Parameters.AddWithValue("FormID", "NULL");
                }
                else
                {
                    cmd.Parameters.AddWithValue("FormID", FormID);
                }


                cmd.Parameters.AddWithValue("fldvalue", fldvalue);
                cmd.Parameters.AddWithValue("visitid", visitid);


                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);


                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }



        public DataSet DeleteForm_Ultrasound(string FormID, string spName, string fldvalue, string visitid, string formno)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                if (FormID == "")
                {
                    cmd.Parameters.AddWithValue("FormID", "NULL");
                }
                else
                {
                    cmd.Parameters.AddWithValue("FormID", FormID);
                }


                cmd.Parameters.AddWithValue("fldvalue", fldvalue);
                cmd.Parameters.AddWithValue("visitid", visitid);
                cmd.Parameters.AddWithValue("formno", formno);


                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);


                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }





        public DataSet DeleteForm_VisitID_FormID(string FormID, string spName, string fldvalue, string visitid, string formno)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                if (FormID == "")
                {
                    cmd.Parameters.AddWithValue("FormID", "NULL");
                }
                else
                {
                    cmd.Parameters.AddWithValue("FormID", FormID);
                }


                cmd.Parameters.AddWithValue("fldvalue", fldvalue);
                cmd.Parameters.AddWithValue("visitid", visitid);
                cmd.Parameters.AddWithValue("formno", formno);


                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);


                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public DataSet DeleteForm(string IPOPFRM1_IPOPID, string spName, string fldvalue)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                if (IPOPFRM1_IPOPID == " -")
                {
                    cmd.Parameters.AddWithValue("FormID", "NULL");
                }
                else
                {
                    cmd.Parameters.AddWithValue("FormID", IPOPFRM1_IPOPID);
                }

                cmd.Parameters.AddWithValue("fldvalue", fldvalue);


                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);


                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }

        public DataSet DeleteForm_VisitID(string IPOPFRM1_IPOPID, string spName, string fldvalue, string visitid)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlTransaction trans = null;

            try
            {
                cn = new CConnection();
                cn.MConnOpen();

                trans = cn.cn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;

                if (IPOPFRM1_IPOPID == "")
                {
                    cmd.Parameters.AddWithValue("FormID", "NULL");
                }
                else
                {
                    cmd.Parameters.AddWithValue("FormID", IPOPFRM1_IPOPID);
                }


                cmd.Parameters.AddWithValue("fldvalue", fldvalue);
                cmd.Parameters.AddWithValue("VisitID", visitid);


                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);


                trans.Commit();
            }

            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.MConnClose();
                cmd = null;
                cn = null;
            }

            return ds;
        }


        public void DataErrorCheck(string frmName, string spName, string ipopid, string fld_value)
        {
            DataSet ds = null;

            try
            {

                string[] fldname = { "IPOPFRM1_IPOPID", "fldvalue" };
                string[] fldvalue = { "0", fld_value };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);


                for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
                {

                    for (int b = 0; b <= ds.Tables[0].Columns.Count - 1; b++)
                    {

                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            if (ds.Tables[0].Rows[a][b].ToString() == "NULL" || ds.Tables[0].Rows[a][b].ToString() == "")
                            {

                                string[] fldname1 = { "iPOPID", "FormName", "FieldName", "FieldDescription", "ErrorDescription", "Archive", "fldvalue" };
                                string[] fldvalue1 = { ds.Tables[0].Rows[a][ipopid].ToString(), frmName, ds.Tables[0].Columns[b].ColumnName, "", "Missing", "0", "1" };

                                ExecuteNonQuery(fldname1, fldvalue1, "sp_Create_Error");
                            }

                        }   //   ds.Tables[0].Rows.Count > 0

                    }      //  for (int b = 0; b <= ds.Tables[0].Columns.Count - 1; b++)

                }      //   for (int a = 0; a <= ds.Tables[0].Rows.Count - 1; a++)
            }

            catch (Exception ex)
            {

            }

            finally
            {
                ds = null;
            }

        }



        public DataSet GetFormData(string spName, string fldval, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue" };
                string[] fldvalue = { formno, fldval };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }


        public DataSet GetDataSet(string spName, string fldval, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormName1", "FormName2", "FormID", "VisitID", "EligibilityID", "UserID", "fldvalue" };
                string[] fldvalue = { "", "", "", "", "", "", fldval };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }




        public DataSet GetFormData_VisitID(string spName, string fldval, string formno, string visitid)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "visitid" };
                string[] fldvalue = { formno, fldval, visitid };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }




        public DataSet GetFormData_IsHRECNO_Exists(string spName, string fldval, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "HRECNO", "fldvalue" };
                string[] fldvalue = { formno, fldval };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }



        public DataSet GetFormData_VisitID22(string spName, string fldval, string childid, string visitid)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "ChildID", "fldvalue", "visitid" };
                string[] fldvalue = { childid, fldval, visitid };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }



        public DataSet GetFormData_VisitID1(string spName, string fldval, string formno, string visitid, string frmName)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "VisitID", "FormName" };
                string[] fldvalue = { formno, fldval, visitid, frmName };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }



        public DataSet GetFormData_VisitID2(string spName, string fldval, string formno, string visitid, string frmName, string fieldname)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "VisitID", "FormName", "fieldname" };
                string[] fldvalue = { formno, fldval, visitid, frmName, fieldname };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }



        public DataSet GetFormData_VisitID_FormNo(string spName, string fldval, string formid, string visitid, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "VisitID", "formno" };
                string[] fldvalue = { formid, fldval, visitid, formno };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }


        public DataSet GetFormData_VisitID_FormNo1(string spName, string fldval, string formid, string visitid, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "scrno", "ptid" };
                string[] fldvalue = { formid, fldval, visitid, formno };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }



        public DataSet GetFormData_VisitID_FormNo(string spName, string fldval, string formid, string visitid, string frmName, string formno)
        {
            DataSet ds = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "VisitID", "FormName", "FormNo" };
                string[] fldvalue = { formid, fldval, visitid, frmName, formno };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }



        public DataSet GetFormData_DateWise(string spName, string fldval, string formno, string visitdate)
        {
            DataSet ds = null;

            try
            {
                if (formno != "")
                {
                    string[] fldname = { "MOPVELF_FORMNO", "visitid", "fldvalue" };
                    string[] fldvalue = { formno, visitdate, fldval };

                    ds = ExecuteNonQuery(fldname, fldvalue, spName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return ds;
        }


        public string CheckedChange(string spName, string frmNo, string id, string fieldName)
        {
            string val = "";
            DataSet ds = null;

            try
            {
                string[] fldname = { "MOPVELF_FORMNO", "fldvalue" };
                string[] fldvalue = { frmNo, id };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        val = ds.Tables[0].Rows[0]["" + fieldName + ""].ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                ds = null;
            }

            return val;
        }


        public string CheckedChange(string spName, string frmNo, string id, string fieldName, string VisitID)
        {
            string val = "";
            DataSet ds = null;

            try
            {
                string[] fldname = { "MOPVELF_FORMNO", "VisitID", "fldvalue" };
                string[] fldvalue = { frmNo, VisitID, id };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        val = ds.Tables[0].Rows[0]["" + fieldName + ""].ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                ds = null;
            }

            return val;
        }


        public bool IsRecordExists(string fieldValue, string id, string visitid)
        {
            bool IsExists = false;
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "visitid" };
                string[] fldvalue = { fieldValue.ToString(), id.ToString(), visitid };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_GetRecords");

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
            }

            return IsExists;
        }



        public bool IsRandomisationNo_AgeGroup(string fieldValue, string id, string visitid)
        {
            bool IsExists = false;
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "agegroup" };
                string[] fldvalue = { fieldValue.ToString(), id.ToString(), visitid };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_GetRecords1");

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
            }

            return IsExists;
        }



        //public bool IsRecordExists(string id, string studyid)
        //{
        //    bool IsExists = false;
        //    CDBOperations obj_op = null;

        //    try
        //    {
        //        string[] fldname = { "MOPVELF_FORMNO", "fldvalue" };
        //        string[] fldvalue = { studyid, id.ToString() };

        //        obj_op = new CDBOperations();
        //        DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_GetRecords");

        //        if (ds != null)
        //        {
        //            if (ds.Tables.Count > 0)
        //            {
        //                if (ds.Tables[0].Rows.Count > 0)
        //                {
        //                    IsExists = true;
        //                }
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    finally
        //    {
        //        obj_op = null;
        //    }

        //    return IsExists;
        //}



        public string GetDataFieldWise(string id, string spName, string fieldname, string fieldvalue)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue" };
                string[] fldvalue = { fieldvalue, id.ToString() };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();
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
            }

            return value;
        }



        public string GetDataFieldWise_Dates(string id, string spName, string fieldname, string fieldvalue, string visitid)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "visitid" };
                string[] fldvalue = { fieldvalue, id.ToString(), visitid };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();
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
            }

            return value;
        }



        public string DaysDifference(string id, string spName, string fieldname, string fieldvalue, string StartDate, string EndDate, string VisitID)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "StartDate", "EndDate", "VisitID" };
                string[] fldvalue = { fieldvalue, id, StartDate, EndDate, VisitID };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();

                            if (value == "")
                            {
                                value = "-0";
                            }
                        }
                        else
                        {
                            value = "99/99/9999";
                        }
                    }
                    else
                    {
                        value = "99/99/9999";
                    }
                }
                else
                {
                    value = "99/99/9999";
                }
            }

            catch (Exception ex)
            {
                if (ex.Message == "String was not recognized as a valid DateTime.")
                {
                    MessageBox.Show("Invalid Date format. Date must be entered in dd/mm/yyyy format ", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            finally
            {
                obj_op = null;
            }

            return value;
        }





        public string Minutes_Difference(string id, string spName, string fieldname, string fieldvalue, string StartDate, string EndDate, string VisitID)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] arr;
                string form_id = "";
                string form_id1 = "";

                if (fieldvalue != "")
                {
                    form_id = fieldvalue;
                }


                string[] fldname = { "FormID", "fldvalue", "StartDate", "EndDate", "VisitID" };
                string[] fldvalue = { form_id, id, StartDate, EndDate, VisitID };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery_Minutes(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();

                            if (value == "")
                            {
                                value = "-0";
                            }
                        }
                        else
                        {
                            value = "99/99/9999";
                        }
                    }
                    else
                    {
                        value = "99/99/9999";
                    }
                }
                else
                {
                    value = "99/99/9999";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return value;
        }



        public string DaysDifference_Dec13(string id, string spName, string fieldname, string fieldvalue, string StartDate, string EndDate, string VisitID)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] arr;
                string form_id = "";
                string form_id1 = "";

                if (fieldvalue != "")
                {
                    form_id = fieldvalue;
                }


                string[] fldname = { "FormID", "fldvalue", "StartDate", "EndDate", "VisitID" };
                string[] fldvalue = { form_id, id, StartDate, EndDate, VisitID };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();

                            if (value == "")
                            {
                                value = "-333333333";
                            }
                        }
                        else
                        {
                            value = "99/99/9999";
                        }
                    }
                    else
                    {
                        value = "99/99/9999";
                    }
                }
                else
                {
                    value = "99/99/9999";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return value;
        }



        public string DaysDifference8(string id, string spName, string fieldname, string fieldvalue, string StartDate, string EndDate, string VisitID)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "StartDate", "EndDate", "VisitID" };
                string[] fldvalue = { fieldvalue, id, StartDate, EndDate, VisitID };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();

                            if (value == "")
                            {
                                value = "-0";
                            }
                        }
                        else
                        {
                            value = "99/99/9999";
                        }
                    }
                    else
                    {
                        value = "99/99/9999";
                    }
                }
                else
                {
                    value = "99/99/9999";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return value;
        }







        public string DaysDifference_NEW(string id, string spName, string fieldname, string fieldvalue, string StartDate, string EndDate, string VisitID, string Study_ID)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "StartDate", "EndDate", "VisitID", "StudyID" };
                string[] fldvalue = { fieldvalue, id, StartDate, EndDate, VisitID, Study_ID };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();
                        }
                        else
                        {
                            value = "0";
                        }
                    }
                    else
                    {
                        value = "0";
                    }
                }
                else
                {
                    value = "0";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return value;
        }


        public string GetDataFieldWise_VisitID(string id, string spName, string fieldname, string fieldvalue, string visitid)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "visitid" };
                string[] fldvalue = { fieldvalue, id.ToString(), visitid };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();
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
            }

            return value;
        }



        public string GetDataFieldWise_VisitID1(string id, string spName, string fieldname, string fieldvalue, string visitid, string val)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "visitid", "val" };
                string[] fldvalue = { fieldvalue, id.ToString(), visitid, val };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();
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
            }

            return value;
        }





        public string GetDataFieldWise_VisitID_FormNo(string id, string spName, string fieldname, string fieldvalue, string visitid, string formno)
        {
            string value = "";
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "visitid", "formno" };
                string[] fldvalue = { fieldvalue, id.ToString(), visitid, formno };

                obj_op = new CDBOperations();
                DataSet ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + fieldname + ""].ToString();
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
            }

            return value;
        }


        public DataSet FillDataset(string id, string spName, string fieldvalue, string visitid)
        {
            DataSet ds = null;
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FormID", "fldvalue", "visitid" };
                string[] fldvalue = { fieldvalue, id.ToString(), visitid };

                obj_op = new CDBOperations();
                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, spName);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return ds;
        }


        public bool IsValidate(Control txtbox1, Control txtbox2)
        {
            bool IsExists = false;

            try
            {
                if (txtbox1.Text == "")
                {
                    if (txtbox1.Text != "555" && txtbox1.Text != "666" && txtbox1.Text != "777" && txtbox1.Text != "888" && txtbox1.Text != "999")
                    {
                        MessageBox.Show("Invalid digit entered. Please enter any digit 555 or 666 or 777 or 888 or 999 ", "Invalid Digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbox1.Focus();
                        IsExists = false;
                    }
                }
                else
                {
                    IsExists = true;
                    txtbox2.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtbox1 = null;
                txtbox2 = null;
            }

            return IsExists;
        }






        public bool IsValidateTime(Control txtbox1, Control txtbox2)
        {
            bool IsError = false;

            try
            {
                if (txtbox1.Text != "  :")
                {
                    DateTime dt = new DateTime();
                    dt = Convert.ToDateTime(txtbox1.Text);
                    txtbox2.Focus();
                    IsError = false;
                }
                else
                {
                    IsError = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid time", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox1.Focus();
            }

            finally
            {
                txtbox1 = null;
                txtbox2 = null;
            }

            return IsError;
        }





        public bool IsValidated(string spName, string fldvalue, string formno, string visitid, string household_fieldname, string current_fieldname)
        {
            bool IsExists = false;
            DataSet ds = null;

            try
            {
                ds = GetFormData_VisitID(spName, fldvalue, formno, visitid);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["" + household_fieldname + ""].ToString().Trim() != current_fieldname)
                            {
                                IsExists = true;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                ds = null;
            }

            return IsExists;
        }




        public string Get_Dictionary_FieldValue(string tabname, string fieldname, string TabPageNo)
        {
            CDBOperations obj_op = new CDBOperations();
            string value = "";
            DataSet ds = null;

            try
            {

                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { tabname, "", fieldname, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "6" };


                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            value = ds.Tables[0].Rows[0]["" + TabPageNo + ""].ToString();
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

            return value;
        }


        public DataSet GetDictionary_DataSet(string tabname, string fieldname)
        {
            CDBOperations obj_op = new CDBOperations();
            DataSet ds = null;

            try
            {

                string[] fldname = { "tabname", "var_name", "var_id", "var_nmae", "var_seq", "field_desc", "remarks", "data_type", "field_len", "field_decimal", "MinValue", "MaxValue", "value1", "value2", "value3", "value4", "value5", "taborder", "msg", "IsOthers", "Others_Value", "No_Options", "Isblank", "fldvalue" };
                string[] fldvalue = { tabname, "", fieldname, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "6" };


                ds = obj_op.ExecuteNonQuery(fldname, fldvalue, "sp_CreateDictionary");
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

            return ds;
        }



        public string Get_LMP_DATE_Anisa(string form_id)
        {
            CDBOperations obj_op = null;
            string[] arr;
            string val = "";

            try
            {
                arr = form_id.Split('-');

                if (arr[1] != "    " && arr[2] != "")
                {
                    form_id = arr[1];
                }


                obj_op = new CDBOperations();

                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    val = obj_op.GetDataFieldWise_VisitID("91", "sp_GetRecords", "Q233", form_id, "0");
                }
                else
                {
                    val = obj_op.GetDataFieldWise_VisitID("92", "sp_GetRecords", "Q233", form_id, "0");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return val;
        }


        public string Get_EDD_DATE_Anisa(string form_id)
        {
            CDBOperations obj_op = null;
            string[] arr;
            string val = "";

            try
            {
                arr = form_id.Split('-');

                if (arr[1] != "    " && arr[2] != "")
                {
                    form_id = arr[1];
                }


                obj_op = new CDBOperations();

                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    val = obj_op.GetDataFieldWise_VisitID("91", "sp_GetRecords", "Q234", form_id, "0");
                }
                else
                {
                    val = obj_op.GetDataFieldWise_VisitID("92", "sp_GetRecords", "Q234", form_id, "0");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
            }

            return val;
        }



        public void GetValues_Anisa(string form_no, string fldName, Control txtbox)
        {
            CDBOperations obj_op = null;
            string[] arr;
            string form_id = "";

            try
            {
                arr = form_no.Split('-');

                if (arr[1] != "    " && arr[2] != "")
                {
                    form_id = arr[1];
                }


                obj_op = new CDBOperations();

                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    txtbox.Text = obj_op.GetDataFieldWise_VisitID("89", "sp_GetRecords", "" + fldName + "", form_id, "0");

                    if (string.IsNullOrEmpty(txtbox.Text) == false)
                    {
                        CVariables.store_myval = true;
                    }
                    else
                    {
                        CVariables.store_myval = false;
                    }
                }
                else
                {
                    txtbox.Text = obj_op.GetDataFieldWise_VisitID("90", "sp_GetRecords", "" + fldName + "", form_id, "0");

                    if (string.IsNullOrEmpty(txtbox.Text) == false)
                    {
                        CVariables.store_myval = true;
                    }
                    else
                    {
                        CVariables.store_myval = false;
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
                txtbox = null;
            }
        }



        public void GetValues_Amanhi(string form_no, string fldName, Control txtbox)
        {
            CDBOperations obj_op = null;
            string[] arr;
            string form_id = "";

            try
            {
                arr = form_no.Split('-');

                if (arr[1] != "    " && arr[2] != "")
                {
                    form_id = arr[1];
                }


                obj_op = new CDBOperations();

                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    txtbox.Text = obj_op.GetDataFieldWise_VisitID("41", "sp_GetRecords", "" + fldName + "", form_id, "0");
                }
                else
                {
                    txtbox.Text = obj_op.GetDataFieldWise_VisitID("42", "sp_GetRecords", "" + fldName + "", form_id, "0");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                txtbox = null;
            }
        }



        public void GetValues_Anisa1(string form_no, string fldName, Control txtbox)
        {
            CDBOperations obj_op = null;
            string[] arr;
            string form_id = "";

            try
            {
                arr = form_no.Split('-');

                if (arr[1] != "    " && arr[2] != "")
                {
                    form_id = arr[1];
                }


                obj_op = new CDBOperations();

                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    FillDataset("127", "sp_GetRecords", form_id, "0");

                    //txtbox.Text = obj_op.GetDataFieldWise_VisitID("89", "sp_GetRecords", "" + fldName + "", form_id, "0");
                }
                else
                {
                    txtbox.Text = obj_op.GetDataFieldWise_VisitID("90", "sp_GetRecords", "" + fldName + "", form_id, "0");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                obj_op = null;
                txtbox = null;
            }
        }


        public void GetValues_Anisa_Dataset(string fldName, Control txtbox)
        {
            try
            {
                txtbox.Text = CVariables.FillDataset.Tables[0].Rows[0]["" + fldName + ""].ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtbox = null;
            }
        }


        public void EnableControls(Control txtbox)
        {
            try
            {
                txtbox.Enabled = true;
                txtbox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtbox = null;
            }
        }



        public void DisableControls(Control txtbox)
        {
            try
            {
                txtbox.Enabled = false;
                txtbox.BackColor = System.Drawing.Color.Silver;
                txtbox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtbox = null;
            }
        }




        public int GetDateDifference6(string fldvalue, DateTime dt1, DateTime dt2)
        {
            int day_no = 0;

            try
            {
                day_no = Convert.ToInt32(DaysDifference(fldvalue, "sp_CalculateDays", "DATE_DIFF", "", dt1.ToShortDateString(), dt2.ToShortDateString(), ""));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {

            }

            return day_no;
        }



        public bool Validate_Dictionary_DoubleValues_SpecialValues888Or999(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "  .")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (formno == Convert.ToString(Convert.ToDecimal(ds.Tables[0].Rows[0]["value1"])))
                            {
                                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                IsError = true;
                            }
                            else
                            {
                                if (Convert.ToDouble(formno) == 88.8)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != 888)
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (Convert.ToDouble(formno) == 99.9)
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != 999)
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                                else if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                                {
                                    if (Convert.ToDecimal(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDecimal(formno) || Convert.ToDecimal(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDecimal(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_DoubleValues_SpecialValues999(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "  .")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (Convert.ToDouble(formno) == 999.999)
                            {
                                if (Convert.ToDecimal(ds.Tables[0].Rows[0]["value1"]) != Convert.ToDecimal(ds.Tables[0].Rows[0]["value1"]))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
                            else if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToDecimal(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToDecimal(formno) || Convert.ToDecimal(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToDecimal(formno))
                                {
                                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    IsError = true;
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }




        public bool Validate_Dictionary_Ultrasound1(string fldval, string spName, string criteria, string formno)
        {
            DataSet ds = null;
            bool IsError = false;

            try
            {
                string[] fldname = { "Criteria" };
                string[] fldvalue = { criteria };

                ds = ExecuteNonQuery(fldname, fldvalue, spName);

                if (formno == "")
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsError = true;
                }
                else
                {
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["MinValue"].ToString() != null && ds.Tables[0].Rows[0]["MaxValue"].ToString() != null)
                            {
                                if (Convert.ToInt32(formno) == 8 || Convert.ToInt32(formno) == 88 || Convert.ToInt32(formno) == 888 || Convert.ToInt32(formno) == 8888)
                                {
                                    if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value1"].ToString()))
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]) != Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 9 || Convert.ToInt32(formno) == 99 || Convert.ToInt32(formno) == 999 || Convert.ToInt32(formno) == 9999)
                                {
                                    if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value2"].ToString()))
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]) != Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                                else if (Convert.ToInt32(formno) == 6 || Convert.ToInt32(formno) == 66 || Convert.ToInt32(formno) == 666 || Convert.ToInt32(formno) == 6666)
                                {
                                    if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["value3"].ToString()))
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["value3"]) != Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                    else
                                    {
                                        if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                        {
                                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            IsError = true;
                                        }
                                    }
                                }
                                else
                                {
                                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["MinValue"]) > Convert.ToInt32(formno) || Convert.ToInt32(ds.Tables[0].Rows[0]["MaxValue"]) < Convert.ToInt32(formno))
                                    {
                                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString(), "Outside Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        IsError = true;
                                    }
                                }
                            }
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
                ds = null;
            }

            return IsError;
        }





        public DataSet ExecuteNonQuery_Ultrasound_Scan(string[] fieldName, string[] fieldValues, string spName)
        {
            SqlCommand cmd = null;
            CConnection cn = null;
            SqlDataAdapter da = null;
            DataSet ds = null;

            CVariables.IsSuccess = false;

            string[] dt;

            try
            {
                cn = new CConnection();

                cmd = new SqlCommand();
                cmd.Connection = cn.cn;
                cmd.CommandText = spName;
                cmd.CommandType = CommandType.StoredProcedure;

                for (int a = 0; a <= fieldName.Length - 1; a++)
                {
                    if (fieldValues[a] == " -" || fieldValues[a] == "  /  /" || fieldValues[a] == "  :" || fieldValues[a] == "" || fieldValues[a] == "  ." || fieldValues[a] == "  ." || fieldValues[a] == "    " || fieldValues[a] == "   ." || fieldValues[a] == "    -")
                    {
                        cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                    }
                    else
                    {
                        if (fieldName[a] == "Q4" || fieldName[a] == "Q9" || fieldName[a] == "Q14" || fieldName[a] == "EntryDate")
                        {
                            if (fieldValues[a] == "01/01/0001")
                            {
                                cmd.Parameters.AddWithValue(fieldName[a], DBNull.Value);
                            }
                            else
                            {
                                dt = fieldValues[a].Split('/');
                                cmd.Parameters.AddWithValue(fieldName[a], dt[1] + "/" + dt[0] + "/" + dt[2]);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(fieldName[a], fieldValues[a]);
                        }
                    }
                }

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                CVariables.IsSuccess = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cmd = null;
                cn = null;
            }

            return ds;
        }



        private void CalculateDose(string form_id, TextBox txtbox)
        {
            string val = "";
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    val = obj_op.GetDataFieldWise_VisitID("1", "sp_GetRecords", "F2_Q12A", form_id, "");
                }
                else
                {
                    val = obj_op.GetDataFieldWise_VisitID("2", "sp_GetRecords", "F2_Q12A", form_id, "");
                }



                if (val != "99.99")
                {
                    if (Convert.ToDouble(val) >= 4 || Convert.ToDouble(val) <= 9)
                    {
                        if (txtbox.Text != "05.00")
                        {
                            MessageBox.Show("Dose must be 5 ml ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtbox.Focus();
                        }
                    }
                    else if (Convert.ToDouble(val) >= 10 || Convert.ToDouble(val) <= 13)
                    {
                        if (txtbox.Text != "10.00")
                        {
                            MessageBox.Show("Dose must be 10 ml ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtbox.Focus();
                        }
                    }
                    else if (Convert.ToDouble(val) >= 14 || Convert.ToDouble(val) <= 19)
                    {
                        if (txtbox.Text != "15.00")
                        {
                            MessageBox.Show("Dose must be 15 ml ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtbox.Focus();
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
            }
        }





    }
}
