using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: MadOtarGrits.cs
 * Purpose: Implements the Mad Otar Grits side
 */
namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// Class for representing the Mad Otar Grits side
	/// </summary>
	public class MadOtarGrits : Side
	{
		/// <summary>
		/// The display name of the Mad Otar Grits
		/// </summary>
		public override string DisplayName => "Mad Otar Grits";

		private static double[] priceArray = { 1.22, 1.58, 1.93 };
		/// <summary>
		/// The price of the Mad Otar Grits
		/// </summary>
		public override double Price => priceArray[(int)size];

        private static uint[] caloriesArray = { 105, 142, 179 };
		/// <summary>
		/// The calories in the Mad Otar Grits
		/// </summary>
		public override uint Calories => caloriesArray[(int)size];

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Mad Otar Grits
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		/// <summary>
		/// The size of the Mad Otar Grits
		/// </summary>
		public override Size Size { get => size; set => size = value; }


		/// <summary>
		/// Returns a description of the Mad Otar Grits
		/// </summary>
		/// <returns>A string describing the Mad Otar Grits</returns>
		public override string ToString()
		{
			return $"{size.ToString()} Mad Otar Grits";
		}
	}
}
