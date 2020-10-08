using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using Xunit;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests
{
	public class ComboTests
	{
		[Fact]
		public void ShouldHaveCorrectDisplayName()
		{
			var x = new Combo();
			Assert.Equal("Combo", x.DisplayName);
		}

		[Fact]
		public void ShouldHaveCorrectStartPrice()
		{
			var x = new Combo();
			x.Entree = new TestEntree();
			x.Side = new TestSide();
			x.Drink = new TestDrink();
			//entree 100, side 5, drink 3, discount of 1 dollar = 107
			Assert.Equal(107, x.Price);
		}

		[Fact]
		public void ShouldHaveCorrectStartCalories()
		{
			var x = new Combo();
			x.Entree = new TestEntree();
			x.Side = new TestSide();
			x.Drink = new TestDrink();
			//entree 333 side 200 drink 10
			Assert.Equal((uint)543, x.Calories);
		}

		[Fact]
		public void ShouldHaveCorrectPriceDifferentSizes()
		{
			var x = new Combo();
			x.Entree = new TestEntree();
			x.Side = new TestSide();
			x.Drink = new TestDrink();
			//entree 100, side 5, drink 3, discount of 1 dollar = 107
			Assert.Equal(107, x.Price);
			//500
			x.Side.Size = Size.Large;
			//7
			x.Drink.Size = Size.Large;
			Assert.Equal(606, x.Price);
		}

		[Fact]
		public void ShouldHaveCorrectCaloriesDifferentSizes()
		{
			var x = new Combo();
			x.Entree = new TestEntree();
			x.Side = new TestSide();
			x.Drink = new TestDrink();
			//entree 333 side 200 drink 10
			Assert.Equal((uint)543, x.Calories);
			//400
			x.Side.Size = Size.Large;
			//1000
			x.Drink.Size = Size.Large;
			Assert.Equal((uint)1733, x.Calories);
		}

		[Fact]
		public void ShouldHaveCorrectSpecialInstructions()
		{
			var x = new Combo();
			x.Entree = new TestEntree();
			x.Side = new TestSide();
			x.Drink = new TestDrink();
			List<string> init = new List<string>{ x.Entree.DisplayName, x.Side.DisplayName, x.Drink.DisplayName};
			Assert.Collection<string>(x.SpecialInstructions,
				str => Assert.Equal(x.Entree.DisplayName, str),
				str => Assert.Equal(x.Side.DisplayName, str),
				str => Assert.Equal(x.Drink.DisplayName, str));
			((TestEntree)x.Entree).PartA = false;
			Assert.Collection<string>(x.SpecialInstructions,
				str => Assert.Equal(x.Entree.DisplayName, str),
				str => Assert.Equal("PartA", str),
				str => Assert.Equal(x.Side.DisplayName, str),
				str => Assert.Equal(x.Drink.DisplayName, str));
		}

		[Fact]
		public void AddingEntreeTriggersPropertyChanged()
		{
			var x = new Combo();
			Assert.PropertyChanged(x, "Entree", () => { x.Entree = new TestEntree(); });
		}

		[Fact]
		public void AddingSideTriggersPropertyChanged()
		{
			var x = new Combo();
			Assert.PropertyChanged(x, "Side", () => { x.Side = new TestSide(); });
		}
		[Fact]
		public void AddingDrinkTriggersPropertyChanged()
		{
			var x = new Combo();
			Assert.PropertyChanged(x, "Drink", () => { x.Drink = new TestDrink(); });
		}

		[Fact]
		public void ChangingPriceTriggersPropertyChanged()
		{
			var x = new Combo();
			x.Side = new TestSide();
			x.Drink = new TestDrink();
			Assert.PropertyChanged(x, "Price", () => { x.Side.Size = Size.Large; });
			Assert.PropertyChanged(x, "Price", () => { x.Side.Size = Size.Large; });
		}

		[Fact]
		public void ChangingCaloriesTriggersPropertyChanged()
		{
			var x = new Combo();
			x.Side = new TestSide();
			x.Drink = new TestDrink();
			Assert.PropertyChanged(x, "Calories", () => { x.Side.Size = Size.Large; });
			Assert.PropertyChanged(x, "Calories", () => { x.Side.Size = Size.Large; });
		}

		[Fact]
		public void ChangingSpecialInstructionsTriggersPropertyChanged()
		{
			var x = new Combo();
			TestEntree entree = new TestEntree();
			x.Entree = entree;
			x.Drink = new TestDrink();
			Assert.PropertyChanged(x, "SpecialInstructions", () => { entree.PartA = false; });
			Assert.PropertyChanged(x, "SpecialInstructions", () => { entree.PartA = true; });
			Assert.PropertyChanged(x, "SpecialInstructions", () => { x.Drink.Ice = false; });
			Assert.PropertyChanged(x, "SpecialInstructions", () => { x.Drink.Ice = true; });
		}
	}

	class TestEntree : Entree
	{
		public override string DisplayName => "Test Entree";

		public override double Price => 100;

		public override uint Calories => 333;

		public override string Description => "For testing in ComboTests.cs";

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		private static string[] possibleInstructions = { "PartA", "PartB", "PartC" };

		public bool PartA {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == PartA) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
				OnPropertyChanged("PartA");
				OnPropertyChanged("SpecialInstructions");
			}
		}
		/// <summary>
		/// If the Philly Poacher has onion
		/// </summary>
		public bool PartB {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == PartB) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
				OnPropertyChanged("PartB");
				OnPropertyChanged("SpecialInstructions");
			}
		}
		/// <summary>
		/// If the Philly Poacher has a roll
		/// </summary>
		public bool PartC {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == PartC) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
				OnPropertyChanged("PartC");
				OnPropertyChanged("SpecialInstructions");
			}
		}

		public override string ToString()
		{
			return "A Test Entree";
		}
	}

	class TestSide : Side
	{
		public override string DisplayName => "Test Side";

		private static double[] priceArray = { 5, 50, 500 };
		
		public override double Price => priceArray[(int)size];

		private static uint[] caloriesArray = { 200, 300, 400 };

		public override uint Calories => caloriesArray[(int)size];

		private List<string> specialInstructions = new List<string>();
		
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		/// <summary>
		/// The size of the Mad Otar Grits
		/// </summary>
		public override Size Size {
			get => size;
			set {
				size = value;
				OnPropertyChanged("Calories");
				OnPropertyChanged("Price");
				OnPropertyChanged("Size");
			}
		}
		public override string ToString()
		{
			return "A Test Side";
		}
	}

	class TestDrink : Drink
	{
		public override string DisplayName => "Test Drink";

		private static double[] priceArray = { 3, 5, 7 };
		
		public override double Price => priceArray[(uint)size];

		private static uint[] caloriesArray = { 10, 100, 1000 };
		
		public override uint Calories => caloriesArray[(uint)size];

		private Size size = Size.Small;
		
		public override Size Size {
			get => size;
			set {
				size = value;
				OnPropertyChanged("Calories");
				OnPropertyChanged("Price");
				OnPropertyChanged("Size");
			}
		}

		private List<string> specialInstructions = new List<string>();
		
		public override List<string> SpecialInstructions => specialInstructions;

		public override bool Ice {
			get { return !specialInstructions.Contains("Hold Ice"); }
			set {
				if (value == Ice) return;
				if (!value) specialInstructions.Add("Hold Ice");
				else specialInstructions.Remove("Hold Ice");
				OnPropertyChanged("Ice");
				OnPropertyChanged("SpecialInstructions");
			}
		}
		public override string ToString()
		{
			return "A Test Drink";
		}
	}

}
