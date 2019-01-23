using banking_logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_logic
{
    public class MainConfig
    {
       

        public void creatingDummyData()
        {
            var potato = new ItemModel()
            {
                ItemName = "potato",
                ItemPrice = 20
            };

            var icecream = new ItemModel()
            {
                ItemName = "ice-cream",
                ItemPrice = 50
            };
            ///just a different ways of inserting items in a list, can do seperately or create it right inside
            var shopItems = new List<ItemModel> {
                icecream,
                potato,
                new ItemModel() { ItemPrice = 60, ItemName = "Milk" }
            };

            ShopModel coles = new ShopModel();
            coles.shopName = "Coles";
            coles.sellingItems = shopItems;



        }

    }
}
