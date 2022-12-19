using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods_Practice
{
    internal class Order
    {
      public DateTime Date { get; set; }
        public double  Price { get; set; }
        public Order(DateTime date, double Price)
        {
            Date= date;
            Price = Price;
        }






    }
}
