using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    
    abstract class SupplierAbstract
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public abstract ProductAbstract CreateProduct(decimal price, int terms, int moq);
        public void SupplyTheProduct()
        {

        }
    }
    
}
