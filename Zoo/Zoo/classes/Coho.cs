using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    class Coho : Salmon
    {
        public override string Habitat { get => Habitat; set => Habitat = "Streams and Ocean"; }

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

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
}
