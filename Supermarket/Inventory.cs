using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Inventory
    {
        public List<Item> Items { get; set; }

        public Inventory()
        {
            Items = new List<Item>();
        }

        public int Add(Item Item)
        {
            Items.Add(Item);
            return Item.ID;
        }
        public void Search(Func<Item, bool> predicate) // x => x.<property>
        {
            IEnumerable<Item> results = Items.Where(predicate);
            foreach (var item in results)
            {
                Console.WriteLine(item.ToString());
                /*
                    Writes:
                  
                    ID: <ID>
                    Name: <Name>
                    Price: <Author>
                    Stock: <Amount>
                */
            }
        }
    }
}
