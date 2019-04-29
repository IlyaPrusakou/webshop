using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class SupplierInStorage : SupplierAbstract
    {
        public List<ProductAbstract> ListOfProducts { get; set; }
        public override ProductAbstract CreateProduct(decimal price,int avb, int time)
        {
            return new ProductInStorage(price, avb, time);
        }
    }
}
