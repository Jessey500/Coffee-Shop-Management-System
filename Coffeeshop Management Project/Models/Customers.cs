using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeeshop_Management_Project.Models
{
    public class Customers
    {
        SqlConnection conn;
        public Customers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Customers VALUES ('{0}','{1}','{2}','{3}')", customer.Name,customer.Username, customer.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public Customer AuthenticateCustomer(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customers WHERE Username='{0}' and Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.Username = reader.GetString(reader.GetOrdinal("Username"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
                
            }
            conn.Close();
            return customer;
        }
       /* public ArrayList GetAllCustomers()
        {
            ArrayList customers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer user = new Customer();
                user = new Customer();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
                customers.Add(user);
            }
            conn.Close();
            return customers;
        }*/

 

        public Customer GetCustomer(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer= null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.Username = reader.GetString(reader.GetOrdinal("Username"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }
        public bool UpdateCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("UPDATE As SET Name='{0}'  WHERE Username='{1}'", customer.Name, customer.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        /*public bool DeleteCustomer(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Customers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }*/
    }
}
