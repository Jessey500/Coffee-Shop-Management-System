using Coffeeshop_Management_Project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffeeshop_Management_Project.Views
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            var r = CustomerController.AuthenticateCustomer(username, password);
            if (r != null)
            {
                //new DashboardCustomerForm().Show();
                MessageBox.Show("User valid");
            }
            else
            {
                MessageBox.Show("User not valid");
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationBT_Click(object sender, EventArgs e)
        {
            new RegisterCustomer().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new RegisterCustomer().Show();
        }
    }
}
