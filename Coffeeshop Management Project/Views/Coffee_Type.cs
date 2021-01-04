using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Coffeeshop_Management_Project.Views
{
    public partial class Coffee_Type : Form
    {
        public Coffee_Type()
        {
            InitializeComponent();
        }

        private void Coffee_Type_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MF28SRI;Database=Inventory_group9;Integrated Security=true;");
        }
        public void clear_all()
        {
            comboBoxCType.Clear();
            textBoxPrice.Clear();
            comboBoxQuantity.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into Coffee_Type(Coffee_Type,Price,Quantity) values ('" + comboBoxCType.Text + "', '" + textBoxPrice.Text + "'," + comboBoxQuanity.Text + "'')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Coffee Type save successfully");
            clear_all();
        }
    }
}
