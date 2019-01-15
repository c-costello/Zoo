using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    class PolarBear : Bear
    {
        public override bool Omnivore { get => base.Omnivore; set => base.Omnivore = false; }
        public override int LitterSize { get => LitterSize; set => LitterSize = 2; }
        public override string Habitat { get => Habitat; set => Habitat = "Artic"; }
        public override string Diet { get => Diet; set => Diet = "Seals"; }

        public override void Fish()
        {
            base.Fish();
        }

        public override void Nurse()
        {
            base.Nurse();
        }

        public override void Play()
        {
            base.Play();
        }

        public override void Eat()
        {
            Console.WriteLine("Eat");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public void Swim()
        {
            Console.WriteLine("Swim");
        }

    }
}
