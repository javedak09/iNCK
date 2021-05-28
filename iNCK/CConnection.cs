using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SQLite;

namespace iNCK
{
    class CConnection
    {
        //public SqlConnection cn = null;
        public SQLiteConnection cn = null;

        public CConnection()
        {
            try
            {
                //cn = new SqlConnection(ConfigurationSettings.AppSettings["cnStr"]);
                cn = new SQLiteConnection(ConfigurationSettings.AppSettings["cnStr"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

            }
        }

        public void MConnOpen()
        {
            try
            {
                cn.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
            }
        }

        public void MConnClose()
        {
            try
            {
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
            }
        }
    }
}
