using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    abstract class Mammal : Animal
    {
        abstract public int LitterSize { get; set; }
        virtual public int LivesInGroups { get; set; }

        virtual public void Nurse()
        {
            Console.WriteLine("Nursing");
        }


    }
}
