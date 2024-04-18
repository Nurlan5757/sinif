using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif.Models
{
    internal class Pineapple:Fruit
    {
        public int VitaminE;
        public int VitaminD;

        public Pineapple(int price, string sort, int vitaminE, int vitaminD ) : base(price, sort)
        {
            VitaminE=vitaminE;
            VitaminD=vitaminD;
        }

        public override void Taste()
        {
            Console.WriteLine("Pineapple asgdsa ");
        }
    }
}
