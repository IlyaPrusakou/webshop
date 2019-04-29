using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class Visitor
    {
        public string Id { get; set; }
        public Busket Busket { get; set; }
        public List<Order> Orders { get; set; }
        public bool CanBuy { get; set; }
        public Visitor(List<Order> list)
        {
            Orders = list;
        }

        public virtual void Buy ()
        {
            
        }
        public virtual void RejectOrder()
        {

        }
        public virtual void MakeAPayment()
        {

        }
        public void Registration()
        {

        }
        public void Authentication()
        {

        }
    }
}
