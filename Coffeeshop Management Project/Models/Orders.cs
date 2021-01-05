using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Coffeeshop_Management_Project.Models
{
    public class Orders
    {
         SqlConnection conn;
        public Orders(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddOrders(Order order)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Orders VALUES ('{0}','{1}','{2}','{3}')", order.Id,order.Item_Id, order.Item_Price,order.Customer_Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public Order AuthenticateOrder(string item_price)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Orders WHERE Item_name='{0}' and Item_Price='{1}'", item_price);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order = null;
            while (reader.Read())
            {
                order = new Order();
                order.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                order.Item_Id = reader.GetString(reader.GetOrdinal("Item_Id"));
                order.Item_Price = reader.GetString(reader.GetOrdinal("Item_Price"));
                order.Customer_Id = reader.GetString(reader.GetOrdinal("Customer_Id"));
                
               
             }
            conn.Close();
            return order;
        }
        public ArrayList GetAllOrders()
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order = new Order();
                order.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                order.Item_Id = reader.GetString(reader.GetOrdinal("Item_Id"));
                order.Item_Price = reader.GetString(reader.GetOrdinal("Item_Price"));
                order.Customer_Id = reader.GetString(reader.GetOrdinal("Customer_Id"));
                orders.Add(order);
                orders.Add(order);
            }
            conn.Close();
            return orders;
        }

 

        public Order GetOrder(string Item_Id)
        {
            conn.Open();
            string query = "SELECT * FROM Ordes";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order= null;
            while (reader.Read())
            {
                order = new Order();
                order.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                order.Item_Id= reader.GetString(reader.GetOrdinal("Item_Id"));
                order.Item_Price = reader.GetString(reader.GetOrdinal("Item_Price"));
                order.Customer_Id = reader.GetString(reader.GetOrdinal("Customer_Id"));
               
            }
            conn.Close();
            return order;
        }
      
        public bool DeleteOrder(string item)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Orders WHERE item='{0}'", item);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
