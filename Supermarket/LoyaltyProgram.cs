using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class LoyaltyProgram : ILoyaltyProgram
    {
        public List<PreferredCustomer> Customers { get; set; }

        public void Register(string Name, string Email, string Password)
        {
            if (Customers.Any(x => x.Email == Email))
            {
                Console.WriteLine("The desired Email already exists.\n");
            }
            else if (Customers.Any(x => x.Password == Password))
            {
                Console.WriteLine("The desired Password already exists.\n");
            }
            else if (Customers.Any(x => x.Email == Email && x.Password == Password))
            {
                Console.WriteLine("The desired Email & Password already exists.\n");
            }
            else
            {
                PreferredCustomer newPreferredCustomer = new PreferredCustomer(Name, Email, Password);
                Customers.Add(newPreferredCustomer);
            }

        }
        public void Login(string Email, string Password)
        {
            if (Customers.Any(x => x.Email == Email && x.Password == Password))
            {
                PreferredCustomer current = Customers.First(x => x.Email == Email && x.Password == Password);
                current.LoggedIn = true;
                Console.WriteLine("You have successfully logged in, {0}!\n", current.Name);
            }
            else
            {
                Console.WriteLine("The Email and/or Password is incorrect.\n");
            }
        }
        public void LogOut(int CustomerID)
        {
            PreferredCustomer log = Customers.First(x => x.ID == CustomerID);
            log.LoggedIn = false;
            Console.WriteLine("You have successfully logged out, {0}!\n", log.Name);
        }

        public double Discount(CustomerType Type)
        {
            switch (Type)
            {
                case CustomerType.Regular:
                    return 1;
                case CustomerType.Preferred:
                    return 1.20;
                case CustomerType.Premier:
                    return 1.70;
            }
            return 0;
        }
        public void Redeem(int Points)
        {
            throw new NotImplementedException();
        }
    }
}
