using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//factory method это товары, находящиейся на удаленном складе(товары под заказ)
namespace webshop
{
    class ProductRemote:ProductAbstract
    {
        public int MinimalQuantityRemote { get; set; }
        public int TermsOfDelivaryInStore { get; set; }
        public SupplierRemote SupplierRemote { get; set; }
        public ProductRemote(decimal price, int terms, int moq, SupplierRemote supp = null)
        {
            TermsOfDelivaryInStore = terms;
            MinimalQuantityRemote = moq;
            SupplierRemote = supp;
            Price.Ammount = price;
        }
        public override void ShowProductInfo()
        {
            Console.WriteLine("Terms of delivery in Storage " + "Minimal Quantity Remote");
        }
    }
}
