using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: FriedMiraak.cs
 * Purpose: Implements the Fried Miraak side
 */
namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// Class for representing the Fried Miraak side
	/// </summary>
	public class FriedMiraak : Side
	{
		/// <summary>
		/// The display name of the Fried Miraak
		/// </summary>
		public override string DisplayName => "Fried Miraak";

		private static double[] priceArray = { 1.78, 2.01, 2.88 };
		/// <summary>
		/// The price of the Fried Miraak
		/// </summary>
		public override double Price => priceArray[(int)size];

        private static uint[] caloriesArray = { 151, 236, 306 };
		/// <summary>
		/// The calories in the Fried Miraak
		/// </summary>
		public override uint Calories => caloriesArray[(int)size];

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Fried Miraak
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		/// <summary>
		/// The size of the Fried Miraak
		/// </summary>
		public override Size Size { get => size; set => size = value; }

		/// <summary>
		/// Returns a description of the Fried Miraak
		/// </summary>
		/// <returns>A string describing the Fried Miraak</returns>
		public override string ToString()
		{
			return $"{size.ToString()} Fried Miraak";
		}
	}
}
