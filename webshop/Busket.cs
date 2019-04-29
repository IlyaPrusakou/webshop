using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// одному посетителю соответсвует одна корзина (временные хранилище отобраного товара), после подтверждения на основе
// корзины формируется объект заказа
namespace webshop
{
    class Busket
    {
        public string Id { get; set; }
        public decimal Amount;
        public List<ProductAbstract> ListOfProducts;
        public Visitor Visitor;
        public Order Order;
        public Busket(List<ProductAbstract> list = null, Visitor vis = null, Order ord = null)
        {
            ListOfProducts = list;
            Visitor = vis;
            Order = ord;
        }
        public void SubmitBusket()
        {

        }
        public void AddInBusket()
        {

        }
        public void ExceptOutOfBasket()
        {

        }
    }
}
