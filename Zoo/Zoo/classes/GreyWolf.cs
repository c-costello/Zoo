using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.classes
{
    public class GreyWolf : Mammal , IRun
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
        public int TopSpeed { get; set; } = 37;

        public override string Nurse()
        {
            return "Nurses pups";
        }

        public override string Eat()
        {
            return $"Eats game";
        }

        public override string Sleep()
        {
            return "Sleeps in the forest";
        }

        public string Run()
        {
            return "Runs in a pack";
        }
    }
    
}
