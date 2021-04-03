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
    public partial class frmRemoveClient : Form
    {
        public delegate void Del(object sender, EventArgs e);
        public frmRemoveClient()
        {
            InitializeComponent();
            Del remove = new Del(RemoveClick);
            btnDelete.Click += new EventHandler(remove);
        }

        private void RemoveClick(object sender, EventArgs e)
        {
            try
            {
                Client clienti = new Client();
                if (string.IsNullOrEmpty(txtIDNum.Text))
                {
                    throw new Exception("No ID Was Entered.");
                }
                List<Client> clients = Client.GetClients();
                string IDNum;
                string clientID;
                if (User.ValidID(txtIDNum.Text) == true)
                {
                    if (clients.Any(client => client.IDNum == txtIDNum.Text))
                    {
                        foreach (var item in clients)
                        {
                            if (item.IDNum == txtIDNum.Text)
                            {
                                IDNum = item.IDNum;
                                clientID = item.ID;
                                Client.RemoveClient(IDNum, clientID);
                                DialogResult r = MessageBox.Show("Client and Client's Purchases Removed.", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (r == DialogResult.OK)
                                {
                                    txtIDNum.Clear();
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
                        throw new Exception("Client Does Not Exist.");
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
                frmClientMain clientMain = new frmClientMain();
                clientMain.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmRemoveClient_Load(object sender, EventArgs e)
        {

        }
    }
}
