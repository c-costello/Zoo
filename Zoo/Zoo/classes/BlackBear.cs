using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.classes
{
    public class BlackBear : Bear , IRun
    {
        public override int LitterSize { get => LitterSize; set => LitterSize = 3; }
        public override string Habitat { get => Habitat; set => Habitat = "Forest"; }
        public override string Diet { get => Diet; set => Diet = "Fruits, roots, bugs and small game"; }
        public int TopSpeed { get; set; } = 35;

        public override string Eat()
        {
            return $"Eats fruits, roots and small game";
        }

        public override string Sleep()
        {
            return "Sleeps in caves";   
        }
        public override string Nurse()
        {
            return base.Nurse();
        }
        public string Climb()
        {
            return "Climbs trees";
        }

        public string Run()
        {
            return "Runs Really Fast";
        }
    }
}
