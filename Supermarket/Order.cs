using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Order
    {
        public Customer Customer { get; set; }
        public double Total { get; set; }
        public Cart Cart { get; set; }

        public override string ToString()
        {
            foreach (var item in Cart.Items)
            {
                item.ToString();
            }
            return "";
        }
        public void Receipt()
        {
            Console.WriteLine(ToString());
        }
    }
}
