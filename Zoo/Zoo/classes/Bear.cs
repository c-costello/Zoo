﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public abstract class Bear : Mammal
    {
        public virtual bool Omnivore { get => Omnivore; set => Omnivore = true; }

        public override bool LivesInGroups { get => base.LivesInGroups; set => base.LivesInGroups = false; }

        public virtual string Fish()
        {
            return "Fish";
        }
    }
}
