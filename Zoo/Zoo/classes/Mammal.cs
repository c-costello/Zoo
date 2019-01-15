using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public abstract class Mammal : Animal
    {
        abstract public int LitterSize { get; set; }
        virtual public bool LivesInGroups { get; set; }

        virtual public string Nurse()
        {
            return "Nursing";
        }


    }
}
