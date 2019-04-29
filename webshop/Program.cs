using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop
{
    public enum ProductStatus
    {
        none = 1,
        await = 2,
        notmuch = 4,
        plenty = 8
    }
    public enum BuyerStatus
    {
        none = 1,
        permanent = 2,
        big = 4,
        dealer = 8,
    }
    public enum ShippingStatus
    {
        inCollecting = 1,
        hasPrepared =2,
        hasShipped = 4,
    }
    public enum PaymentStatus
    {
        isInvoice =1,
        hasPayed =2,
        hasRejected =4
    }
    public enum AccountStatus
    {
        newAccount = 1,
        Active = 2,
        Blocked = 4,
        Banned = 8
    }
    // try overloading operators
    class Program
    {
        static void Main(string[] args)
        {
            //i have overload operator == in abstract class ProductAbstract, then the concrete type of product
            // has make inharitance the overloading.
            SupplierInStorage B = new SupplierInStorage();
            ProductInStorage Bproduct = (ProductInStorage)B.CreateProduct(339, 100, 0);
            ProductInStorage Bproduct2 = (ProductInStorage)B.CreateProduct(777, 100, 0);
            ProductInStorage Bproduct3 = (ProductInStorage)B.CreateProduct(339, 100, 0);
            bool Test = Bproduct == Bproduct2;
            bool Test2 = Bproduct == Bproduct3;
            Console.WriteLine(Test); //False
            Console.WriteLine(Test2); //True
            Console.ReadLine();
        }
    }
}
