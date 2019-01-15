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

        //lion fish
        [Fact]
        public void LionFishInheritEat()
        {
            LionFish lionFish = new LionFish();
            Assert.Equal("Eats smaller fish", lionFish.Eat());
        }

        [Fact]
        public void LionFishInheritSwim()
        {
            LionFish lionFish = new LionFish();
            Assert.Equal("Swims in salt water", lionFish.Swim());
        
        }

        //Coho 
        [Fact]
        public void CohoInheritMigrate()
        {
            Coho coho = new Coho();
            Assert.Equal("Migrates from the ocean to the rivers", coho.Migrate());
        }
        [Fact]
        public void CohoInheritSleep()
        {
            Coho coho = new Coho();
            Assert.Equal("Sleeps in the water", coho.Sleep());
        }
        //pink salmon
        [Fact]
        public void PinkSalmonInheritEat()
        {
            PinkSalmon pinkSalmon = new PinkSalmon();
            Assert.Equal("Eats herring", pinkSalmon.Eat());
        }
        [Fact]
        public void PinkSalmonInheritSwim()
        {
            PinkSalmon pinkSalmon = new PinkSalmon();
            Assert.Equal("Swims in salt/fresh water", pinkSalmon.Swim());
        }


        // interface tests
        [Fact]
        public void BlackBearsEatBugs()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("Digs up beetles to eat!", blackBear.EatsBugs());
        }

        [Fact]
        public void BlackBearsRun()
        {
            BlackBear blackBear = new BlackBear();
            Assert.Equal("Runs Really Fast", blackBear.Run());
        }

        [Fact]
        public void PinkSalmonEatBugs()
        {
            PinkSalmon pinkSalmon = new PinkSalmon();
            Assert.Equal("Lacewing Fly", pinkSalmon.favoriteBug);
        }

        //PolyMorphism
        [Fact]
        public void GreyWolvesAreAnimals()
        {
            GreyWolf greyWolf = new GreyWolf();
            bool TestMethod(Animal animal){
                if (animal != null)
                {
                    return true;
                }
                else return false;
            }
            Assert.True(TestMethod(greyWolf));
        }

    }
}
