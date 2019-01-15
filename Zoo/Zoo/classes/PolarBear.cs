using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public class PolarBear : Bear
    {
        public override bool Omnivore { get => base.Omnivore; set => base.Omnivore = false; }
        public override int LitterSize { get => LitterSize; set => LitterSize = 2; }
        public override string Habitat { get => Habitat; set => Habitat = "Artic"; }
        public override string Diet { get => Diet; set => Diet = "Seals"; }

        public override string Fish()
        {
            return base.Fish();
        }

        public override string Nurse()
        {
            return base.Nurse();
        }

        public override string Play()
        {
            return base.Play();
        }

        public override string Eat()
        {
            return $"Eats {Diet}";
        }

        public override string Sleep()
        {
            return "Sleeps in snow banks";
        }

        public string Swim()
        {
           return $"Swims in the {Habitat}";
        }

    }
}
