using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif.Models
{
    internal class Orange:Fruit
    {
        public int VitaminC;

        public Orange(int price, string sort, int vitaminC) : base(price, sort)
        {
            VitaminC=vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("Orange eagdsqa ");
        }
    }
}
