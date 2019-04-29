using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class Buyer: Visitor
    {
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public string Contact { get; set; }
        public Account Account { get; set; }
        public BuyerStatus BuyerStatus { get; set; }
        public Buyer(List<Order> ord, string name, string contact) :base (ord)
        {
            Name = name;
            Contact = contact;
        }
        public override void Buy()
        {

        }
        public override void RejectOrder()
        {

        }
        public override void MakeAPayment()
        {

        }
        public void Authorization()
        {

        }
    }
}
