using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: WarriorWater.cs
 * Purpose: Implements the Warrior Water drink
 */
namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Class for representing the Warrior Water drink
	/// </summary>
	public class WarriorWater : Drink
	{
		/// <summary>
		/// The display name of the Warrior Water
		/// </summary>
		public override string DisplayName => "Warrior Water";

		private static double[] priceArray = { 0, 0, 0 };
		/// <summary>
		/// The price of the Warrior Water
		/// </summary>
		public override double Price => priceArray[(uint)size];

		private static uint[] caloriesArray = { 0, 0, 0 };
		/// <summary>
		/// The calories in the Warrior Water
		/// </summary>
		public override uint Calories => caloriesArray[(uint)size];

		private Size size = Size.Small;
		/// <summary>
		/// The size of the Warrior Water
		/// </summary>
		public override Size Size { get => size; set => size = value; }

		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Warrior Water
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold Ice", "Add Lemon" };

		/// <summary>
		/// If the Warrior Water has ice in it
		/// </summary>
		public override bool Ice {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Ice) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}
		/// <summary>
		/// If the Warrior Water has lemon in it
		/// </summary>
		public bool Lemon {
			//notice missing ! for get and 2nd if, this is intended
			//because operates on an "add" basis not conventional "hold" basis.
			get { return specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Lemon) return;
				if (value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}
		/// <summary>
		/// Returns a description of the Warrior Water
		/// </summary>
		/// <returns>A string describing the Warrior Water</returns>
		public override string ToString()
		{
			return $"{size} Warrior Water";
		}
	}
}
