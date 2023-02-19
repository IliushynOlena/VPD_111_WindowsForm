using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lists
{
    internal class Order
    {
        private static int count = 0;
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public Order(decimal price)
        {
            Number = ++count;
            Date = DateTime.Now;
            TotalPrice = price; 
        }
        public override string ToString()
        {
            return $"#{Number}  - {TotalPrice}$  {Date}";
        }
    }
}
