using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif.Models
{
    internal abstract class Fruit
    {
        public int Price;
        public string Sort;


        public Fruit(int price, string sort)
        {
            Price = price;
            Sort = sort;
        }

        public abstract void Taste();
       
    }
}
