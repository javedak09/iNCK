using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace iNCK
{
    public partial class Form1BL_old : Form
    {
        private bool IsSearch = false;
        private bool IsUpdate = false;
        private bool IsUpdate1 = false;
        private string comp_name = "";
        private string user_name = "";
        private string error_fldName = "";
        private bool IsError = false;


        public Form1BL_old()
        {
            InitializeComponent();
        }

        private void frmForm1BL_Load(object sender, EventArgs e)
        {

        }




        private void IA01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(IA01.Text))
                {
                    MessageBox.Show("Please enter supervisor name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IA01.Focus();
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

            IA01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IA01);
        }


        private void IA02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IA02'", IA02.Text) == true)
                {
                    IA02.Focus();
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

            IA02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IA02);
        }


        private void IA03_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(IA03.Text))
                {
                    MessageBox.Show("Please enter village name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IA03.Focus();
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

            IA03.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IA03);
        }


        private void IA04_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(IA04.Text))
                {
                    MessageBox.Show("Please enter union council name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IA04.Focus();
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

            IA04.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IA04);
        }


        private void IA05_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IA05'", IA05.Text) == true)
                {
                    IA05.Focus();
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

            IA05.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IA05);
        }


        private void IB01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(IB01.Text))
                {
                    MessageBox.Show("Please enter name of person given form ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IB01.Focus();
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

            IB01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB01);
        }


        private void IB02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB02'", IB02.Text) == true)
                {
                    IB02.Focus();
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

            IB02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB02);
        }


        private void IB03_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB03'", IB03.Text) == true)
                {
                    IB03.Focus();
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

            IB03.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB03);
        }


        private void IB04_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB04'", IB04.Text) == true)
                {
                    IB04.Focus();
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

            IB04.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB04);
        }


        private void IB05_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB05'", IB05.Text) == true)
                {
                    IB05.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 1;
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

            IB05.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB05);
        }


        private void IB06_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (IB06.Text.IndexOf(" ") != -1)
                {
                    MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IB06.Focus();
                }
                else
                {
                    if (IB06.Text.Length != 5)
                    {
                        MessageBox.Show("Incomplete input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        IB06.Focus();
                    }
                    else
                    {
                        if (IB06.Text == "  :")
                        {
                            MessageBox.Show("Interview Start Time cannot be blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            IB06.Focus();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message == "The DateTime represented by the string is not supported in calendar System.Globalization.GregorianCalendar.")
                {
                    MessageBox.Show("Invalid time ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IB06.Focus();
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IB06.Focus();
                }
            }
            finally
            {
                obj_op = null;
            }

            IB06.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB06);
        }


        private void IB07_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB07'", IB07.Text) == true)
                {
                    IB07.Focus();
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

            IB07.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB07);
        }


        private void IB08_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB08'", IB08.Text) == true)
                {
                    IB08.Focus();
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

            IB08.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB08);
        }


        private void IB09_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB09'", IB09.Text) == true)
                {
                    IB09.Focus();
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

            IB09.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB09);
        }


        private void IB0901_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB0901'", IB0901.Text) == true)
                {
                    IB0901.Focus();
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

            IB0901.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB0901);
        }


        private void IB0902_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB0902'", IB0902.Text) == true)
                {
                    IB0902.Focus();
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

            IB0902.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB0902);
        }


        private void IB0903_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IB0903'", IB0903.Text) == true)
                {
                    IB0903.Focus();
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

            IB0903.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB0903);
        }


        private void IB0996_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (string.IsNullOrEmpty(IB0996.Text))
                {
                    MessageBox.Show("Please enter others ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IB0996.Focus();
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

            IB0996.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IB0996);
        }


        private void IC01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IC01'", IC01.Text) == true)
                {
                    IC01.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 2;
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

            IC01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IC01);
        }


        private void IC02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IC02'", IC02.Text) == true)
                {
                    IC02.Focus();
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

            IC02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IC02);
        }


        private void IC03_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IC03'", IC03.Text) == true)
                {
                    IC03.Focus();
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

            IC03.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IC03);
        }


        private void IC04_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IC04'", IC04.Text) == true)
                {
                    IC04.Focus();
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

            IC04.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IC04);
        }


        private void IC05_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IC05'", IC05.Text) == true)
                {
                    IC05.Focus();
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

            IC05.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IC05);
        }


        private void ID01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'ID01'", ID01.Text) == true)
                {
                    ID01.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 3;
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

            ID01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_ID01);
        }


        private void ID02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'ID02'", ID02.Text) == true)
                {
                    ID02.Focus();
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

            ID02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_ID02);
        }


        private void ID03_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'ID03'", ID03.Text) == true)
                {
                    ID03.Focus();
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

            ID03.BackColor = Color.White;
            ChangeColorLabel(0, lbl_ID03);
        }


        private void ID04_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'ID04'", ID04.Text) == true)
                {
                    ID04.Focus();
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

            ID04.BackColor = Color.White;
            ChangeColorLabel(0, lbl_ID04);
        }


        private void IE01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IE01'", IE01.Text) == true)
                {
                    IE01.Focus();
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

            IE01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IE01);
        }


        private void IE02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IE02'", IE02.Text) == true)
                {
                    IE02.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 4;
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

            IE02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IE02);
        }


        private void IE03_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IE03'", IE03.Text) == true)
                {
                    IE03.Focus();
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

            IE03.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IE03);
        }


        private void IE04_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IE04'", IE04.Text) == true)
                {
                    IE04.Focus();
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

            IE04.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IE04);
        }


        private void IE08_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IE08'", IE08.Text) == true)
                {
                    IE08.Focus();
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

            IE08.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IE08);
        }


        private void IE09_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IE09'", IE09.Text) == true)
                {
                    IE09.Focus();
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

            IE09.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IE09);
        }


        private void IF01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IF01'", IF01.Text) == true)
                {
                    IF01.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 5;
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

            IF01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IF01);
        }


        private void IF02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IF02'", IF02.Text) == true)
                {
                    IF02.Focus();
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

            IF02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IF02);
        }


        private void IF03_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IF03'", IF03.Text) == true)
                {
                    IF03.Focus();
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

            IF03.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IF03);
        }


        private void IF04_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IF04'", IF04.Text) == true)
                {
                    IF04.Focus();
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

            IF04.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IF04);
        }


        private void IG01_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG01'", IG01.Text) == true)
                {
                    IG01.Focus();
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

            IG01.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG01);
        }


        private void IG02_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG02'", IG02.Text) == true)
                {
                    IG02.Focus();
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

            IG02.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG02);
        }


        private void IG03Title_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG03Title'", IG03Title.Text) == true)
                {
                    IG03Title.Focus();
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

            IG03Title.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG03Title);
        }


        private void IG0301_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0301'", IG0301.Text) == true)
                {
                    IG0301.Focus();
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

            IG0301.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0301);
        }


        private void IG0302_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0302'", IG0302.Text) == true)
                {
                    IG0302.Focus();
                }
                else
                {
                    tabControl1.SelectedIndex = 6;
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

            IG0302.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0302);
        }


        private void IG0303_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0303'", IG0303.Text) == true)
                {
                    IG0303.Focus();
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

            IG0303.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0303);
        }


        private void IG0304_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0304'", IG0304.Text) == true)
                {
                    IG0304.Focus();
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

            IG0304.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0304);
        }


        private void IG0305_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0305'", IG0305.Text) == true)
                {
                    IG0305.Focus();
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

            IG0305.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0305);
        }


        private void IG0306_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0306'", IG0306.Text) == true)
                {
                    IG0306.Focus();
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

            IG0306.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0306);
        }


        private void IG0307_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0307'", IG0307.Text) == true)
                {
                    IG0307.Focus();
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

            IG0307.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0307);
        }


        private void IG0308_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0308'", IG0308.Text) == true)
                {
                    IG0308.Focus();
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

            IG0308.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0308);
        }


        private void IG0309_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG0309'", IG0309.Text) == true)
                {
                    IG0309.Focus();
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

            IG0309.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG0309);
        }


        private void IG03010_Leave(object sender, EventArgs e)
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'IG03010'", IG03010.Text) == true)
                {
                    IG03010.Focus();
                }
                else
                {
                    cmdSave.Focus();
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

            IG03010.BackColor = Color.White;
            ChangeColorLabel(0, lbl_IG03010);
        }
        private void ChangeColorLabel(int a, Label lbl)
        {
            if (a == 1)
            {
                lbl.BackColor = Color.FromName("Aqua");
                //lbl.Width = 350;            
                //lbl.Height = 75;            
            }
            else
            {
                lbl.BackColor = Color.FromName("Control");
                //lbl.Width = 200;            
                //lbl.Height = 75;            
            }

        }
        private void IA01_Enter(object sender, EventArgs e)
        {
            IA01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IA01);
            IA01.SelectAll();
        }

        private void IA02_Enter(object sender, EventArgs e)
        {
            IA02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IA02);
            IA02.SelectAll();
        }

        private void IA03_Enter(object sender, EventArgs e)
        {
            IA03.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IA03);
            IA03.SelectAll();
        }

        private void IA04_Enter(object sender, EventArgs e)
        {
            IA04.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IA04);
            IA04.SelectAll();
        }

        private void IA05_Enter(object sender, EventArgs e)
        {
            IA05.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IA05);
            IA05.SelectAll();
        }

        private void IB01_Enter(object sender, EventArgs e)
        {
            IB01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB01);
            IB01.SelectAll();
        }

        private void IB02_Enter(object sender, EventArgs e)
        {
            IB02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB02);
            IB02.SelectAll();
        }

        private void IB03_Enter(object sender, EventArgs e)
        {
            IB03.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB03);
            IB03.SelectAll();
        }

        private void IB04_Enter(object sender, EventArgs e)
        {
            IB04.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB04);
            IB04.SelectAll();
        }

        private void IB05_Enter(object sender, EventArgs e)
        {
            IB05.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB05);
            IB05.SelectAll();
        }

        private void IB06_Enter(object sender, EventArgs e)
        {
            IB06.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB06);
            IB06.SelectAll();
        }

        private void IB07_Enter(object sender, EventArgs e)
        {
            IB07.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB07);
            IB07.SelectAll();
        }

        private void IB08_Enter(object sender, EventArgs e)
        {
            IB08.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB08);
            IB08.SelectAll();
        }

        private void IB09_Enter(object sender, EventArgs e)
        {
            IB09.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB09);
            IB09.SelectAll();
        }

        private void IB0901_Enter(object sender, EventArgs e)
        {
            IB0901.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB0901);
            IB0901.SelectAll();
        }

        private void IB0902_Enter(object sender, EventArgs e)
        {
            IB0902.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB0902);
            IB0902.SelectAll();
        }

        private void IB0903_Enter(object sender, EventArgs e)
        {
            IB0903.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB0903);
            IB0903.SelectAll();
        }

        private void IB0996_Enter(object sender, EventArgs e)
        {
            IB0996.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IB0996);
            IB0996.SelectAll();
        }

        private void IC01_Enter(object sender, EventArgs e)
        {
            IC01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IC01);
            IC01.SelectAll();
        }

        private void IC02_Enter(object sender, EventArgs e)
        {
            IC02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IC02);
            IC02.SelectAll();
        }

        private void IC03_Enter(object sender, EventArgs e)
        {
            IC03.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IC03);
            IC03.SelectAll();
        }

        private void IC04_Enter(object sender, EventArgs e)
        {
            IC04.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IC04);
            IC04.SelectAll();
        }

        private void IC05_Enter(object sender, EventArgs e)
        {
            IC05.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IC05);
            IC05.SelectAll();
        }

        private void ID01_Enter(object sender, EventArgs e)
        {
            ID01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_ID01);
            ID01.SelectAll();
        }

        private void ID02_Enter(object sender, EventArgs e)
        {
            ID02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_ID02);
            ID02.SelectAll();
        }

        private void ID03_Enter(object sender, EventArgs e)
        {
            ID03.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_ID03);
            ID03.SelectAll();
        }

        private void ID04_Enter(object sender, EventArgs e)
        {
            ID04.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_ID04);
            ID04.SelectAll();
        }

        private void IE01_Enter(object sender, EventArgs e)
        {
            IE01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IE01);
            IE01.SelectAll();
        }

        private void IE02_Enter(object sender, EventArgs e)
        {
            IE02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IE02);
            IE02.SelectAll();
        }

        private void IE03_Enter(object sender, EventArgs e)
        {
            IE03.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IE03);
            IE03.SelectAll();
        }

        private void IE04_Enter(object sender, EventArgs e)
        {
            IE04.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IE04);
            IE04.SelectAll();
        }

        private void IE08_Enter(object sender, EventArgs e)
        {
            IE08.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IE08);
            IE08.SelectAll();
        }

        private void IE09_Enter(object sender, EventArgs e)
        {
            IE09.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IE09);
            IE09.SelectAll();
        }

        private void IF01_Enter(object sender, EventArgs e)
        {
            IF01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IF01);
            IF01.SelectAll();
        }

        private void IF02_Enter(object sender, EventArgs e)
        {
            IF02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IF02);
            IF02.SelectAll();
        }

        private void IF03_Enter(object sender, EventArgs e)
        {
            IF03.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IF03);
            IF03.SelectAll();
        }

        private void IF04_Enter(object sender, EventArgs e)
        {
            IF04.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IF04);
            IF04.SelectAll();
        }

        private void IG01_Enter(object sender, EventArgs e)
        {
            IG01.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG01);
            IG01.SelectAll();
        }

        private void IG02_Enter(object sender, EventArgs e)
        {
            IG02.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG02);
            IG02.SelectAll();
        }

        private void IG03Title_Enter(object sender, EventArgs e)
        {
            IG03Title.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG03Title);
            IG03Title.SelectAll();
        }

        private void IG0301_Enter(object sender, EventArgs e)
        {
            IG0301.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0301);
            IG0301.SelectAll();
        }

        private void IG0302_Enter(object sender, EventArgs e)
        {
            IG0302.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0302);
            IG0302.SelectAll();
        }

        private void IG0303_Enter(object sender, EventArgs e)
        {
            IG0303.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0303);
            IG0303.SelectAll();
        }

        private void IG0304_Enter(object sender, EventArgs e)
        {
            IG0304.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0304);
            IG0304.SelectAll();
        }

        private void IG0305_Enter(object sender, EventArgs e)
        {
            IG0305.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0305);
            IG0305.SelectAll();
        }

        private void IG0306_Enter(object sender, EventArgs e)
        {
            IG0306.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0306);
            IG0306.SelectAll();
        }

        private void IG0307_Enter(object sender, EventArgs e)
        {
            IG0307.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0307);
            IG0307.SelectAll();
        }

        private void IG0308_Enter(object sender, EventArgs e)
        {
            IG0308.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0308);
            IG0308.SelectAll();
        }

        private void IG0309_Enter(object sender, EventArgs e)
        {
            IG0309.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG0309);
            IG0309.SelectAll();
        }

        private void IG03010_Enter(object sender, EventArgs e)
        {
            IG03010.BackColor = Color.Aqua;
            ChangeColorLabel(1, lbl_IG03010);
            IG03010.SelectAll();
        }

        private void SearchRecord()
        {
            DataSet ds = null;
            CDBOperations obj_op = null;

            try
            {
                ds = new DataSet();

                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    obj_op = new CDBOperations();
                    ds = obj_op.GetFormData("select * from formbl where formid='" + FORM_ID.Text, "0", FORM_ID.Text);
                }
                else if (CVariables.IsUserFirstOrSecond == "User2")
                {
                    obj_op = new CDBOperations();
                    ds = obj_op.GetFormData("select * from formbl where formid='" + FORM_ID.Text, "1", FORM_ID.Text);
                }


                maskedTextBox1.Text = "";
                cmdDelete.Visible = false;


                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            IsSearch = true;
                            IsUpdate = true;


                            if (CVariables.IsAdmin == false)
                            {
                                cmdDelete.Visible = false;
                            }
                            else
                            {
                                cmdDelete.Visible = true;
                            }


                            if (ds.Tables[0].Rows[0]["FORM_ID"].ToString() == null)
                            {
                                maskedTextBox1.Text = "";
                            }
                            else
                            {
                                maskedTextBox1.Text = ds.Tables[0].Rows[0]["FORM_ID"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IA01"].ToString() == null)
                            {
                                IA01.Text = "";
                            }
                            else
                            {
                                IA01.Text = ds.Tables[0].Rows[0]["IA01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IA02"].ToString() == null)
                            {
                                IA02.Text = "";
                            }
                            else
                            {
                                IA02.Text = ds.Tables[0].Rows[0]["IA02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IA03"].ToString() == null)
                            {
                                IA03.Text = "";
                            }
                            else
                            {
                                IA03.Text = ds.Tables[0].Rows[0]["IA03"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IA04"].ToString() == null)
                            {
                                IA04.Text = "";
                            }
                            else
                            {
                                IA04.Text = ds.Tables[0].Rows[0]["IA04"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IA05"].ToString() == null)
                            {
                                IA05.Text = "";
                            }
                            else
                            {
                                IA05.Text = ds.Tables[0].Rows[0]["IA05"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB01"].ToString() == null)
                            {
                                IB01.Text = "";
                            }
                            else
                            {
                                IB01.Text = ds.Tables[0].Rows[0]["IB01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB02"].ToString() == null)
                            {
                                IB02.Text = "";
                            }
                            else
                            {
                                IB02.Text = ds.Tables[0].Rows[0]["IB02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB03"].ToString() == null)
                            {
                                IB03.Text = "";
                            }
                            else
                            {
                                IB03.Text = ds.Tables[0].Rows[0]["IB03"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB04"].ToString() == null)
                            {
                                IB04.Text = "";
                            }
                            else
                            {
                                IB04.Text = ds.Tables[0].Rows[0]["IB04"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB05"].ToString() == null)
                            {
                                IB05.Text = "";
                            }
                            else
                            {
                                IB05.Text = ds.Tables[0].Rows[0]["IB05"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB06"].ToString() == null)
                            {
                                IB06.Text = "";
                            }
                            else
                            {
                                IB06.Text = ds.Tables[0].Rows[0]["IB06"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB07"].ToString() == null)
                            {
                                IB07.Text = "";
                            }
                            else
                            {
                                IB07.Text = ds.Tables[0].Rows[0]["IB07"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB08"].ToString() == null)
                            {
                                IB08.Text = "";
                            }
                            else
                            {
                                IB08.Text = ds.Tables[0].Rows[0]["IB08"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB09"].ToString() == null)
                            {
                                IB09.Text = "";
                            }
                            else
                            {
                                IB09.Text = ds.Tables[0].Rows[0]["IB09"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB0901"].ToString() == null)
                            {
                                IB0901.Text = "";
                            }
                            else
                            {
                                IB0901.Text = ds.Tables[0].Rows[0]["IB0901"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB0902"].ToString() == null)
                            {
                                IB0902.Text = "";
                            }
                            else
                            {
                                IB0902.Text = ds.Tables[0].Rows[0]["IB0902"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB0903"].ToString() == null)
                            {
                                IB0903.Text = "";
                            }
                            else
                            {
                                IB0903.Text = ds.Tables[0].Rows[0]["IB0903"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IB0996"].ToString() == null)
                            {
                                IB0996.Text = "";
                            }
                            else
                            {
                                IB0996.Text = ds.Tables[0].Rows[0]["IB0996"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IC01"].ToString() == null)
                            {
                                IC01.Text = "";
                            }
                            else
                            {
                                IC01.Text = ds.Tables[0].Rows[0]["IC01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IC02"].ToString() == null)
                            {
                                IC02.Text = "";
                            }
                            else
                            {
                                IC02.Text = ds.Tables[0].Rows[0]["IC02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IC03"].ToString() == null)
                            {
                                IC03.Text = "";
                            }
                            else
                            {
                                IC03.Text = ds.Tables[0].Rows[0]["IC03"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IC04"].ToString() == null)
                            {
                                IC04.Text = "";
                            }
                            else
                            {
                                IC04.Text = ds.Tables[0].Rows[0]["IC04"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IC05"].ToString() == null)
                            {
                                IC05.Text = "";
                            }
                            else
                            {
                                IC05.Text = ds.Tables[0].Rows[0]["IC05"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["ID01"].ToString() == null)
                            {
                                ID01.Text = "";
                            }
                            else
                            {
                                ID01.Text = ds.Tables[0].Rows[0]["ID01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["ID02"].ToString() == null)
                            {
                                ID02.Text = "";
                            }
                            else
                            {
                                ID02.Text = ds.Tables[0].Rows[0]["ID02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["ID03"].ToString() == null)
                            {
                                ID03.Text = "";
                            }
                            else
                            {
                                ID03.Text = ds.Tables[0].Rows[0]["ID03"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["ID04"].ToString() == null)
                            {
                                ID04.Text = "";
                            }
                            else
                            {
                                ID04.Text = ds.Tables[0].Rows[0]["ID04"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IE01"].ToString() == null)
                            {
                                IE01.Text = "";
                            }
                            else
                            {
                                IE01.Text = ds.Tables[0].Rows[0]["IE01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IE02"].ToString() == null)
                            {
                                IE02.Text = "";
                            }
                            else
                            {
                                IE02.Text = ds.Tables[0].Rows[0]["IE02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IE03"].ToString() == null)
                            {
                                IE03.Text = "";
                            }
                            else
                            {
                                IE03.Text = ds.Tables[0].Rows[0]["IE03"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IE04"].ToString() == null)
                            {
                                IE04.Text = "";
                            }
                            else
                            {
                                IE04.Text = ds.Tables[0].Rows[0]["IE04"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IE08"].ToString() == null)
                            {
                                IE08.Text = "";
                            }
                            else
                            {
                                IE08.Text = ds.Tables[0].Rows[0]["IE08"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IE09"].ToString() == null)
                            {
                                IE09.Text = "";
                            }
                            else
                            {
                                IE09.Text = ds.Tables[0].Rows[0]["IE09"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IF01"].ToString() == null)
                            {
                                IF01.Text = "";
                            }
                            else
                            {
                                IF01.Text = ds.Tables[0].Rows[0]["IF01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IF02"].ToString() == null)
                            {
                                IF02.Text = "";
                            }
                            else
                            {
                                IF02.Text = ds.Tables[0].Rows[0]["IF02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IF03"].ToString() == null)
                            {
                                IF03.Text = "";
                            }
                            else
                            {
                                IF03.Text = ds.Tables[0].Rows[0]["IF03"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IF04"].ToString() == null)
                            {
                                IF04.Text = "";
                            }
                            else
                            {
                                IF04.Text = ds.Tables[0].Rows[0]["IF04"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG01"].ToString() == null)
                            {
                                IG01.Text = "";
                            }
                            else
                            {
                                IG01.Text = ds.Tables[0].Rows[0]["IG01"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG02"].ToString() == null)
                            {
                                IG02.Text = "";
                            }
                            else
                            {
                                IG02.Text = ds.Tables[0].Rows[0]["IG02"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG03Title"].ToString() == null)
                            {
                                IG03Title.Text = "";
                            }
                            else
                            {
                                IG03Title.Text = ds.Tables[0].Rows[0]["IG03Title"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0301"].ToString() == null)
                            {
                                IG0301.Text = "";
                            }
                            else
                            {
                                IG0301.Text = ds.Tables[0].Rows[0]["IG0301"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0302"].ToString() == null)
                            {
                                IG0302.Text = "";
                            }
                            else
                            {
                                IG0302.Text = ds.Tables[0].Rows[0]["IG0302"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0303"].ToString() == null)
                            {
                                IG0303.Text = "";
                            }
                            else
                            {
                                IG0303.Text = ds.Tables[0].Rows[0]["IG0303"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0304"].ToString() == null)
                            {
                                IG0304.Text = "";
                            }
                            else
                            {
                                IG0304.Text = ds.Tables[0].Rows[0]["IG0304"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0305"].ToString() == null)
                            {
                                IG0305.Text = "";
                            }
                            else
                            {
                                IG0305.Text = ds.Tables[0].Rows[0]["IG0305"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0306"].ToString() == null)
                            {
                                IG0306.Text = "";
                            }
                            else
                            {
                                IG0306.Text = ds.Tables[0].Rows[0]["IG0306"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0307"].ToString() == null)
                            {
                                IG0307.Text = "";
                            }
                            else
                            {
                                IG0307.Text = ds.Tables[0].Rows[0]["IG0307"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0308"].ToString() == null)
                            {
                                IG0308.Text = "";
                            }
                            else
                            {
                                IG0308.Text = ds.Tables[0].Rows[0]["IG0308"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG0309"].ToString() == null)
                            {
                                IG0309.Text = "";
                            }
                            else
                            {
                                IG0309.Text = ds.Tables[0].Rows[0]["IG0309"].ToString();
                            }

                            if (ds.Tables[0].Rows[0]["IG03010"].ToString() == null)
                            {
                                IG03010.Text = "";
                            }
                            else
                            {
                                IG03010.Text = ds.Tables[0].Rows[0]["IG03010"].ToString();
                            }

                            IsSearch = false;
                        }
                        else
                        {
                            IsSearch = false;
                        }
                    }
                    else
                    {
                        IsSearch = false;
                    }
                }
                else
                {
                    IsSearch = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Form No is numeric field ", "Data Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ds = null;
                obj_op = null;
            }
        }

        private void IsValidate(string value1, Control txtbox1, Control txtbox2, Control txtbox3)
        {
            if (value1 == "")
            {
                //txtbox1.Focus();	 
            }
            else
            {
                if (value1 != "1" && value1 != "2")
                {
                    MessageBox.Show("Invalid digit entered. Please enter any digit 1-2", "Invalid Digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox1.Focus();
                }
                else
                {
                    if (value1 == "1")
                    {
                        txtbox2.Enabled = false;
                        txtbox3.Focus();
                    }
                    else
                    {
                        txtbox2.Enabled = true;
                        txtbox2.Focus();
                    }
                }
            }

            txtbox1 = null;
            txtbox2 = null;
            txtbox3 = null;
        }

        private void IsValidate(string value1, Control txtbox1, Control txtbox2)
        {
            if (value1 == "")
            {
                //txtbox1.Focus();	 
            }
            else
            {
                if (value1 != "1" && value1 != "2")
                {
                    MessageBox.Show("Invalid digit entered. Please enter any digit 1-2", "Invalid Digit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox1.Focus();
                }
                else
                {

                }
            }

            txtbox1 = null;
            txtbox2 = null;
        }

        private bool IsRecordExists(string fieldValue, string id)
        {
            bool IsExists = false;
            CDBOperations obj_op = null;

            try
            {
                string[] fldname = { "FORM_ID", "fldvalue" };
                string[] fldvalue = { fieldValue.ToString(), id.ToString() };

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



        private bool DeleteForm1(string spName, string id)
        {
            bool IsSuccess = false;

            CDBOperations obj_op = null;

            try
            {
                if (FORM_ID.Text != "")
                {
                    obj_op = new CDBOperations();
                    DataSet ds = obj_op.DeleteForm1(FORM_ID.Text, spName, id, "");
                    IsSuccess = true;
                }
                else
                {
                    MessageBox.Show("Form No is missing", "Missing Form No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FORM_ID.Focus();
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

            return IsSuccess;
        }

        private void EnableDisableForms(bool IsEnable)
        {
            if (IsEnable == true)
            {
                CVariables.EnableDisableEnrollment.Visible = true;
                CVariables.EnableDisableFollowup.Visible = true;
                CVariables.EnableDisableLabForm.Visible = true;
                CVariables.EnableDisableRandomisation.Visible = true;
                CVariables.EnableDisableReconfirmEligibility.Visible = true;
                CVariables.EnableDisableArms.Visible = true;
            }
            else
            {
                CVariables.EnableDisableEnrollment.Visible = false;
                CVariables.EnableDisableFollowup.Visible = false;
                CVariables.EnableDisableLabForm.Visible = false;
                CVariables.EnableDisableRandomisation.Visible = false;
                CVariables.EnableDisableReconfirmEligibility.Visible = false;
                CVariables.EnableDisableArms.Visible = false;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to cancel this entry ?", "Cancel Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to delete this entry ?", "Delete Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                if (CVariables.IsUserFirstOrSecond == "User1")
                {
                    DeleteForm1("sp_GetRecords", "4");
                    this.Close();
                }
                else if (CVariables.IsUserFirstOrSecond == "User2")
                {
                    DeleteForm1("sp_GetRecords", "6");
                    this.Close();
                }
            }
        }

        private void ClearFields()
        {
            IA01.Text = "";
            IA02.Text = "";
            IA03.Text = "";
            IA04.Text = "";
            IA05.Text = "";
            IB01.Text = "";
            IB02.Text = "";
            IB03.Text = "";
            IB04.Text = "";
            IB05.Text = "";
            IB06.Text = "";
            IB07.Text = "";
            IB08.Text = "";
            IB09.Text = "";
            IB0901.Text = "";
            IB0902.Text = "";
            IB0903.Text = "";
            IB0996.Text = "";
            IC01.Text = "";
            IC02.Text = "";
            IC03.Text = "";
            IC04.Text = "";
            IC05.Text = "";
            ID01.Text = "";
            ID02.Text = "";
            ID03.Text = "";
            ID04.Text = "";
            IE01.Text = "";
            IE02.Text = "";
            IE03.Text = "";
            IE04.Text = "";
            IE08.Text = "";
            IE09.Text = "";
            IF01.Text = "";
            IF02.Text = "";
            IF03.Text = "";
            IF04.Text = "";
            IG01.Text = "";
            IG02.Text = "";
            IG0301.Text = "";
            IG0302.Text = "";
            IG0303.Text = "";
            IG0304.Text = "";
            IG0305.Text = "";
            IG0306.Text = "";
            IG0307.Text = "";
            IG0308.Text = "";
            IG0309.Text = "";
            IG03010.Text = "";
        }


        private void AddUpdatePage(string spName)
        {
            string[] my_dt;


            CDBOperations obj_op = null;
            string form_id = null;

            try
            {
                my_dt = DateTime.Now.Date.ToString().Split('/');

                DateTime EntryDate = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                EntryDate = Convert.ToDateTime(DateTime.Now.Date);


                DateTime dt_IB04 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt_IB04 = Convert.ToDateTime(IB04.Text);


                if (maskedTextBox1.Text == "")
                {
                    form_id = FORM_ID.Text;
                }
                else
                {
                    form_id = maskedTextBox1.Text;
                }

                string[] fldname = { };
                string[] fldvalue = { };

                //string[] fldname = { "FORM_ID", "IA01", "IA02", "IA03", "IA04", "IA05", "IB01", "IB02", "IB03", "IB04", "IB05", "IB06", "IB07", "IB08", "IB09", "IB0901", "IB0902", "IB0903", "IB0996", "IC01", "IC02", "IC03", "IC04", "IC05", "ID01", "ID02", "ID03", "ID04", "IE01", "IE02", "IE03", "IE04", "IE08", "IE09", "IF01", "IF02", "IF03", "IF04", "IG01", "IG02", "IG03Title", "IG0301", "IG0302", "IG0303", "IG0304", "IG0305", "IG0306", "IG0307", "IG0308", "IG0309", "IG03010", "entrydate", "username" };
                //string[] fldvalue = { form_id, IA01.Text, IA02.Text, IA03.Text, IA04.Text, IA05.Text, IB01.Text, IB02.Text, IB03.Text, IB04.Text, IB05.Text, IB06.Text, IB07.Text, IB08.Text, IB09.Text, IB0901.Text, IB0902.Text, IB0903.Text, IB0996.Text, IC01.Text, IC02.Text, IC03.Text, IC04.Text, IC05.Text, ID01.Text, ID02.Text, ID03.Text, ID04.Text, IE01.Text, IE02.Text, IE03.Text, IE04.Text, IE08.Text, IE09.Text, IF01.Text, IF02.Text, IF03.Text, IF04.Text, IG01.Text, IG02.Text, IG03Title.Text, IG0301.Text, IG0302.Text, IG0303.Text, IG0304.Text, IG0305.Text, IG0306.Text, IG0307.Text, IG0308.Text, IG0309.Text, IG03010.Text, EntryDate.ToShortDateString(), CVariables.UserName };

                string qry = "INSERT INTO formbl (formid, IA01, IA02, IA03, IA04, IA05, IB01, IB02, IB03, IB04, IB05, IB06, IB07, IB08, IB09, IB0901, IB0902, IB0903, IB0996, IC01, IC02, IC03, IC04, IC05, ID01, ID02, ID03, ID04, IE01, IE02, IE03, IE04, IE08, IE09, IF01, IF02, IF03, IF04, IG01, IG02, IG03Title, IG0301, IG0302, IG0303, IG0304, IG0305, IG0306, IG0307, IG0308, IG0309, IG03010, entrydate, username) values('" +
                   form_id + "', '" + IA01.Text + "', '" + IA02.Text + "', '" + IA03.Text + "', '" + IA04.Text + "', '" + IA05.Text + "', '" + IB01.Text + "', '" + IB02.Text + "', '" + IB03.Text + "', '" + dt_IB04.ToShortDateString() + "', '" + IB05.Text + "', '" + IB06.Text + "', '" + IB07.Text + "', '" + IB08.Text + "', '" + IB09.Text + "', '" + IB0901.Text + "', '" + IB0902.Text + "', '" + IB0903.Text + "', '" + IB0996.Text + "', '" + IC01.Text + "', '" + IC02.Text + "', '" + IC03.Text + "', '" + IC04.Text + "', '" + IC05.Text + "', '" + ID01.Text + "', '" + ID02.Text + "', '" + ID03.Text + "', '" + ID04.Text + "', '" + IE01.Text + "', '" + IE02.Text + "', '" + IE03.Text + "', '" + IE04.Text + "', '" + IE08.Text + "', '" + IE09.Text + "', '" + IF01.Text + "', '" + IF02.Text + "', '" + IF03.Text + "', '" + IF04.Text + "', '" + IG01.Text + "', '" + IG02.Text + "', '" + IG03Title.Text + "', '" + IG0301.Text + "', '" + IG0302.Text + "', '" + IG0303.Text + "', '" + IG0304.Text + "', '" + IG0305.Text + "', '" + IG0306.Text + "', '" + IG0307.Text + "', '" + IG0308.Text + "', '" + IG0309.Text + "', '" + IG03010.Text + "', '" + EntryDate.ToShortDateString() + "', '" + CVariables.UserName + "')";

                obj_op = new CDBOperations();
                obj_op.ExecuteNonQuery(fldname, fldvalue, qry);

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

        private void FORM_ID_Leave(object sender, EventArgs e)
        {
            if (FORM_ID.Text.IndexOf(" ") == -1)
            {
                if (FORM_ID.Text != "0000000")
                {


                    CDBOperations obj_op = new CDBOperations();

                    try
                    {
                        if (obj_op.Validate_Dictionary("0", "select * from tbldict ", " where tabname = 'Form1BL' and var_id = 'FORM_ID' ", FORM_ID.Text) == true)
                        {
                            FORM_ID.Focus();
                        }
                        else
                        {
                            COMP_ID.Text = Convert.ToString(Convert.ToInt32(FORM_ID.Text) * 100);
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
                else
                {
                    ClearFields();
                    cmdSave.Visible = false;
                    cmdDelete.Visible = false;
                }
            }
            else
            {
                ClearFields();
                MessageBox.Show("Form ID does not any space or any other character except numeric digits ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                FORM_ID.Focus();
            }

            FORM_ID.BackColor = Color.White;
            ChangeColorLabel(0, lbl_FORM_ID);
        }



        private void SaveData()
        {
            CDBOperations obj_op = new CDBOperations();

            try
            {
                comp_name = SystemInformation.ComputerName;
                user_name = SystemInformation.UserName;


                if (CVariables.dualisperforming == true)
                {

                    if (CVariables.dual_whichentry == "3rd Entry")
                    {

                        if (IsUpdate1 == true)
                        {
                            //AuditTrials("sp_AddAuditTrials");
                        }

                        AddUpdatePage("sp_Form2");

                    }
                    else if (CVariables.dual_whichentry == "3rd Entry(2nd)")
                    {

                        if (IsUpdate1 == true)
                        {
                            //AuditTrials("sp_AddAuditTrialsx");
                        }

                        AddUpdatePage("sp_Form2x");

                    }

                }
                else
                {

                    if (CVariables.IsUserFirstOrSecond == "User1")
                    {
                        if (IsUpdate1 == true)
                        {
                            //AuditTrials("sp_AddAuditTrials");
                        }

                        AddUpdatePage("sp_Form2");
                    }
                    else
                    {
                        if (IsUpdate1 == true)
                        {
                            //AuditTrials("sp_AddAuditTrialsx");
                        }

                        AddUpdatePage("sp_Form2x");
                    }


                }




                GetTotalForms();


                if (CVariables.dualisperforming == true && CVariables.dual_whichentry != "3rd Entry")
                {
                    CVariables.dualisupdate = false;
                    CVariables.dual_normal_update = true;
                    CVariables.dual_whichentry = "";
                    CVariables.dualformname = "";
                    CVariables.dualvisitid = "";
                    CVariables.dual_form_id = "";
                    CVariables.IsUserFirstOrSecond = "User1";

                    this.Close();

                    CVariables.dual_form_show_hide.Show();
                }
                else if (CVariables.dualisperforming == true && CVariables.dual_whichentry == "3rd Entry")
                {

                    CVariables.dual_whichentry = "3rd Entry(2nd)";

                    IsSearch = true;
                    IsError = true;

                    tabControl1.SelectedIndex = 0;
                    ClearFields();

                    FORM_ID.Text = CVariables.dual_form_id;
                    SearchRecord();

                    FORM_ID.Focus();

                    IsError = false;
                    IsSearch = false;

                }
                else
                {

                    if (CVariables.IsSuccess == true)
                    {
                        IsSearch = true;
                        IsError = true;

                        tabControl1.SelectedIndex = 0;
                        ClearFields();

                        FORM_ID.Text = "";
                        FORM_ID.Focus();

                        IsError = false;
                        IsSearch = false;
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

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }


        private void GetTotalForms()
        {
            CDBOperations obj_op = null;
            CConnection cn = new CConnection();


            try
            {
                obj_op = new CDBOperations();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select count(*) count1 from FormBL", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["count1"].ToString() == "0")
                        {
                            label51.Text = "1";
                        }
                        else
                        {
                            label51.Text = ds.Tables[0].Rows[0]["count1"].ToString();
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

        private void Form1BL_Load(object sender, EventArgs e)
        {
            GetTotalForms();


            if (CVariables.dualisperforming == true)
            {
                CVariables.dual_normal_update = false;

                this.Text = this.Text + "  -  Performing dual entry - " + CVariables.dual_whichentry;

                FORM_ID.Text = CVariables.dual_form_id;

                FORM_ID.Enabled = false;
                FORM_ID.BackColor = Color.LightGray;

                SearchRecord();
                //DisableAllControls();

                FORM_ID.Focus();
            }
            else
            {
                CVariables.dual_normal_update = true;
                CVariables.dualisupdate = false;
            }
        }

        private void Form1BL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Form1BL_Shown(object sender, EventArgs e)
        {
            FORM_ID.Focus();
        }
    }
}