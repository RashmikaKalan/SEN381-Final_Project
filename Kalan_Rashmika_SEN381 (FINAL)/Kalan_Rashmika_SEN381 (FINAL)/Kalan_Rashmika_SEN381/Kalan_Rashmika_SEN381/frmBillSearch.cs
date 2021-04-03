using BusinessLayer;
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
    public partial class frmBillSearch : Form
    {
        public delegate void Del(object sender, EventArgs e);
        MonthlyBilling bill = new MonthlyBilling();

        public frmBillSearch()
        {
            InitializeComponent();
            Del search = new Del(SearchClick);
            btnSearch.Click += new EventHandler(search);
        }

        private void SearchClick(object sender, EventArgs e)
        {
            try
            {
                MonthlyBilling bill = new MonthlyBilling();
                List<Client> clients = Client.GetClients();
                if (string.IsNullOrEmpty(txtIDNum.Text))
                {
                    throw new Exception("No ID Number Was Entered.");
                }
                else if (User.ValidID(txtIDNum.Text) == true)
                {
                    if (clients.Any(client => client.IDNum == txtIDNum.Text))
                    {
                        this.Size = new Size(812, 331);
                        List<MonthlyBilling> dt = bill.GetClientBills(txtIDNum.Text);
                        dgvResult.DataSource = dt; 
                        dgvResult.Columns["Amount"].DefaultCellStyle.Format = "c";
                        dgvResult.Columns["ClientID"].Visible = false;
                        dgvResult.Columns["FirstName"].Visible = false;
                        dgvResult.Columns["LastName"].Visible = false;
                        dgvResult.Columns["SubID"].Visible = false;
                    }
                    else
                    {
                        throw new Exception("Client does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBillSearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(267, 331);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmBillsMain frb = new frmBillsMain();
                frb.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
