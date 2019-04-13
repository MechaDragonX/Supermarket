using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class PreferredCustomer : Customer
    {
        private static Random rng = new Random(8103);
        public string Email { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public int Points { get; set; }

        public PreferredCustomer(string Name, string Email, string Password) : base(Name)
        {
            Type = CustomerType.Preferred;

            this.Email = Email;
            this.Password = Password;
            Points = 0;
        }
    }
}
