using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    class ProductInStorage:ProductAbstract
    {
        public int TimeOfStore { get; set; }
        public int AvailableInStore { get; set; }
        public SupplierInStorage SupplierStorage { get; set; }
        public ProductInStorage(decimal price, int avb, int time, SupplierInStorage supp = null)
        {
            AvailableInStore = avb;
            TimeOfStore = time;
            SupplierStorage = supp;
            Price.Ammount = price;
        }
        public override void ShowProductInfo()
        {
            Console.WriteLine("AvailableInStorage" + "TimeofStorage");
        }
    }
}
