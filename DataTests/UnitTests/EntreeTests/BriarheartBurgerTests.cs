/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Briarheart Burger Entree
    /// </summary>
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }
        [Fact]
        public void ShouldBeAssignableToBaseEntree()
        {
            var x = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(x);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(x);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var x = new BriarheartBurger();
            Assert.True(x.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var x = new BriarheartBurger();
            Assert.True(x.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var x = new BriarheartBurger();
            Assert.True(x.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var x = new BriarheartBurger();
            Assert.True(x.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var x = new BriarheartBurger();
            Assert.True(x.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var x = new BriarheartBurger();
            x.Bun = false;
            Assert.False(x.Bun);
            x.Bun = true;
            Assert.True(x.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var x = new BriarheartBurger();
            x.Ketchup = false;
            Assert.False(x.Ketchup);
            x.Ketchup = true;
            Assert.True(x.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var x = new BriarheartBurger();
            x.Mustard = false;
            Assert.False(x.Mustard);
            x.Mustard = true;
            Assert.True(x.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var x = new BriarheartBurger();
            x.Pickle = false;
            Assert.False(x.Pickle);
            x.Pickle = true;
            Assert.True(x.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var x = new BriarheartBurger();
            x.Cheese = false;
            Assert.False(x.Cheese);
            x.Cheese = true;
            Assert.True(x.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var x = new BriarheartBurger();
            Assert.Equal(6.32, x.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var x = new BriarheartBurger();
            Assert.Equal((uint)743, x.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            var x = new BriarheartBurger();
            x.Bun = includeBun;
            x.Ketchup = includeKetchup;
            x.Mustard = includeMustard;
            x.Pickle = includePickle;
            x.Cheese = includeCheese;

			if (includeBun)
			{
                Assert.DoesNotContain("Hold Bun", x.SpecialInstructions);
			}
			else
			{
                Assert.Contains("Hold Bun", x.SpecialInstructions);
			}
            if (includeKetchup)
            {
                Assert.DoesNotContain("Hold Ketchup", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Ketchup", x.SpecialInstructions);
            }
            if (includeMustard)
            {
                Assert.DoesNotContain("Hold Mustard", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Mustard", x.SpecialInstructions);
            }
            if (includePickle)
            {
                Assert.DoesNotContain("Hold Pickle", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Pickle", x.SpecialInstructions);
            }
            if (includeCheese)
            {
                Assert.DoesNotContain("Hold Cheese", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Cheese", x.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var x = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", x.ToString());
        }
    }
}