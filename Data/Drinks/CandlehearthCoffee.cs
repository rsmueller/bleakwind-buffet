using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: CandlehearthCoffee.cs
 * Purpose: Implements the Candlehearth Coffee drink
 */
namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Class for representing the Candlehearth Coffee drink
	/// </summary>
	public class CandlehearthCoffee : Drink
	{
		
		private static double[] priceArray = { 0.75, 1.25, 1.75 };
		/// <summary>
		/// The price of the Candlehearth Coffee
		/// </summary>
		public override double Price => priceArray[(uint)size];

        private static uint[] caloriesArray = { 7, 10, 20 };
		/// <summary>
		/// The calories in the Candlehearth Coffee
		/// </summary>
		public override uint Calories => caloriesArray[(uint)size];

		private Size size = Size.Small;
		/// <summary>
		/// The size of the Candlehearth Coffee
		/// </summary>
		public override Size Size { get => size; set => size = value; }

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Candlehearth Coffee
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Add Ice", "Add Cream" };

		/// <summary>
		/// If the Candlehearth Coffee has ice in it
		/// </summary>
		public override bool Ice {
			//notice missing ! for get and 2nd if, this is intended
			//because operates on an "add" basis not conventional "hold" basis.
			get { return specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Ice) return;
				if (value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}

		/// <summary>
		/// If room for cream should be left in the Candlehearth Coffee
		/// </summary>
		public bool RoomForCream {
			//notice missing ! for get and 2nd if, this is intended
			//because operates on an "add" basis not conventional "hold" basis.
			get { return specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == RoomForCream) return;
				if (value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}

		/// <summary>
		/// If the Candlehearth Coffee is decaf
		/// </summary>
		public bool Decaf { get; set; }

		/// <summary>
		/// Returns a description of the Candlehearth Coffee
		/// </summary>
		/// <returns>A string describing the Candlehearth Coffee</returns>
		public override string ToString()
		{
			string sizeString = size.ToString();

			if (Decaf)
				sizeString = sizeString + " Decaf";

			return $"{sizeString} Candlehearth Coffee";
		}
	}
}
