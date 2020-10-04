using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: DragonbornWaffleFries.cs
 * Purpose: Implements the Dragonbord Waffle Fries side
 */
namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// Class for representing the Dragonborn Waffle Fries side
	/// </summary>
	public class DragonbornWaffleFries : Side
	{
		/// <summary>
		/// The display name of the Dragonborn Waffle Fries
		/// </summary>
		public override string DisplayName => "Dragonborn Waffle Fries";

		private static double[] priceArray = { .42, .76, .96 };
		/// <summary>
		/// The price of the Dragonborn Waffle Fries
		/// </summary>
		public override double Price => priceArray[(int)size];

        private static uint[] caloriesArray = { 77, 89, 100 };
		/// <summary>
		/// The calories in the Dragonborn Waffle Fries
		/// </summary>
		public override uint Calories => caloriesArray[(int)size];

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Dragonborn Waffle Fries
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		/// <summary>
		/// The size of the Dragonborn Waffle Fries
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

		/// <summary>
		/// Returns a description of the Dragonborn Waffle Fries
		/// </summary>
		/// <returns>A string describing the Dragonborn Waffle Fries</returns>
		public override string ToString()
		{
			return $"{size.ToString()} Dragonborn Waffle Fries";
		}
	}
}
