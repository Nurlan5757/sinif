using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif.Models
{
    internal class Apple:Fruit
    {
        public int VitaminA;
        public int VitaminB;

        public Apple(int price, string sort,int vitaminA,int vitaminB) : base(price, sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }

        public override void Taste()
        {
            Console.WriteLine("apple ajsbvi");
        }

    }
}
