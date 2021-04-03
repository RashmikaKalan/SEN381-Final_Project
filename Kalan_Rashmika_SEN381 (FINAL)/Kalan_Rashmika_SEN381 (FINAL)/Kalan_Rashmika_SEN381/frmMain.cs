using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientMain clientMain = new frmClientMain();
                clientMain.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductMain productMain = new frmProductMain();
                productMain.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnTechnical_Click(object sender, EventArgs e)
        {
            try
            {
                frmTechnicalMain technicalMain = new frmTechnicalMain();
                technicalMain.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.Authorisation == 2)
                {
                    btnClient.Enabled = false;
                    btnTechnical.Enabled = false;
                }
                else if (frmLogin.Authorisation == 3)
                {
                    btnTechnical.Enabled = false;
                    btnProduct.Enabled = false;
                }
                else if (frmLogin.Authorisation >= 4)
                {
                    btnProduct.Enabled = false;
                    btnClient.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
