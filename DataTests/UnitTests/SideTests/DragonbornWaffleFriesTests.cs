﻿/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests for the Dragonborn Waffle Fries Side
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldHaveCorrectDisplayName()
        {
            var x = new DragonbornWaffleFries();
            Assert.Equal("Dragonborn Waffle Fries", x.DisplayName);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }

        [Fact]
        public void ShouldBeAssignableToBaseSide()
        {
            var x = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(x);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(x);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var x = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new DragonbornWaffleFries();
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
            var x = new DragonbornWaffleFries();
            Assert.Empty(x.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var x = new DragonbornWaffleFries();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var x = new DragonbornWaffleFries();
            x.Size = size;
            Assert.Equal(calories, x.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var x = new DragonbornWaffleFries();
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }

        [Fact]
        public void ShouldNotifySizePropertyChanged()
        {
            var x = new DragonbornWaffleFries();

            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyPricePropertyChanged()
        {
            var x = new DragonbornWaffleFries();

            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyCaloriesPropertyChanged()
        {
            var x = new DragonbornWaffleFries();

            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Small; });
        }

    }
}