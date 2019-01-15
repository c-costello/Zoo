using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public class PinkSalmon : Salmon
    {
        public bool HasHump { get => HasHump; set => HasHump = true;}

        public override string Habitat { get => Habitat; set => Habitat = "Oceans and Streams"; }

        public override string Eat()
        {
            return $"Eats {Diet}";
        }

        public override string Migrate()
        {
            return "Migrates from Ocean to streams and rivers";
        }

        public override string Sleep()
        {
            return $"Sleeps in {WaterType} water";
        }

        public override string Swim()
        {
            return $"Swims in {WaterType} water";
        }
    }
}
