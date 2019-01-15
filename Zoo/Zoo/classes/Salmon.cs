using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.classes
{
    public abstract class Salmon : Fish
    {

        public virtual int RunCycleYears { get => RunCycleYears; set => RunCycleYears = 1;} 
        public override string Diet { get => Diet; set => Diet = "Herring, Squid"; }
        public override string WaterType { get => WaterType; set => WaterType = "Fresh/Salt"; }
        public override int NumberOfGills { get => NumberOfGills; set => NumberOfGills = 2; }

        public abstract string Migrate();
    }
}
