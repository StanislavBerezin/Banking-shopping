using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_logic.Models
{
    public class ItemModel
    {
        public ItemModel(string itemName, int itemPrice)
        {
            ItemPrice = itemPrice;
            ItemName = itemName;
            
        }
        public int ItemPrice { get; set; }
        public string ItemName { get; set; }
    }
}
