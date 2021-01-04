using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Coffeeshop_Management_Project.Models
{
   public class Items
    { 
        SqlConnection conn;
        public Items(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddItems(Item item)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Items VALUES ('{0}','{1}','{2}')", item.Id,item.Item_Name, item.Price);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        /*public Item AuthenticateItem( string item_name,string price)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Items WHERE Item_Name='{0}' and Price='{1}'", item_name, price);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Item item = null;
            while (reader.Read())
            {
                item = new Item();
                item.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                item.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                item.Price = reader.GetString(reader.GetOrdinal("Price"));
               
            }
            conn.Close();
            return item;
        }*/
        public ArrayList GetAllItems()
        {
            ArrayList items = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Items";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Item item = new Item();
                item = new Item();
                item.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                item.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                item.Price = reader.GetString(reader.GetOrdinal("Price"));
                items.Add(item);
            }
            conn.Close();
            return items;
        }

 

        public Item GetItem(string item_name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Items WHERE Item_Name='{0}'", item_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Item item = null;
            while (reader.Read())
            {
                item = new Item();
                item.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                item.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                item.Price = reader.GetString(reader.GetOrdinal("Price"));
               
               
            }
            conn.Close();
            return item;
        }
        public bool UpdateItem(Item item)
        {
            conn.Open();
            string query = String.Format("UPDATE As SET Price='{0}'  WHERE Item_Name='{1}'",item.Price, item.Item_Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteItem(string item_name)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Items WHERE Item_Name='{0}'", item_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

    }
}
