using sinif.Models;
using System.Security.Cryptography.X509Certificates;

namespace sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Apple apple = new Apple(12, "apple" ,13,5);
            Pineapple pineapple = new Pineapple(12, "pineapple",45,56);
            Orange orange = new Orange(76,"orange",56);

            Fruit[] Basket = { apple, orange, pineapple };

           


            foreach (var fruit in Basket)
            {

                var type = fruit.GetType();

                Console.WriteLine(type.Name);

                foreach (var item in type.GetFields())
                {
                    Console.WriteLine(item.GetValue(fruit));
                }



                /*if (fruit is Apple A)
                {
                    A.Taste();
                    Console.WriteLine(apple.Sort + apple.VitaminA + " " + apple.VitaminB);
                }
                else if (fruit is Pineapple P)
                {
                    P.Taste();
                    Console.WriteLine(pineapple.Sort + pineapple.VitaminE + " " + pineapple.VitaminD);
                }
                else if (fruit is Orange O)
                {
                    O.Taste();
                    Console.WriteLine(orange.Sort + orange.VitaminC);
                }*/

            }
            
        }
    }
}