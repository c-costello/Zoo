using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    class GreyWolf : Mammal
    {

        
        int PackSize { get; set; }
        public override string Habitat
        {
            get => Habitat;
            set => Habitat = "Forests";
        }
        public override string Diet { get => Diet; set => Diet = "Game"; }
        public override int LitterSize { get => LitterSize; set => LitterSize = 4; }
        public override bool LivesInGroups { get => LivesInGroups; set => LivesInGroups = true; }

        public override void Nurse()
        {
            Console.WriteLine("Nurse");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
    
}
