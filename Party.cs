using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri_Zigulev_Tovar_abstract_class
{
    class Party : Tovar
    {
         int amount;
        public Party(string name, double price, DateTime dateofproduct, DateTime datebestbefore, int amount) : base(name, price, dateofproduct, datebestbefore)
        {
            this.amount = amount;
        }
        public override void Show()
        {
            if (currentdate > datebestbefore)
            {
                Console.WriteLine("***PARTY IS EXPIRED!***");
            }
            Console.WriteLine("{0,1}" +
                "\nPrice : {1,3}" +
                "\nDate of Product : {2}" +
                "\nBest before : {3}" +
                "\nAmount in  package : {4,2}"
                , name, price, dateofproduct, datebestbefore, amount);
        }
        public override string ToString()
        {
            return  String.Format("{1}\nAmount in package {0,3}", amount,base.ToString());
        }
    }
}
