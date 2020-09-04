/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Candlehearth Coffee Drink
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var x = new CandlehearthCoffee();
            Assert.False(x.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var x = new CandlehearthCoffee();
            Assert.False(x.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var x = new CandlehearthCoffee();
            Assert.False(x.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var x = new CandlehearthCoffee();   
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var x = new CandlehearthCoffee();
            x.Ice = true;
            Assert.True(x.Ice);
            x.Ice = false;
            Assert.False(x.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var x = new CandlehearthCoffee();
            x.Decaf = true;
            Assert.True(x.Decaf);
            x.Decaf = false;
            Assert.False(x.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var x = new CandlehearthCoffee();
            x.RoomForCream = true;
            Assert.True(x.RoomForCream);
            x.RoomForCream = false;
            Assert.False(x.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new CandlehearthCoffee();
            x.Size = Size.Large;
            Assert.Equal(Size.Large, x.Size);
            x.Size = Size.Medium;
            Assert.Equal(Size.Medium, x.Size);
            x.Size = Size.Small;
            Assert.Equal(Size.Small, x.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var x = new CandlehearthCoffee();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var x = new CandlehearthCoffee();
            x.Size = size;
            Assert.Equal(cal, x.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var x = new CandlehearthCoffee();
            x.Ice = includeIce;
            x.RoomForCream = includeCream;
            if (includeIce)
            {
                Assert.Contains("Add Ice", x.SpecialInstructions);
            }
            else
            {
                Assert.DoesNotContain("Add Ice", x.SpecialInstructions);
            }
            if (includeCream)
            {
                Assert.Contains("Add Cream", x.SpecialInstructions);
            }
            else
            {
                Assert.DoesNotContain("Add Cream", x.SpecialInstructions);
            }

            if (!includeIce && !includeCream)
            {
                Assert.Empty(x.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            var x = new CandlehearthCoffee();
            x.Decaf = decaf;
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }
    }
}
