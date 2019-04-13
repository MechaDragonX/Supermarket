using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    interface ILoyaltyProgram
    {
        void Register(string Name, string Email, string Password);
        void Login(string Email, string Password);
        void LogOut(int CustomerID);

        double Discount(CustomerType Type); // returns percentage
        void Redeem(int Points);
    }
}
