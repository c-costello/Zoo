using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public class GreyWolf : Mammal
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

        public override string Nurse()
        {
            return "Nurses pups";
        }

        public override string Eat()
        {
            return $"Eats {Diet}";
        }

        public override string Sleep()
        {
            return $"Sleeps in the {Habitat}";
        }
    }
    
}
