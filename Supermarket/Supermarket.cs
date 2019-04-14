using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Supermarket
    {
        public string Name { get; set; }
        public Inventory Inventory { get; set; }
        public List<Customer> Customers { get; set; }
        public LoyaltyProgram LoyaltyProgram { get; set; }

        public Supermarket(string Name)
        {
            this.Name = Name;
            Customers = new List<Customer>();

            Console.Title = "Welcome to " + Name + "!";
        }

        public void CheckOut(Customer Customer, Cart Cart)
        {
            double subtotal = 0;
            foreach (var item in Cart.Items)
            {
                subtotal += item.Price;
            }
            double total = LoyaltyProgram.Discount(Customer.Type) * subtotal * 1.95;
            Order current = new Order(Customer, Cart, subtotal, total, Name);
            current.Receipt();
        }
    }
}
