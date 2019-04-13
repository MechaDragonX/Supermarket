using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Cart : Inventory
    {
        public Cart() : base() { }

        public int Remove(Item Item)
        {
            Items.Remove(Item);
            return Item.ID;
        }
        //public Order CheckOut() { }
    }
}
