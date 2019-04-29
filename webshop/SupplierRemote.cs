using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class SupplierRemote : SupplierAbstract
    {
        public List<ProductAbstract> ListOfProducts { get; set; }
        public override ProductAbstract CreateProduct(decimal price, int terms, int moq)
        {
            return new ProductRemote(price, terms, moq);
        }
    }
}
