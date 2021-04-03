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
    public partial class frmClientSearch : Form
    {
        public delegate void Del(object sender, EventArgs e);


        public frmClientSearch()
        {
            InitializeComponent();
            Del search = new Del(SearchClick);
            btnSearch.Click += new EventHandler(search);
        }

        private void SearchClick(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(645, 593);
                Client search;
                List<Client> clients = Client.GetClients();
                if (User.ValidID(txtIDNum.Text))
                {
                    if (clients.Any(client => client.IDNum == txtIDNum.Text))
                    {
                        MessageBox.Show("Client found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        search = clients.Find(client => client.IDNum == txtIDNum.Text);
                        txtFirstName.Text = search.FirstName;
                        txtLastName.Text = search.LastName;
                        txtClientID.Text = search.ID;
                        txtID.Text = search.IDNum;
                        txtPhone.Text = search.Phone;
                        txtEmail.Text = search.Email;
                        rtbLocation.Text = search.Location;

                        ClientImportance cmp = new ClientImportance();
                        List<ClientImportance> clientImportances = cmp.GetClientImportances();

                        foreach (var item in clientImportances)
                        {
                            if (item.ID==search.Importance)
                            {
                                txtImportance.Text = item.Importance;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Client not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientSearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(269, 403);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.Clear();
                txtID.Clear();
                txtIDNum.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                rtbLocation.Clear();
                txtClientID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
