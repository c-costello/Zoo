using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public class PinkSalmon : Salmon
    {
        public bool HasHump { get => HasHump; set => HasHump = true;}

        public override string Habitat { get => Habitat; set => Habitat = "Oceans and Streams"; }

        public override void Eat()
        {
            Console.WriteLine("Eat");
        }

        public override void Migrate()
        {
            Console.WriteLine("Migrate");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
