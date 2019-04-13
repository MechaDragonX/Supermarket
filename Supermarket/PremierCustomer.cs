using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class PremierCustomer : PreferredCustomer
    {
        private static Random rng = new Random(4198);

        public PremierCustomer(string Name, string Email, string Password) : base(Name, Email, Password)
        {
            Type = CustomerType.Premier;
        }
    }
}
