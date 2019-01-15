using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public class Coho : Salmon
    {
        public override string Habitat { get => Habitat; set => Habitat = "Streams and Ocean"; }

        public override string Eat()
        {
            return $"Eats herring";
        }

        public override string Migrate()
        {
            return "Migrates from the ocean to the rivers";
        }

        public override string Sleep()
        {
            return $"Sleeps in the water";
        }

        public override string Swim()
        {
            return $"Swims in the water";
        }

        public string Jump()
        {
            return "Jumps out of the water to play and feed";
        }
    }
}
