using Coffeeshop_Management_Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffeeshop_Management_Project.Models; 

namespace Coffeeshop_Management_Project.Controllers
{
    public class CustomerController
    {
        static Database db = new Database();
        public static Customer AuthenticateCustomer(string username, string password)
        {
            return db.Customers.AuthenticateCustomer(username, password);
        }


        public static bool AddCustomer(dynamic u)
        {
            Customer customer = new Customer();
            customer.Name = u.Name;
            customer.Username = u.Username;
            customer.Password = u.Password;

            return db.Customers.AddCustomer(customer);
        }
        public static Customer GetCustomer(string username)
        {
            return db.Customers.GetCustomer(username);
        }
        public static bool UpdateCustomer(dynamic u)
        {
            Customer customer = new Customer();
            customer.Name = u.Name;
            customer.Username = u.Username;
            return db.Customers.UpdateCustomer(customer);
        }

        /*public static bool DeleteCustomer(string username)
        {
            return db.Customers.DeleteCustomer(username);
        }*/

        /*public static ArrayList GetAllCustomers()
        {
            return db.Customers.GetAllCustomers();
        }*/

    }
}