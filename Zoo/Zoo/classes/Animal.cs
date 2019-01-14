using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
   public abstract class Animal
    {
        abstract public string Habitat { get; set; }
        abstract public string Diet { get; set; }

        abstract public void Sleep();
        abstract public void Eat();
        virtual public void Play()
        {
            Console.WriteLine("Plays with friends");
        }

    }
}
