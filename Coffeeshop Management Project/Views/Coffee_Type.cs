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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MF28SRI;Database=Inventory_group9;Integrated Security=true;");
        }

        private void Coffee_Type_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MF28SRI;Database=Inventory_group9;Integrated Security=true;");
        }
        public void display_data()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MF28SRI;Database=Inventory_group9;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select *from Coffee_Type";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridViewCoffee.DataSource = dt;
            con.Close();
            


        }
        public void clear_all()
        {

            comboBoxCType.Show();
            textBoxPrice.Show();
            comboBoxQuantity.Show();


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-MF28SRI;Database=Inventory_group9;Integrated Security=true;");

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into Coffee_Type(Coffee_Type,Price,Quantity) values ('" + comboBoxCType.Text + "', '" + textBoxPrice.Text + "','" + comboBoxQuantity.Text + "'')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Coffee Type save successfully");
            clear_all();
        }

        DataTable dtcoffee = new DataTable();
        int cold = 0;
        private void GridViewCoffee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-MF28SRI;Database=Inventory_group9;Integrated Security=true;");

                SqlDataAdapter da = new SqlDataAdapter("select *from Coffee_Type where C_ID="+GridViewCoffee.Rows[e.RowIndex].Cells["C_ID"].Value+"", con);
                dtcoffee.Clear();
                da.Fill(dtcoffee);
                if (dtcoffee.Rows.Count > 0)
                { 
                   
                   
                }

            }
        }
    }
}
