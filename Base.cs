using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri_Zigulev_Tovar_abstract_class
{
    class Base
    {
        public DateTime currentdate = DateTime.Now;
        List<Tovar> list;
        public Base()
        {
            list = new List<Tovar>();
        }
        public void Add(Tovar tovar)
        {
            list.Add(tovar);
        }
        public void PrintBase()
        {
            Console.WriteLine("ALL PRODUCTS:");
            Console.WriteLine();
            foreach (Tovar t in list)
            {
                Console.WriteLine(t);
                Console.WriteLine();
            }
        }
        public void PrintExpiredBase()
        {
            Console.WriteLine("EXPIRED PRODUCTS:");
            Console.WriteLine();
            foreach (Tovar t in list)
            {
                if (currentdate > t.Datebestbefore)
                {
                    Console.WriteLine(t);
                    Console.WriteLine();
                }
            }
        }
        public void PrintValidBase()
        {
            Console.WriteLine("VALID PRODUCTS:");
            Console.WriteLine();
            foreach (Tovar t in list)
            {
                
                if (currentdate > t.Datebestbefore)
                {
                }
                else
                Console.WriteLine(t);
                Console.WriteLine();
            }
        }
    }
}
