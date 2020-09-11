/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Aretino Apple Juice Drink
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(x);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var x = new AretinoAppleJuice();
            Assert.False(x.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var x = new AretinoAppleJuice();
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var x = new AretinoAppleJuice();
            x.Ice = true;
            Assert.True(x.Ice);
            x.Ice = false;
            Assert.False(x.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new AretinoAppleJuice();
            x.Size = Size.Large;
            Assert.Equal(Size.Large, x.Size);
            x.Size = Size.Medium;
            Assert.Equal(Size.Medium, x.Size);
            x.Size = Size.Small;
            Assert.Equal(Size.Small, x.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var x = new AretinoAppleJuice();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var x = new AretinoAppleJuice();
            x.Size = size;
            Assert.Equal(cal, x.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var x = new AretinoAppleJuice();
            x.Ice = includeIce;
            if (includeIce)
            {
                Assert.Contains("Add Ice", x.SpecialInstructions);
            }
            else
            {
                Assert.Empty(x.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var x = new AretinoAppleJuice();
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }
    }
}