using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public abstract class Fish : Animal
    {
        abstract public string WaterType { get; set; }
        abstract public int NumberOfGills { get; set; }

        abstract public string Swim();
    }
}
