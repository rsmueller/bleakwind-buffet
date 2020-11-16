using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: VokunSalad.cs
 * Purpose: Implements the Vakun Salad side
 */
namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// Class for representing the Vokun Salad side
	/// </summary>
	public class VokunSalad : Side
	{
		/// <summary>
		/// The display name of the Vokun Salad
		/// </summary>
		public override string DisplayName => "Vokun Salad";

		private static double[] priceArray = { .93, 1.28, 1.82 };
		/// <summary>
		/// The price of the Vokun Salad
		/// </summary>
		public override double Price => priceArray[(int)size];

        private static uint[] caloriesArray = { 41, 52, 73 };
		/// <summary>
		/// The calories in the Vokun Salad
		/// </summary>
		public override uint Calories => caloriesArray[(int)size];

		string description = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
		/// <summary>
		/// The description of the Vokun Salad
		/// </summary>
		public override string Description => description;

		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Vokun Salad
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

        private Size size;
		/// <summary>
		/// The size of the Vokun Salad
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
		/// Returns a description of the Vokun Salad
		/// </summary>
		/// <returns>A string describing the Vokun Salad</returns>
		public override string ToString()
		{
			return $"{size.ToString()} Vokun Salad";
		}
	}
}
