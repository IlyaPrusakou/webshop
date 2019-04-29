using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class SupplierSelf : SupplierAbstract
    {
        public List<ProductAbstract> ListOfProducts { get; set; }
        public override ProductAbstract CreateProduct(decimal price, int terms, int moq)
        {
            return new ProductSelfMade(price, terms, moq);
        }
    }
}
