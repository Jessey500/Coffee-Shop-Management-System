using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffeeshop_Management_Project.Controllers;

namespace Coffeeshop_Management_Project.Views
{
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            var customer = new
            {
                Name = txtname.Text,
                UserName = txtusername.Text,
                Password = txtpassword.Text
            };
            var r = CustomerController.AddCustomer(customer);
            if (r)
            {
                MessageBox.Show("Customer Added");
            }
            else
            {
                MessageBox.Show("Customer Not Added");
            }
        }
    }
}
