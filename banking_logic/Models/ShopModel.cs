using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_logic.Models
{
    public class ShopModel
    {
        public string shopName { get; set; }
        public List<ItemModel> sellingItems {get;set;}
    }
}
