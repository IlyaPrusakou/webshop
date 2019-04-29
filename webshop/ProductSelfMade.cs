using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//factory method это товары собственного производства
namespace webshop
{
    class ProductSelfMade:ProductAbstract
    {
        public int MinimalQuantitySelf { get; set; }
        public int TermsOfProduction { get; set; }
        public SupplierSelf SupplierSelfMade { get; set; }
        public ProductSelfMade(decimal price, int terms, int moq, SupplierSelf supp = null)
        {
            TermsOfProduction = terms;
            MinimalQuantitySelf = moq;
            SupplierSelfMade = supp;
            Price.Ammount = price;
        }
        public override void ShowProductInfo()
        {
            Console.WriteLine("Terms of production " + "Minimal Quantity");
        }
    }
}
