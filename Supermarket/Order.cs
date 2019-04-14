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
        public Cart Cart { get; set; }
        public double Subtotal { get; set;}
        public double Total { get; set; }
        public string Store { get; set; }

        public Order(Customer Customer, Cart Cart, double Subtotal, double Total, string Store)
        {
            this.Customer = Customer;
            this.Cart = Cart;
            this.Subtotal = Subtotal;
            this.Total = Total;
            this.Store = Store;
        }

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
            Console.WriteLine("=====Receipt=====");
            Console.WriteLine("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.TimeOfDay+ "\n");
            Console.WriteLine(ToString());
            Console.WriteLine("Subtotal: {0}\nTotal: {1}\n", Subtotal, Total);
            Console.WriteLine("Number of Items: {0}", Cart.Items.Count);
            Console.WriteLine("Thank you {0} for shopping at {1}!\n", Customer.Name, Store);
        }
    }
}
