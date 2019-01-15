using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public class LionFish : Fish
    {
        public override string WaterType { get => WaterType; set => WaterType = "Salt"; }
        public override int NumberOfGills { get => NumberOfGills; set => NumberOfGills = 4; }
        public override string Habitat { get => Habitat; set => Habitat = "Ocean"; }
        public override string Diet { get => Diet; set => Diet = "Smaller Fish"; }

        public override string Eat()
        {
            return "Eats smaller fish";
        }

        public override string Sleep()
        {
            return "Sleeps in the ocean";
        }

        public override string Swim()
        {
            return "Swims in salt water";
        }
    }
}
