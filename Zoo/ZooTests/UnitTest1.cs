using System;
using Xunit;
using Zoo;
using Zoo.classes;

namespace ZooTests
{
    public class UnitTest1
    {
        //black bear tests
        [Fact]
        public void BlackBearsInheritSleep()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("Sleeps in caves", blackBear.Sleep());
        }

        [Fact]
        public void BlackBearInheritsNurse()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("Nursing", blackBear.Nurse());
        }

        //polar bear tests
        [Fact]
        public void PolarBearsInheritPlay()
        {
            PolarBear polarBear = new PolarBear();
            Assert.Equal("Plays with friends", polarBear.Play());
        }

        [Fact]
        public void PolarBearsInheritEat()
        {
            PolarBear newPolarBear = new PolarBear();
            Assert.Equal("Eats Seals", newPolarBear.Eat());
        }

        //wolves
        [Fact]
        public void WolvesInheritSleep()
        {
            GreyWolf greyWolf = new GreyWolf();
            Assert.Equal("Sleeps in the forest", greyWolf.Sleep());
        }
        [Fact]
        public void WolvesInheritNurse()
        {
            GreyWolf greyWolf = new GreyWolf();
            Assert.Equal("Nurses pups", greyWolf.Nurse());
        }


    }
}
