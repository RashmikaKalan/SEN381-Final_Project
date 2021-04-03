using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static int Authorisation;
        public static string EmployeeID;
        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                User signin = new User(txtUser.Text, txtPass.Text);
                List<User> users = User.GetUsers();
                User log;

                if (users.Any(user => user.Username == txtUser.Text))
                {
                    log = users.Find(user => user.Username == txtUser.Text);
                    if (log.Password == signin.Password)
                    {
                        DialogResult r = MessageBox.Show("Welcome! Please select a department on the next page.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (r == DialogResult.OK)
                        {
                            Authorisation = log.EmpLevel;
                            EmployeeID = log.ID.ToString();
                            frmMain frm = new frmMain();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    else if (log.Password != signin.Password)
                    {
                        MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Clear();
                        txtPass.Clear();
                    }
                }
                else if (!users.Any(user => user.Username == txtUser.Text && user.Password == txtPass.Text))
                {
                    MessageBox.Show("Invalid Log In Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Clear();
                    txtUser.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddUser fra = new frmAddUser();
                fra.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        #region Double Clicks
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
