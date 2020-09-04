﻿/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var x = new MarkarthMilk();
            Assert.False(x.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            var x = new MarkarthMilk();
            Assert.Equal(Size.Small, x.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            var x = new MarkarthMilk();
            x.Ice = true;
            Assert.True(x.Ice);
            x.Ice = false;
            Assert.False(x.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var x = new MarkarthMilk();
            x.Size = Size.Large;
            Assert.Equal(Size.Large, x.Size);
            x.Size = Size.Medium;
            Assert.Equal(Size.Medium, x.Size);
            x.Size = Size.Small;
            Assert.Equal(Size.Small, x.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var x = new MarkarthMilk();
            x.Size = size;
            Assert.Equal(price, x.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var x = new MarkarthMilk();
            x.Size = size;
            Assert.Equal(cal, x.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var x = new MarkarthMilk();
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
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var x = new MarkarthMilk();
            x.Size = size;
            Assert.Equal(name, x.ToString());
        }
    }
}