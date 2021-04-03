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
                        Client res = clients.Find(c => c.IDNum == txtIDNum.Text);
                        this.Size = new Size(812, 331);
                        List<Subscriptions> subs = Subscriptions.GetSubscriptions();
                        List<Subscriptions> clientsubs = new List<Subscriptions>();
                        foreach (var item in subs)
                        {
                            if (item.ClientID==res.ID)
                            {
                                clientsubs.Add(new Subscriptions(item.ID, res.ID, item.ProdID, item.Version, item.Cost, item.Date, item.SerialNumber));
                            }
                        }

                        lblCIDC.Text = res.ID;
                        lblClient.Text = string.Concat(res.FirstName + " " + res.LastName);
                        BindingSource bs = new BindingSource();
                        bs.DataSource = clientsubs;
                        dgvResult.DataSource = bs;
                        dgvResult.Columns["ClientName"].Visible = false;
                        dgvResult.Columns["ProdName"].Visible = false;
                        dgvResult.Columns["ClientID"].Visible = false;
                        dgvResult.Columns["Cost"].DefaultCellStyle.Format = "c";
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
