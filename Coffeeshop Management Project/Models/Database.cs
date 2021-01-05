using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Coffeeshop_Management_Project.Models
{
    class Database
    {
        public Customers Customers { get; set; }
        public Orders Orders { get; set; }
        public Items Items { get; set; }
      
        
        public Database()
        {
            string connString = "Data Source=DESKTOP-MF28SRI;Initial Catalog=Inventory_group9;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            Customers = new Customers(conn);
            Orders = new Orders(conn);
            Items = new Items(conn);
           

        }
    }
}
