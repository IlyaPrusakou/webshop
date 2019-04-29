using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// из корзины появляется заказ и ему может соответствовать  несколько платежей(частичные оплатыб рассрочки и тд)
namespace webshop
{
    class Order
    {
        public int Id { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public Buyer Buyer { get; set; }
        public List<Payment> ListOfPayments { get; set; }
        public Order(Buyer buyer, List<Payment> list = null )
        {
            Buyer = buyer;
            ListOfPayments = list;
        }
        public void ChangeStatus()
        {

        }
        public bool CheckThePayment()
        {
            return true;
        }
        public void Ship()
        {

        }
    }
}
