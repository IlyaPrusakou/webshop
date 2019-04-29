using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public Buyer Buyer { get; set; }
        public Account(Buyer buyer)
        {
            Buyer = buyer;
        }
        public void BlockAccount()
        {

        }
        public void BanAccount()
        {

        }
    }
}
