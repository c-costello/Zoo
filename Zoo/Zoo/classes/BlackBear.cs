using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    class BlackBear : Bear
    {
        public override int LitterSize { get => LitterSize; set => LitterSize = 3; }
        public override string Habitat { get => Habitat; set => Habitat = "Forest"; }
        public override string Diet { get => Diet; set => Diet = "Fruits, roots, bugs and small game"; }

        public override void Eat()
        {
            Console.WriteLine("Eat");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep");
        }
        public override void Nurse()
        {
            base.Nurse();
        }
        public void Climb()
        {
            Console.WriteLine("Climb");
        }


    }
}
