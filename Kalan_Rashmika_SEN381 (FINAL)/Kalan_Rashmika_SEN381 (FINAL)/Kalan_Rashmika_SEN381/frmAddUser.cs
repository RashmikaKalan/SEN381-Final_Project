using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalan_Rashmika_SEN381
{
    public partial class frmAddUser : Form
    {
        EmployeeLevel emp = new EmployeeLevel();
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            try
            {
                List<EmployeeLevel> employeeLevels = emp.GetEmployeeLevels();
                BindingSource bs = new BindingSource();
                bs.DataSource = employeeLevels;
                cbRole.DataSource = bs;
                cbRole.DisplayMember = "Role"; ;
                cbRole.ValueMember = "Role";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        #region Double Clicks
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin frl = new frmLogin();
                frl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;

                if (User.ValidPhone(txtPhone.Text) && User.ValidEmail(txtEmail.Text)==true)
                {
                    employee.Phone = txtPhone.Text;
                    employee.Email = txtEmail.Text;
                }               

                string level = cbRole.GetItemText(cbRole.SelectedItem);
                List<EmployeeLevel> employeeLevels = emp.GetEmployeeLevels();
                foreach (var item in employeeLevels)
                {
                    if (item.Role == level)
                    {
                        employee.Level = item.EmpLevel;
                        break;
                    }
                } //gets the employee role/level by using the index of the selected item in the combox

                List<User> users = User.GetUsers();
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtPhone.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text) ||
                    string.IsNullOrEmpty(txtConfirm.Text))
                {
                    MessageBox.Show("Please ensure all fields have been filled in.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } //checks that all the information has been entered in the textboxes
                else if (txtFirstName.Text.Any(char.IsDigit) || txtLastName.Text.Any(char.IsDigit))
                {
                    throw new Exception("First Name and Last Name should not contain any numbers");
                }
                else
                {
                    foreach (var item in users)
                    {
                        if (item.Username == txtUser.Text)
                        {
                            DialogResult r = MessageBox.Show("Username is alsready taken. Please choose a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (r == DialogResult.OK)
                            {
                                txtUser.Clear();
                            }
                            break;
                        }
                        else if (txtConfirm.Text == txtPass.Text)
                        {
                            User user = new User(txtUser.Text, txtPass.Text);
                            User.AddUser(employee, user); //add user to database
                            DialogResult r2 = MessageBox.Show("User Successfully Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (r2 == DialogResult.OK)
                            {
                                txtFirstName.Clear();
                                txtLastName.Clear();
                                txtPass.Clear();
                                txtPhone.Clear();
                                txtEmail.Clear();
                                txtUser.Clear();
                                txtConfirm.Clear();
                                cbRole.SelectedIndex = 0;
                                frmLogin frl = new frmLogin();
                                frl.Show();
                                this.Hide();
                                break;
                            }
                        } //adds the user to the database if the text in txtPassword and txtConfirm match
                        else
                        {
                            throw new Exception("Passwords Do Not Match.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
