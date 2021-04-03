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
    public partial class frmRemovePurchase : Form
    {
        public delegate void Del(object sender, EventArgs e);
        Product prod = new Product();   

        public frmRemovePurchase()
        {
            InitializeComponent();
            Del systems = new Del(SystemsClick);
            btnSystems.Click += new EventHandler(systems);
            Del remove = new Del(RemoveClick);
            btnDelete.Click += new EventHandler(remove);
        }

        private void SystemsClick(object sender, EventArgs e)
        {
            try
            {
                List<Client> clients = Client.GetClients();
                Client search = new Client();
                if (clients.Any(client => client.IDNum == txtIDNum.Text))
                {
                    search = clients.Find(client => client.IDNum == txtIDNum.Text);
                    List<Subscriptions> subs = Subscriptions.GetSubs();
                    List<Subscriptions> clientsubs = new List<Subscriptions>();
                    foreach (var item in subs)
                    {
                        if (item.ClientID==search.ID)
                        {
                            clientsubs.Add(new Subscriptions(item.ClientID, search.FirstName, item.ProdName, item.Version, item.Cost, item.Date, item.SerialNumber));
                        }
                    }
                    BindingSource bs = new BindingSource();
                    bs.DataSource = clientsubs;
                    cbSystem.DataSource = bs;
                    cbSystem.DisplayMember = "ProdName";
                }
                else
                {
                    throw new Exception("Client Does Not Exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveClick(object sender, EventArgs e)
        {
            try
            {
                List<Client> clients = Client.GetClients();
                Client search = new Client();
                if (string.IsNullOrEmpty(txtIDNum.Text))
                {
                    throw new Exception("No ID Was Entered.");
                }
                else if (clients.Any(client => client.IDNum == txtIDNum.Text))
                {
                    search = clients.Find(client => client.IDNum == txtIDNum.Text);
                }
                else
                {
                    throw new Exception("Client Does Not Exist.");
                }

                IProduct product = prod;
                string name = cbSystem.GetItemText(cbSystem.SelectedItem);
                List<Product> products = product.GetProducts();
                List<string> purchased = new List<string>();
                string code = "";

                foreach (var item in products)
                {
                    if (item.Name == name)
                    {
                        code = item.ProdID;
                        break;
                    }
                }

                int subID = 0;
                List<Subscriptions> subscriptions = Subscriptions.GetSubscriptions();
                foreach (var item in subscriptions)
                {
                    if (item.ClientID==search.ID && item.ProdID==code)
                    {
                        subID = item.ID;
                        break;
                    }
                }

                Subscriptions.RemoveSub(search.ID, code, subID);
                DialogResult r = MessageBox.Show("Purchase Removed.", "Remove Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (r == DialogResult.OK)
                {
                    txtIDNum.Clear();
                    frmClientPurchaseMain frm = new frmClientPurchaseMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Client Has No Purchases");
                }
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
        private void cbSystem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }              


        private void frmRemovePurchase_Load(object sender, EventArgs e)
        {

        }
        #endregion

      
    }
}
