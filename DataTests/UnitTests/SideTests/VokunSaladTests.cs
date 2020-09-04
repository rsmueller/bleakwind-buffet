/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var x = new VokunSalad();
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new VokunSalad();
            x.Size = Size.Large;
            Assert.Equal(Size.Large, x.Size);
            x.Size = Size.Medium;
            Assert.Equal(Size.Medium, x.Size);
            x.Size = Size.Small;
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var x = new VokunSalad();
            Assert.Empty(x.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var x = new VokunSalad();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var x = new VokunSalad();
            x.Size = size;
            Assert.Equal(calories, x.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var x = new VokunSalad();
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }
    }
}