using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffeeshop_Management_Project.Models;
using System.Collections;

namespace Coffeeshop_Management_Project.Controllers
{
   public class ItemController
   {
       static Database db = new Database();
      


       public static bool AddItem(dynamic i)
       {
           Item item = new Item();
           item.Item_Name = i.Item_Name;
           item.Price = i.Price;
           return db.Items.AddItems(item);
       }
       public static Item GetItem(string item_name)
       {
           return db.Items.GetItem(item_name);
       }
       public static bool UpdateItem(dynamic i)
       {
           Item item = new Item();
           item.Item_Name = i.Item_Name;
           item.Price = i.Price;
           return db.Items.UpdateItem(item);
       }

       public static bool DeleteItem(string item_name)
       {
           return db.Items.DeleteItem(item_name);
       }

       public static ArrayList GetAllItems()
       {
           return db.Items.GetAllItems();
       }

    }
}
