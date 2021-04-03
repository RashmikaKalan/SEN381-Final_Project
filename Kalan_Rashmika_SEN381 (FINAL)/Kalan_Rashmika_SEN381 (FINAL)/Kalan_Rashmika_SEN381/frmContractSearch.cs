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
        public delegate void Delegate(object sender, EventArgs e);
        Contracts contracts = new Contracts();
        Product prod = new Product();
        Manufacturer man = new Manufacturer();
        ProductTerms productTerms = new ProductTerms();
        ClientAddOns clientAdd = new ClientAddOns();
        AddOns adds = new AddOns();

        public frmContractSearch()
        {
            InitializeComponent();
            Delegate del = new Delegate(SearchConID);
            btnSearchCon.Click += new EventHandler(del);
            Delegate bdel = new Delegate(Back);
            btnBack.Click += new EventHandler(bdel);
            btnBackC.Click += new EventHandler(bdel);
            Delegate delclient = new Delegate(SearchClientID);
            btnSearch.Click += new EventHandler(delclient);
        }

        public string AddOnString(int subID)
        {
            ICAdd cAdd = clientAdd;

            IAdd add = adds;
            List<AddOns> addOns = add.GetAddOns();

            List<ClientAddOns> allAddOns = cAdd.GetClientAddOns(subID);
            int sensor = 0;
            int actor = 0;
            int controller = 0;
            double sensorcost = 0;
            double controllercost = 0;
            double actorcost = 0;
            foreach (var item in allAddOns)
            {
                if (item.AddID == addOns[0].ID)
                {
                    sensor++;
                    sensorcost = sensorcost + (item.Quantity * addOns[0].Cost);
                }
                else if (item.AddID == addOns[1].ID)
                {
                    actor++;
                    actorcost = actorcost + (item.Quantity * addOns[1].Cost);
                }
                else
                {
                    controller++;
                    controllercost = controllercost + (item.Quantity * addOns[2].Cost);
                }
            }

            string addondetails = string.Format("Add Ons: \n\tSensors: {0} \t\t\t\t\t R{1}\n\t" +
                "Actors: {2} \t\t\t\t\t R{3}\n\tControllers:{4} \t\t\t\t\t R{5}", sensor, sensorcost, actor, actorcost, controller, controllercost);

            return addondetails;
        }

        public void SearchConID(object sender, EventArgs e) 
        {
            try
            {
                IContract contract = contracts;
                List<Contracts> con = contract.GetContracts();

                List<Subscriptions> subscriptions = Subscriptions.GetSubscriptions();

                IProduct iprod = prod;
                List<Product> products = iprod.GetProducts();

                List<Client> clients = Client.GetClients();

                IMan iman = man;
                List<Manufacturer> manufacturers = iman.GetManufacturers();

                ITerms terms = productTerms;
                List<ProductTerms> pterms = terms.GetProductTerms();

                ICAdd cAdd = clientAdd;                

                IAdd add = adds;
                List<AddOns> addOns = add.GetAddOns();

                if (string.IsNullOrEmpty(txtConID.Text))
                {
                    throw new Exception("No Contract ID Entered.");
                }
                else if (con.Any(cont=>cont.ID==txtConID.Text))
                {
                    lblContract.Text = txtConID.Text;
                    Contracts search = con.Find(cont => cont.ID == txtConID.Text);
                    Subscriptions sub = subscriptions.Find(s => s.ID == search.SubID);
                    Client client = clients.Find(c => c.ID == search.ClientID);
                    Product searchres = products.Find(p => p.ProdID == sub.ProdID);
                    Manufacturer manName = manufacturers.Find(m => m.ID == searchres.ManID);
                    ProductTerms prodterm = pterms.Find(pt => pt.ProdID == searchres.ProdID);

                    string contractdetails = string.Format("Client ID: {0}\nClient Name: {1}\n\nProduct ID: {2}\t\t\t\t          R{12}\nProduct Name: {3}\nModel: {4}\nSerial Number: {14}\nManufacturer: {5}\n\n{13}\n\nContract Cost:\t\t\t\t\t          R{6}\n\nContract Start Date: {7}\nContract End Date: {8}\n\nUpgrade Terms: {9}\n\nPre-Emptive Maintanance Terms: {10}\nCorrective Maintanance Terms: {11}", 
                        client.ID, string.Concat(client.FirstName+" "+client.LastName), searchres.ProdID, searchres.Name, searchres.Version, manName.Name, sub.Cost, sub.Date.ToString("yyyy/MM/dd"), sub.Date.AddYears(1).ToString("yyyy/MM/dd"), 
                        prodterm.Upgrade, prodterm.PreMaintanance, prodterm.CorrectiveMaintanance, searchres.Cost, AddOnString(sub.ID), sub.SerialNumber);

                    rtbContract.Text = contractdetails;
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

        static string ClientDetails = "";

        private void SearchClientID(object sender, EventArgs e)
        {
            try
            {
                IContract contract = contracts;
                Contracts search = new Contracts();
                List<Contracts> con = contract.GetContracts();
                List<Contracts> clientcon = new List<Contracts>();

                Client client = new Client();
                List<Client> clients = Client.GetClients();
                if (string.IsNullOrEmpty(txtIDNum.Text))
                {
                    throw new Exception("No ID Number Entered.");
                }
                else if (User.ValidID(txtIDNum.Text)==true)
                {
                    if (clients.Any(c => c.IDNum == txtIDNum.Text))
                    {
                        client = clients.Find(c => c.IDNum == txtIDNum.Text);
                        lblClient.Text = string.Concat(client.FirstName + " " + client.LastName);
                        foreach (var item in con)
                        {
                            if (client.ID == item.ClientID)
                            {
                                clientcon.Add(new Contracts(item.ID, item.ClientID, item.SubID));
                            }
                        }

                        ClientDetails = string.Format("Client ID: {0}\nClient Name: {1}", client.ID, string.Concat(client.FirstName + " " + client.LastName));

                        cbContracts.DataSource = clientcon;
                        cbContracts.DisplayMember = "ID";
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

        private void Back(object sender, EventArgs e)
        {
            try
            {
                frmContractsMain frm = new frmContractsMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmContractSearch_Load(object sender, EventArgs e)
        {

        }

        private void cbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string conID = cbContracts.GetItemText(cbContracts.SelectedItem);
                lblConIDC.Text = conID;

                IContract contract = contracts;
                Contracts search = new Contracts();
                List<Contracts> con = contract.GetContracts();

                List<Subscriptions> subscriptions = Subscriptions.GetSubscriptions();
                Subscriptions sub = new Subscriptions();

                IProduct iprod = prod;
                Product searchres = new Product();
                List<Product> products = iprod.GetProducts();

                IMan iman = man;
                Manufacturer manName = new Manufacturer();
                List<Manufacturer> manufacturers = iman.GetManufacturers();

                ITerms terms = productTerms;
                List<ProductTerms> pterms = terms.GetProductTerms();
                ProductTerms prodterm = new ProductTerms();

                int sid = 0;

                foreach (var item in con)
                {
                    if (item.ID == conID)
                    {
                        sid = item.SubID;
                        break;
                    }
                }

                string pid = "";
                string pname = "";
                double cost = 0;
                string serial = "";
                DateTime date=DateTime.Now;

                foreach (var item in subscriptions)
                {
                    if (item.ID==sid)
                    {
                        pid = item.ProdID;
                        cost = item.Cost;
                        date = item.Date;
                        serial = item.SerialNumber;
                        break;
                    }
                }

                int manid = 0;
                string mname = "";
                string model = "";
                double pcost = 0;

                foreach (var item in products)
                {
                    if (item.ProdID==pid)
                    {
                        manid = item.ManID;
                        pname = item.Name;
                        model = item.Version;
                        pcost = item.Cost;
                        break;
                    }
                }

                foreach (var item in manufacturers)
                {
                    if (item.ID==manid)
                    {
                        mname = item.Name;
                        break;
                    }
                }

                string upgrade = "";
                string pmain = "";
                string emain = "";

                foreach (var item in pterms)
                {
                    if (item.ProdID==pid)
                    {
                        upgrade = item.Upgrade;
                        pmain = item.PreMaintanance;
                        emain = item.CorrectiveMaintanance;
                        break;
                    }
                }

                string contractdetails = string.Format("{0}\n\nProduct ID: {1}\t\t\t\t          R{11}\nProduct Name: {2}\nModel: {3}\nSerial Number: {13}\nManufacturer: {4}\n\n{12}\n\nContract Cost:\t\t\t\t\t          R{5}" +
                    "\n\nContract Start Date: {6}\nContract End Date: {7}\n\nUpgrade Terms: {8}\n\nPre-Emptive Maintanance Terms: {9}\nCorrective Maintanance Terms: {10}",
                       ClientDetails, pid, pname, model, mname, cost, date.ToString("yyyy/MM/dd"), date.AddYears(1).ToString("yyyy/MM/dd"), upgrade, pmain, emain, pcost, AddOnString(sid), serial);

                rtbClient.Text = contractdetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
