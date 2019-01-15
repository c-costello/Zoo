using System;
using Zoo.classes;
using Zoo.interfaces;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BlackBear blackBear = new BlackBear();
            Coho coho = new Coho();
            GreyWolf greyWolf = new GreyWolf();
            LionFish lionFish = new LionFish();
            PinkSalmon pinkSalmon = new PinkSalmon();
            PolarBear polarBear = new PolarBear();

            

            Console.WriteLine(polarBear.Swim());
            Console.WriteLine(pinkSalmon.Eat());
            Console.WriteLine(blackBear.Nurse());
            Console.WriteLine(lionFish.Sleep());
            Console.WriteLine(greyWolf.Play());
            Console.WriteLine(coho.Migrate());

            IRun bBear = new BlackBear();
            Console.WriteLine(bBear.TopSpeed);
        }
    }
}
