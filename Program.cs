using System;

namespace Dmitri_Zigulev_Tovar_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar product1 = new Product("Sok", 12.5, Convert.ToDateTime("2020.10.22"), Convert.ToDateTime("2020.11.22"));
            Tovar party1 = new Party("ShocoPie", 2.5, Convert.ToDateTime("2020.10.22"), Convert.ToDateTime("2021.11.22"), 50);
            Tovar party2 = new Party("Milk", 0.99, Convert.ToDateTime("2021.3.5"), Convert.ToDateTime("2021.3.12"), 20);
            Tovar party3 = new Party("Bread", 0.5, Convert.ToDateTime("2021.3.25"), Convert.ToDateTime("2021.4.1"), 10);
            Tovar party4 = new Party("Pasta penne", 0.60, Convert.ToDateTime("2021.1.25"), Convert.ToDateTime("2022.1.25"),30 );
            Tovar party5 = new Party("Beef steak", 5.0, Convert.ToDateTime("2021.3.28"), Convert.ToDateTime("2021.4.5"), 5);
            product1.Show();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            party1.Show();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Base list = new Base();
            list.Add(party1);
            list.Add(party2);
            list.Add(party3);
            list.Add(party4);
            list.Add(party5);
            list.Add(product1);
            list.PrintBase();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            list.PrintExpiredBase();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            list.PrintValidBase();





            Console.ReadKey();
        }
    }
}
