/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Tests for the Mad Otar Grits Side
    /// </summary>
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(x);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var x = new MadOtarGrits();
            Assert.Equal(Size.Small, x.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new MadOtarGrits();
            x.Size = Size.Large;
            Assert.Equal(Size.Large, x.Size);
            x.Size = Size.Medium;
            Assert.Equal(Size.Medium, x.Size);
            x.Size = Size.Small;
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            var x = new MadOtarGrits();
            Assert.Empty(x.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var x = new MadOtarGrits();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var x = new MadOtarGrits();
            x.Size = size;
            Assert.Equal(calories, x.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var x = new MadOtarGrits();
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }
    }
}