using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// класс для работы с платежами
namespace webshop
{
    class Payment
    {
        public string Id {get;set;}
        public decimal Amount { get; set; }
        public PaymentStatus Paymentstatus { get; set; }
        public DateTime Date { get; set; }
        public Order Order { get; set; }
        public Payment(Order ord)
        {
            Order = ord;
        }
        public void ChangeStatusOfPayment()
        {

        }
    }
}
