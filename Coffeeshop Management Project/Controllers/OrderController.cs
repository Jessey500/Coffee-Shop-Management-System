using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffeeshop_Management_Project.Models;
using System.Collections;

namespace Coffeeshop_Management_Project.Controllers
{
    public class OrderController
    {
        static Database db = new Database();
        public static Order AuthenticateOrder( string Item_Price)
        {
            return db.Orders.AuthenticateOrder(Item_Price);
        }


        public static bool AddOrder(dynamic o)
        {
            Order order = new Order();
            order.Item_Id = o.Item_Id;
            order.Item_Price = o.Price;
            return db.Orders.AddOrders(Orders);
        }
        public static Item GetOrder(string Item_Id)
        {
            return db.Orders.GetOrder(Item_Id);
        }
        public static bool UpdateOrder(dynamic o)
        {
            Order order = new Order();
            order.Item_Id = o.Item_Id;
            order.Item_Price = o.Price;
            return db.Orders.UpdateOrders(order);
        }

        public static bool DeleteOrder(string item_name)
        {
            return db.Orders.DeleteOrder(item_name);
        }

        public static ArrayList GetAllOrders()
        {
            return db.Orders.GetAllIOrders();
        }

    }
}
