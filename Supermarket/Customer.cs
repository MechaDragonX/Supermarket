using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Customer
    {
        private static Random rng = new Random(3029);
        public int ID { get; set; }
        public string Name { get; set; }
        public Cart Cart { get; set; }
        public CustomerType Type { get; set; }

        public Customer(string Name)
        {
            ID = rng.Next(1000);
            this.Name = Name;
            Cart = new Cart();
            Type = CustomerType.Regular;
        }
    }
}
