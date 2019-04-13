using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Item
    {
        private static Random rng = new Random(5791);
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Item(string Name, double Price, int Amount)
        {
            ID = rng.Next(1000);
            this.Name = Name;
            this.Price = Price;
            this.Amount = Amount;
        }
        public override string ToString()
        {
            return string.Format
            (
                "{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
                "ID", ID,
                "Name", Name,
                "Price", Price,
                "Stock", Amount
            );
        }
    }
}
