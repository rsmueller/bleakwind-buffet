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
    /// <summary>
    /// Tests for the Vokun Salad Side
    /// </summary>
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldHaveCorrectDisplayName()
        {
            var x = new VokunSalad();
            Assert.Equal("Vokun Salad", x.DisplayName);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }


        [Fact]
        public void ShouldBeAssignableToBaseSide()
        {
            var x = new VokunSalad();
            Assert.IsAssignableFrom<Side>(x);
        }


        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new VokunSalad();
            Assert.IsAssignableFrom<Side>(x);
        }
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

        [Fact]
        public void ShouldNotifySizePropertyChanged()
        {
            var x = new VokunSalad();

            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyPricePropertyChanged()
        {
            var x = new VokunSalad();

            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyCaloriesPropertyChanged()
        {
            var x = new VokunSalad();

            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Small; });
        }
    }
}