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
    public partial class frmUpdateClient : Form
    {
        public delegate void Del(object sender, EventArgs e);
        
        public frmUpdateClient()
        {
            InitializeComponent();
            Del provinces = new Del(Provinces);
            cbProvince.SelectedIndexChanged += new EventHandler(provinces);
            Del search = new Del(SearchClick);
            btnSearch.Click += new EventHandler(search);
            Del update = new Del(UpdateClick);
            btnUpdate.Click += new EventHandler(update);
            Del back = new Del(Back);
            btnBack.Click += new EventHandler(back);
        }

        private void Provinces(object sender, EventArgs e)
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

        private void UpdateClick(object sender, EventArgs e)
        {
            try
            {
                ClientImportance cimp = new ClientImportance();
                string city = cbCity.GetItemText(cbCity.SelectedItem);
                string prov = cbProvince.GetItemText(cbProvince.SelectedItem);
                string location = string.Concat(rtbLocation.Text + ", " + city + ", " + prov);

                if (string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(rtbLocation.Text))
                {
                    throw new Exception("Please Ensure All Fields Are Filled In");
                }
                else if (txtFirstName.Text.Any(char.IsDigit) || txtLastName.Text.Any(char.IsDigit))
                {
                    throw new Exception("First Name and Last Name should not contain any numbers");
                }
                else if (User.ValidEmail(txtEmail.Text) == true && User.ValidPhone(txtPhone.Text) == true)
                {
                    List<ClientImportance> clientImportances = cimp.GetClientImportances();
                    string index = cbImportance.GetItemText(cbImportance.SelectedItem);
                    string import="";
                    foreach (var item in clientImportances)
                    {
                        if (item.Importance==index)
                        {
                            import = item.ID;
                            break;
                        }
                    }

                    Client update = new Client(txtFirstName.Text, txtLastName.Text, txtIDNum.Text, txtPhone.Text, txtEmail.Text, location, import);
                    Client.UpdateClient(update);
                    DialogResult r = MessageBox.Show("Client successfully updated.", "Update Client Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        txtIDNum.Clear();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtPhone.Clear();
                        txtEmail.Clear();
                        rtbLocation.Clear();
                        frmClientMain frm = new frmClientMain();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchClick(object sender, EventArgs e)
        {
            try
            {
                List<Client> clients = Client.GetClients();
                Client search;
                List<string> provinces = Province.ProvList();
                cbProvince.DataSource = provinces;

                if (clients.Any(client => client.IDNum == txtIDNum.Text))
                {
                    MessageBox.Show("Client Found. You Can Now Update Their Details", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    search = clients.Find(client => client.IDNum == txtIDNum.Text);
                    txtIDNum.Enabled = false;
                    txtFirstName.Text = search.FirstName;
                    txtClientID.Text = search.ID;
                    txtLastName.Text = search.LastName;
                    txtPhone.Text = search.Phone;
                    txtEmail.Text = search.Email;
                    string[] locations = search.Location.Split(',');
                    string street = locations[0];
                    string prov = locations[2].Trim();
                    string city = locations[1].Trim();
                    rtbLocation.Text = street;

                    List<string> justP = Province.ProvList();
                    foreach (var item in justP)
                    {
                        if (item.Equals(prov))
                        {
                            cbProvince.SelectedIndex = justP.IndexOf(prov);
                            break;
                        }
                    }

                    List<Province> Allprovinces = Province.GetProvinces();
                    List<string> cityList = new List<string>();
                    foreach (var item in Allprovinces)
                    {
                        if (item.Prov == prov)
                        {
                            cityList.Add(item.City);
                        }
                    }
                    cbCity.DataSource = cityList;
                    foreach (var item in cityList)
                    {
                        if (item.Equals(city))
                        {
                            cbCity.SelectedIndex = cityList.IndexOf(city);
                            break;
                        }
                    }

                    ClientImportance cimp = new ClientImportance();
                    List<ClientImportance> clientImportances = cimp.GetClientImportances();
                    foreach (var item in clientImportances)
                    {
                        if (item.ID==search.Importance)
                        {
                            cbImportance.SelectedIndex = clientImportances.IndexOf(item);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Client Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                frmClientMain frm = new frmClientMain();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            try
            {
                ClientImportance cimp = new ClientImportance();
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
