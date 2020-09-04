/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Tests for the Thugs T-Bone Entree
    /// </summary>
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var x = new ThugsTBone();
            Assert.Equal(6.44, x.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var x = new ThugsTBone();
            Assert.Equal((uint)982, x.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var x = new ThugsTBone();
            Assert.Empty(x.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var x = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", x.ToString());
        }
    }
}