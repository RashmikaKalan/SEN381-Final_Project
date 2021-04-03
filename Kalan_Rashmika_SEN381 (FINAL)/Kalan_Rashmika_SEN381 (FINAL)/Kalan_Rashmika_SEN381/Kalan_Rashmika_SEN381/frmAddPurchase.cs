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
    public partial class frmAddPurchase : Form
    {
        public delegate void Del(object sender, EventArgs e);
        Product product = new Product();
        AddOns add = new AddOns();
        Contracts con = new Contracts();
        MonthlyBilling bill = new MonthlyBilling();

        public frmAddPurchase()
        {
            InitializeComponent();
            Del add = new Del(AddClick);
            Del change = new Del(ProdInfo);
            btnAddPurchase.Click += new EventHandler(add);
            cbSystem.SelectedIndexChanged += new EventHandler(change);
        }

        private void AddClick(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                AddOns add = new AddOns();
                Contracts con = new Contracts();
                MonthlyBilling bill = new MonthlyBilling();
                Random newR = new Random();
                int days = newR.Next(1, 7);
                List<Client> clients = Client.GetClients();
                List<Product> products = product.GetProducts();
                string code = cbSystem.GetItemText(cbSystem.SelectedItem);             

                string prodID = "";
                string version = "";

                foreach (var item in products)
                {
                    if (item.Name == code)
                    {
                        prodID = item.ProdID;
                        version = item.Version;
                        break;
                    }
                }

                if (User.ValidID(txtID.Text) == true)
                {
                    if (clients.Any(client => client.IDNum == txtID.Text))
                    {
                        foreach (var person in clients)
                        {
                            if (person.IDNum == txtID.Text)
                            {
                                List<Subscriptions> subs = Subscriptions.GetSubscriptions();
                                foreach (var item in subs)
                                {
                                    if (person.ID == item.ClientID && item.Date.Year==DateTime.Now.Year)
                                    {
                                        if (prodID == item.ProdID)
                                        {
                                            throw new Exception("Client already has a contract subscription for this year for the selected product.");
                                        }
                                    }
                                }

                                List<AddOns> addOns = add.GetAddOns();   
                                double total = double.Parse(txtCost.Text);
                                if (cbSensor.Checked == true)
                                {
                                    total = total + (addOns[0].Cost * double.Parse(nudSensor.Value.ToString()));
                                }
                                if (cbActor.Checked == true)
                                {
                                    total = total + (addOns[1].Cost * double.Parse(nudActor.Value.ToString()));
                                }
                                if (cbController.Checked == true)
                                {
                                    total = total + (addOns[2].Cost * double.Parse(nudController.Value.ToString()));
                                }                            

                                Subscriptions subscription = new Subscriptions(2, person.ID, prodID, version, total, DateTime.Now);
                                txtCost.Text = total.ToString();
                                Subscriptions.AddSub(subscription);

                                List<Subscriptions> newsubs = Subscriptions.GetSubscriptions();
                                int subid = 0;
                                foreach (var item in newsubs)
                                {
                                    if (item.ClientID==person.ID && item.ProdID==prodID)
                                    {
                                        subid = item.ID;
                                        if (cbSensor.Checked == true)
                                        {
                                            add.ClientAddOns(person.ID, addOns[0].ID, item.ID, int.Parse(nudSensor.Value.ToString()));
                                        }
                                        if (cbActor.Checked == true)
                                        {
                                            add.ClientAddOns(person.ID, addOns[1].ID, item.ID, int.Parse(nudActor.Value.ToString()));
                                        }
                                        if (cbController.Checked == true)
                                        {
                                            add.ClientAddOns(person.ID, addOns[2].ID, item.ID, int.Parse(nudController.Value.ToString()));
                                        }
                                    }
                                }
                                MonthlyBilling billing = new MonthlyBilling();
                                billing.ClientID = person.ID;
                                billing.Date = DateTime.Now;
                                billing.Amount = total;
                                billing.Month = DateTime.Now.ToString("MMMM");
                                billing.SubID = subid;
                                bill.NewBill(billing);

                                Contracts contract = new Contracts();
                                contract.ID = con.GenerateContractID(DateTime.Now.Year.ToString(), prodID, person.Importance);
                                MessageBox.Show(contract.ID);

                                contract.ClientID = person.ID;
                                contract.SubID = subid;
                                con.AddContract(contract);

                                DialogResult r = MessageBox.Show("Purchase Added. Total Cost Per Month: R" + total, "Add Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (r == DialogResult.OK)
                                {
                                    txtID.Clear();
                                    frmClientPurchaseMain frm = new frmClientPurchaseMain();
                                    frm.Show();
                                    this.Hide();
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Client does not exist");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProdInfo(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                string name = cbSystem.GetItemText(cbSystem.SelectedItem);
                List<Product> products = product.GetProducts();
                foreach (var item in products)
                {
                    if (item.Name == name)
                    {
                        txtCost.Text = item.Cost.ToString();
                        rtbDesc.Text = item.Desc;
                        break;
                    }
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

        private void frmAddPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                List<Product> products = product.GetProducts();
                BindingSource bs = new BindingSource();
                bs.DataSource = products;
                cbSystem.DataSource = bs;
                cbSystem.DisplayMember = "Name";
                cbSystem.ValueMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
