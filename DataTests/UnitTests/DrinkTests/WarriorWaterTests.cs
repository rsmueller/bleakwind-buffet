/*
 * Author: Riley Mueller
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Tests for the Warrior Water Drink
    /// </summary>
	public class WarriorWaterTests
	{
        [Fact]
        public void ShouldHaveCorrectDisplayName()
        {
            var x = new WarriorWater();
            Assert.Equal("Warrior Water", x.DisplayName);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }

        [Fact]
        public void ShouldBeAssignableToBaseDrink()
        {
            var x = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(x);
        }
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(x);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var x = new WarriorWater();
            Assert.True(x.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            var x = new WarriorWater();
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            var x = new WarriorWater();
            x.Ice = false;
            Assert.False(x.Ice);
            x.Ice = true;
            Assert.True(x.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new WarriorWater();
            x.Size = Size.Large;
            Assert.Equal(Size.Large, x.Size);
            x.Size = Size.Medium;
            Assert.Equal(Size.Medium, x.Size);
            x.Size = Size.Small;
            Assert.Equal(Size.Small, x.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var x = new WarriorWater();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var x = new WarriorWater();
            x.Size = size;
            Assert.Equal(cal, x.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            var x = new WarriorWater();
            x.Ice = includeIce;
            x.Lemon = includeLemon;
            if (includeIce)
            {
                Assert.DoesNotContain("Hold Ice", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Ice", x.SpecialInstructions);
            }
            if (includeLemon)
            {
                Assert.Contains("Add Lemon", x.SpecialInstructions);
            }
            else
            {
                Assert.DoesNotContain("Add Lemon", x.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var x = new WarriorWater();
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }

        [Fact]
        public void ShouldNotifySizePropertyChanged()
        {
            var x = new WarriorWater();

            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Size", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyPricePropertyChanged()
        {
            var x = new WarriorWater();

            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Price", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyCaloriesPropertyChanged()
        {
            var x = new WarriorWater();

            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Large; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Medium; });
            Assert.PropertyChanged(x, "Calories", () => { x.Size = Size.Small; });
        }

        [Fact]
        public void ShouldNotifyIcePropertyChanged()
        {
            var x = new WarriorWater();

            Assert.PropertyChanged(x, "Ice", () => { x.Ice = false; });
            Assert.PropertyChanged(x, "Ice", () => { x.Ice = true; });
        }

        [Fact]
        public void ShouldNotifyLemonPropertyChanged()
        {
            var x = new WarriorWater();

            Assert.PropertyChanged(x, "Lemon", () => { x.Lemon = true; });
            Assert.PropertyChanged(x, "Lemon", () => { x.Lemon = false; });
        }
    }
}
