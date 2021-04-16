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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval >= 2500)
            {
                timer1.Stop();
                timer1.Enabled = false;

                progressBar1.Maximum = 100;

                this.Hide();

                frmLogin frm = new frmLogin();
                frm.Show();
            }
            else
            {
                timer1.Interval += 500;
                progressBar1.Value += 30;
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            label2.Text = CVariables.AppName1;

            timer1.Start();
            timer1.Enabled = true;
        }
    }
}
