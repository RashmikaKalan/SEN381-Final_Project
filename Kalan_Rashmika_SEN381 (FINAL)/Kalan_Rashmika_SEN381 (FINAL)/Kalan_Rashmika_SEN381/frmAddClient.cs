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
    public partial class frmAddClient : Form
    {
        public delegate void Del(object sender, EventArgs e);
        ClientImportance import = new ClientImportance(); 

        public frmAddClient()
        {
            InitializeComponent();
            Del add = new Del(AddClick);
            btnAddClient.Click += new EventHandler(add);
            Del change = new Del(ProvinceCity);
            cbProvince.SelectedIndexChanged += new EventHandler(change);
        }
       
        private void AddClick(object sender, EventArgs e)
        {
            try
            {
                IImportance cimp = import;
                List<ClientImportance> clientImportances = cimp.GetClientImportances();
                List<Client> clients = Client.GetClients();
                Client client = new Client();
                client.FirstName = txtFirstName.Text;
                client.LastName = txtLastName.Text;
                string city = cbCity.GetItemText(cbCity.SelectedItem);
                string prov = cbProvince.GetItemText(cbProvince.SelectedItem);
                client.Location = string.Concat(rtbLocation.Text + ", " + city + ", " + prov);

                string NewID = Client.GenerateClientID();
                bool exist = false;
                while (exist==false)
                {
                    if (!clients.Any(c=>c.ID==NewID))
                    {
                        exist = true;
                        client.ID = NewID;
                        break;
                    }
                    else
                    {
                        NewID = Client.GenerateClientID();
                        exist = false;
                    }
                }

                string importcb = cbImportance.GetItemText(cbImportance.SelectedItem);
                foreach (var item in clientImportances)
                {
                    if (item.Importance==importcb)
                    {
                        client.Importance = item.ID;
                        break;
                    }
                }


                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtID.Text) ||
                    string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(rtbLocation.Text))
                {
                    throw new Exception("Ensure all fields are filled in.");
                }
                else if (txtFirstName.Text.Any(char.IsDigit) || txtLastName.Text.Any(char.IsDigit))
                {
                    throw new Exception("First Name and Last Name should not contain any numbers");
                }
                else if (User.ValidID(txtID.Text) == true)
                {
                    if (User.ValidEmail(txtEmail.Text) == true && User.ValidPhone(txtPhone.Text) == true)
                    {
                        client.Email = txtEmail.Text;
                        client.Phone = txtPhone.Text;
                    }

                    client.IDNum = txtID.Text;

                    foreach (var item in clients)
                    {
                        if (item.Equals(client))
                        {
                            throw new Exception("Client already exists.");
                        }
                        else if (item.IDNum == txtID.Text)
                        {
                            throw new Exception("Client ID Number already exists.");
                        }

                        if (!clients.Any(c=>c.IDNum==txtID.Text))           
                        {                            
                            Client.InsertClient(client); 
                            DialogResult r = MessageBox.Show("Client Successfully Added.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (r == DialogResult.OK)
                            {
                                txtFirstName.Clear();
                                txtLastName.Clear();
                                txtEmail.Clear();
                                txtID.Clear();
                                txtPhone.Clear();
                                rtbLocation.Clear();
                                frmClientMain frm = new frmClientMain();
                                frm.Show();
                                this.Hide();
                            }
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid ID Number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProvinceCity(object sender, EventArgs e)
        {
            try
            {
                string prov = cbProvince.GetItemText(cbProvince.SelectedItem);
                List<Province> provinces = Province.GetProvinces();
                List<string> city = new List<string>();
                foreach (var item in provinces)
                {
                    if (item.Prov == prov)
                    {
                        city.Add(item.City);
                    }
                }
                cbCity.DataSource = city;
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
                frmClientMain clientMain = new frmClientMain();
                clientMain.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            try
            {
                IImportance cimp = import;
                List<string> provinces = Province.ProvList();
                cbProvince.DataSource = provinces;
                List<ClientImportance> clientImportances = cimp.GetClientImportances();
                cbImportance.DataSource = clientImportances;
                cbImportance.DisplayMember = "Importance";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
