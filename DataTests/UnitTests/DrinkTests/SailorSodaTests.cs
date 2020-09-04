/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Sailor Soda Drink
    /// </summary>
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var x = new SailorSoda();
            Assert.True(x.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var x = new SailorSoda();
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            var x = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, x.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var x = new SailorSoda();
            x.Ice = false;
            Assert.False(x.Ice); 
            x.Ice = true;
            Assert.True(x.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new SailorSoda();
            x.Size = Size.Large;
            Assert.Equal(Size.Large, x.Size);
            x.Size = Size.Medium;
            Assert.Equal(Size.Medium, x.Size);
            x.Size = Size.Small;
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            var x = new SailorSoda();
            //large enough sample
            x.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, x.Flavor);
            x.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, x.Flavor);
            x.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, x.Flavor);
            x.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, x.Flavor);
            x.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, x.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var x = new SailorSoda();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var x = new SailorSoda();
            x.Size = size;
            Assert.Equal(cal, x.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var x = new SailorSoda();
            x.Ice = includeIce;
            if (includeIce)
            {
                Assert.Empty(x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Ice", x.SpecialInstructions);
            }
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            var x = new SailorSoda();
            x.Flavor = flavor; 
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }
    }
}
