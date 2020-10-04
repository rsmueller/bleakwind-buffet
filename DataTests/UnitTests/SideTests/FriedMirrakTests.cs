/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests for the Fried Miraak Side
    /// </summary>
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldHaveCorrectDisplayName()
        {
            var x = new FriedMiraak();
            Assert.Equal("Fried Miraak", x.DisplayName);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }


        [Fact]
        public void ShouldBeAssignableToBaseSide()
        {
            var x = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(x);
        }


        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(x);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var x = new FriedMiraak();
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new FriedMiraak();
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
            var x = new FriedMiraak();
            Assert.Empty(x.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var x = new FriedMiraak();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var x = new FriedMiraak();
            x.Size = size;
            Assert.Equal(calories, x.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var x = new FriedMiraak();
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }

        [Fact]
        public void ShouldNotifySizePropertyChanged()
        {
            var x = new FriedMiraak();

            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyPricePropertyChanged()
        {
            var x = new FriedMiraak();

            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyCaloriesPropertyChanged()
        {
            var x = new FriedMiraak();

            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Small; });
        }
    }
}