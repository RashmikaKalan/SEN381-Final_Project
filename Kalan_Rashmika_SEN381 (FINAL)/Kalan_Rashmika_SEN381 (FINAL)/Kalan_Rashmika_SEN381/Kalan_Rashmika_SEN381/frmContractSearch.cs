using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmContractSearch : Form
    {
        public frmContractSearch()
        {
            InitializeComponent();
        }

        public void SearchConID(object sender, EventArgs e)
        {
            try
            {
                Contracts contracts = new Contracts();
                Contracts search = new Contracts();
                List<Contracts> con = contracts.GetContracts();
                if (con.Any(cont=>cont.ID==txtConID.Text))
                {
                    search = con.Find(cont => cont.ID == txtConID.Text);

                }
                else
                {
                    throw new Exception("Contract with that ID does not exist.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmContractSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
