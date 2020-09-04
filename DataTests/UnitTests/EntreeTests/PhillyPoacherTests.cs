/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Philly Poacher Entree
    /// </summary>
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldIncludeSirloinByDefault()
        {
            var x = new PhillyPoacher();
            Assert.True(x.Sirloin);
        }

        [Fact]
        public void ShouldIncludeOnionByDefault()
        {
            var x = new PhillyPoacher();
            Assert.True(x.Onion);
        }

        [Fact]
        public void ShouldIncludeRollByDefault()
        {
            var x = new PhillyPoacher();
            Assert.True(x.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var x = new PhillyPoacher();
            x.Sirloin = false;
            Assert.False(x.Sirloin);
            x.Sirloin = true;
            Assert.True(x.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var x = new PhillyPoacher();
            x.Onion = false;
            Assert.False(x.Onion);
            x.Onion = true;
            Assert.True(x.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var x = new PhillyPoacher();
            x.Roll = false;
            Assert.False(x.Roll);
            x.Roll = true;
            Assert.True(x.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var x = new PhillyPoacher();
            Assert.Equal(7.23, x.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var x = new PhillyPoacher();
            Assert.Equal((uint)784, x.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            var x = new PhillyPoacher();

            x.Sirloin = includeSirloin;
            x.Onion = includeOnion;
            x.Roll = includeRoll;

            if (includeSirloin)
            {
                Assert.DoesNotContain("Hold Sirloin", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Sirloin", x.SpecialInstructions);
            }
            if (includeOnion)
            {
                Assert.DoesNotContain("Hold Onion", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Onion", x.SpecialInstructions);
            }
            if (includeRoll)
            {
                Assert.DoesNotContain("Hold Roll", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Roll", x.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var x = new PhillyPoacher();
            Assert.Equal("Philly Poacher", x.ToString());
        }
    }
}