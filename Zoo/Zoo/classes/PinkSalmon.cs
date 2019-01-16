using System;
using System.Collections.Generic;
using System.Text;
using Zoo.interfaces;

namespace Zoo.classes
{
    public class PinkSalmon : Salmon , IEatsBugs
    {
        public bool HasHump { get => HasHump; set => HasHump = true;}

        public override string Habitat { get => Habitat; set => Habitat = "Oceans and Streams"; }
        public string favoriteBug { get; set; } = "Lacewing Fly";

        public override string Eat()
        {
            return "Eats herring";
        }

        public string EatsBugs()
        {
            return "Loves to eat bugs!";
        }

        public override string Migrate()
        {
            return "Migrates from Ocean to streams and rivers";
        }

        public override string Sleep()
        {
            return "Sleeps in salt/fresh water";
        }

        public override string Swim()
        {
            return "Swims in salt/fresh water";
        }
    }
}
