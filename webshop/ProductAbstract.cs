using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//factory method
namespace webshop
{
    abstract class ProductAbstract
    {
        public ProductStatus Productstatus { get; set; }
        public Price Price { get; set; }
        public List<Busket> Busket { get; set; }

        public static bool operator ==(ProductAbstract b1, ProductAbstract b2)
        {
            return b1.Price.Ammount == b2.Price.Ammount;
        }
        public static bool operator !=(ProductAbstract b1, ProductAbstract b2)
        {
            return b1.Price.Ammount != b2.Price.Ammount;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ProductAbstract))
                return false;

            return this == (ProductAbstract)obj;
        }
        public ProductAbstract()
        {
            Price = new Price();
        }
        public abstract void ShowProductInfo();
        public void PutInBasket()
        {

        }
    }
}
