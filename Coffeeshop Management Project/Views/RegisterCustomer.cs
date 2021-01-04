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
                Name = tBName.Text,
                UserName = tbUserName.Text,
                Password = tBPassword.Text
            };
            var r = UserController.AddCustomer(customer);
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
