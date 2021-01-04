using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffeeshop_Management_Project.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Item_Id { get; set; }
        public string Item_Price { get; set; }
        public string Customer_Id { get; set; }
    }
}
