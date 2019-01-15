using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
   public abstract class Animal
    {
        abstract public string Habitat { get; set; }
        abstract public string Diet { get; set; }

        abstract public string Sleep();
        abstract public string Eat();
        virtual public string Play()
        {
            return "Plays with friends";
        }
    }
}
