using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri_Zigulev_Tovar_abstract_class
{
    abstract class Tovar
    {
        protected string name;
        protected double price;
        protected DateTime dateofproduct;
        protected DateTime datebestbefore;
        protected DateTime currentdate = DateTime.Now;
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return Price; }
        }
        public DateTime Dateofproduct
        {
            get { return dateofproduct; }
        }
        public DateTime Datebestbefore
        {
            get { return datebestbefore; }
        }
        public Tovar(string name, double price, DateTime dateofproduct, DateTime datebestbefore)
        {
            this.name = name;
            this.price = price;
            this.dateofproduct = dateofproduct;
            this.datebestbefore = datebestbefore;
        }
        public abstract void Show();
        public override string ToString()
        {
            return String.Format("{0,1}" +
                "\nPrice : {1,3}" +
                "\nDate of Product : {2}" +
                "\nBest before : {3}" 
                , name, price, dateofproduct, datebestbefore);
        }
    }
}
