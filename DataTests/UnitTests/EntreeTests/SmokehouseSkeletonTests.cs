/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Smokehouse Skeleton Entree
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            var x = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(x);
        }
        [Fact]
        public void ShouldBeAssignableToBaseEntree()
        {
            var x = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(x);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var x = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(x);
        }
        [Fact]
        public void ShouldIncludeSausageByDefault()
        {
            var x = new SmokehouseSkeleton();
            Assert.True(x.SausageLink);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var x = new SmokehouseSkeleton();
            Assert.True(x.Egg);
        }

        [Fact]
        public void ShouldIncludeHashbrownsByDefault()
        {
            var x = new SmokehouseSkeleton();
            Assert.True(x.HashBrowns);
        }

        [Fact]
        public void ShouldIncludePancakeByDefault()
        {
            var x = new SmokehouseSkeleton();
            Assert.True(x.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            var x = new SmokehouseSkeleton();
            x.SausageLink = false;
            Assert.False(x.SausageLink);
            x.SausageLink = true;
            Assert.True(x.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var x = new SmokehouseSkeleton();
            x.Egg = false;
            Assert.False(x.Egg);
            x.Egg = true;
            Assert.True(x.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            var x = new SmokehouseSkeleton();
            x.HashBrowns = false;
            Assert.False(x.HashBrowns);
            x.HashBrowns = true;
            Assert.True(x.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            var x = new SmokehouseSkeleton();
            x.Pancake = false;
            Assert.False(x.Pancake);
            x.Pancake = true;
            Assert.True(x.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var x = new SmokehouseSkeleton();
            Assert.Equal(5.62, x.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var x = new SmokehouseSkeleton();
            Assert.Equal((uint)602, x.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var x = new SmokehouseSkeleton();
            x.SausageLink = includeSausage;
            x.Egg = includeEgg;
            x.HashBrowns = includeHashbrowns;
            x.Pancake = includePancake;

            if (includeSausage)
            {
                Assert.DoesNotContain("Hold Sausage", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Sausage", x.SpecialInstructions);
            }
            if (includeEgg)
            {
                Assert.DoesNotContain("Hold Egg", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Egg", x.SpecialInstructions);
            }
            if (includeHashbrowns)
            {
                Assert.DoesNotContain("Hold Hash Browns", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Hash Browns", x.SpecialInstructions);
            }
            if (includePancake)
            {
                Assert.DoesNotContain("Hold Pancake", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Pancake", x.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var x = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", x.ToString());
        }
    }
}