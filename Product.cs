using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri_Zigulev_Tovar_abstract_class
{
    class Product : Tovar
    {
        public Product(string name, double price, DateTime dateofproduct, DateTime datebestbefore) : base(name, price, dateofproduct, datebestbefore)
        {

        }
        public override void Show()
        {
            if (currentdate > datebestbefore)
            {
                Console.WriteLine("***PRODUCT IS EXPIRED!***");
            }
            Console.WriteLine("{0,1}" +
                "\nPrice : {1,3}" +
                "\nDate of Product : {2}" +
                "\nBest before : {3}", name, price, dateofproduct, datebestbefore);
        }
    }
}
