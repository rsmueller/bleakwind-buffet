/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Thalmor Triple Burger Entree
    /// </summary>
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }
        [Fact]
        public void ShouldBeAssignableToBaseEntree()
        {
            var x = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(x);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(x);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var x = new ThalmorTriple();
            Assert.True(x.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var x = new ThalmorTriple();
            x.Bun = false;
            Assert.False(x.Bun);
            x.Bun = true;
            Assert.True(x.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var x = new ThalmorTriple();
            x.Ketchup = false;
            Assert.False(x.Ketchup);
            x.Ketchup = true;
            Assert.True(x.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var x = new ThalmorTriple();
            x.Mustard = false;
            Assert.False(x.Mustard);
            x.Mustard = true;
            Assert.True(x.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var x = new ThalmorTriple();
            x.Pickle = false;
            Assert.False(x.Pickle);
            x.Pickle = true;
            Assert.True(x.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var x = new ThalmorTriple();
            x.Cheese = false;
            Assert.False(x.Cheese);
            x.Cheese = true;
            Assert.True(x.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var x = new ThalmorTriple();
            x.Tomato = false;
            Assert.False(x.Tomato);
            x.Tomato = true;
            Assert.True(x.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var x = new ThalmorTriple();
            x.Lettuce = false;
            Assert.False(x.Lettuce);
            x.Lettuce = true;
            Assert.True(x.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var x = new ThalmorTriple();
            x.Mayo = false;
            Assert.False(x.Mayo);
            x.Mayo = true;
            Assert.True(x.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            var x = new ThalmorTriple();
            x.Bacon = false;
            Assert.False(x.Bacon);
            x.Bacon = true;
            Assert.True(x.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var x = new ThalmorTriple();
            x.Egg = false;
            Assert.False(x.Egg);
            x.Egg = true;
            Assert.True(x.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var x = new ThalmorTriple();
            Assert.Equal(8.32, x.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var x = new ThalmorTriple();
            Assert.Equal((uint)943, x.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            var x = new ThalmorTriple();
            x.Bun = includeBun;
            x.Ketchup = includeKetchup;
            x.Mustard = includeMustard;
            x.Pickle = includePickle;
            x.Cheese = includeCheese;
            x.Tomato = includeTomato;
            x.Lettuce = includeLettuce;
            x.Mayo = includeMayo;
            x.Bacon = includeBacon;
            x.Egg = includeEgg;

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
            if (includeTomato)
            {
                Assert.DoesNotContain("Hold Tomato", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Tomato", x.SpecialInstructions);
            }
            if (includeLettuce)
            {
                Assert.DoesNotContain("Hold Lettuce", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Lettuce", x.SpecialInstructions);
            }
            if (includeMayo)
            {
                Assert.DoesNotContain("Hold Mayo", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Mayo", x.SpecialInstructions);
            }
            if (includeBacon)
            {
                Assert.DoesNotContain("Hold Bacon", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Bacon", x.SpecialInstructions);
            }
            if (includeEgg)
            {
                Assert.DoesNotContain("Hold Egg", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Egg", x.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var x = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", x.ToString());
        }
    }
}