/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
   
    /// <summary>
    /// Tests for the Garden Orc Omelette Entree
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldIncludeBroccoliByDefault()
        {
            var x = new GardenOrcOmelette();
            Assert.True(x.Broccoli);
        }

        [Fact]
        public void ShouldIncludeMushroomsByDefault()
        {
            var x = new GardenOrcOmelette();
            Assert.True(x.Mushrooms);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var x = new GardenOrcOmelette();
            Assert.True(x.Tomato);
        }

        [Fact]
        public void ShouldIncludeCheddarByDefault()
        {
            var x = new GardenOrcOmelette();
            Assert.True(x.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var x = new GardenOrcOmelette();
            x.Broccoli = false;
            Assert.False(x.Broccoli);
            x.Broccoli = true;
            Assert.True(x.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var x = new GardenOrcOmelette();
            x.Mushrooms = false;
            Assert.False(x.Mushrooms);
            x.Mushrooms = true;
            Assert.True(x.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var x = new GardenOrcOmelette();
            x.Tomato = false;
            Assert.False(x.Tomato);
            x.Tomato = true;
            Assert.True(x.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var x = new GardenOrcOmelette();
            x.Cheddar = false;
            Assert.False(x.Cheddar);
            x.Cheddar = true;
            Assert.True(x.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var x = new GardenOrcOmelette();
            Assert.Equal(4.57, x.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var x = new GardenOrcOmelette();
            Assert.Equal((uint)404, x.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var x = new GardenOrcOmelette();
            
            x.Broccoli = includeBroccoli;
            x.Mushrooms = includeMushrooms;
            x.Tomato = includeTomato;
            x.Cheddar = includeCheddar;

            if (includeBroccoli)
            {
                Assert.DoesNotContain("Hold Broccoli", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Broccoli", x.SpecialInstructions);
            }
            if (includeMushrooms)
            {
                Assert.DoesNotContain("Hold Mushrooms", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Mushrooms", x.SpecialInstructions);
            }
            if (includeTomato)
            {
                Assert.DoesNotContain("Hold Tomato", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Tomato", x.SpecialInstructions);
            }
            if (includeCheddar)
            {
                Assert.DoesNotContain("Hold Cheddar", x.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Cheddar", x.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var x = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", x.ToString());
        }
    }
}