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
    public partial class frmPurchaseSearch : Form
    {
        public delegate void Del(object sender, EventArgs e);

        public frmPurchaseSearch()
        {
            InitializeComponent();
            Del search = new Del(SearchClick);
            btnSearch.Click += new EventHandler(search);
        }

        private void SearchClick(object sender, EventArgs e)
        {
            try
            {
                List<Client> clients = Client.GetClients();
                Client search = new Client();
                if (User.ValidID(txtIDNum.Text) == true)
                {
                    if (clients.Any(client => client.IDNum == txtIDNum.Text))
                    {
                        this.Size = new Size(812, 331);
                        List<Subscriptions> dt = Subscriptions.GetClientSubs(txtIDNum.Text);
                        dgvResult.DataSource = dt;
                        dgvResult.Columns["Cost"].DefaultCellStyle.Format = "c";
                        dgvResult.Columns["ID"].Visible = false;
                        dgvResult.Columns["ProdID"].Visible = false;
                        dgvResult.Columns["ClientName"].DisplayIndex = 1;
                        dgvResult.Columns["ProdName"].DisplayIndex = 2;
                        dgvResult.Columns["Version"].DisplayIndex = 3;
                        dgvResult.Columns["Cost"].DisplayIndex = 4;
                        dgvResult.Columns["Date"].DisplayIndex = 5;
                        dgvResult.Columns["ClientID"].DisplayIndex = 0;
                    }
                    else
                    {
                        throw new Exception("Client Does Not Exist");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPurchaseSearch_Load(object sender, EventArgs e)
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
                frmClientPurchaseMain frp = new frmClientPurchaseMain();
                frp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        #region Double Clicks
        private void gbxResults_Enter(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
