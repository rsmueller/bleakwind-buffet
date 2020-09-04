using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: AretinoAppleJuice.cs
 * Purpose: Implements the Aretino Apple Juice drink
 */
namespace BleakwindBuffet.Data.Drinks
{
	public class AretinoAppleJuice : Drink
	{
		
		private static double[] priceArray = { .62, .87, 1.01 };
		public override double Price => priceArray[(uint)size];

		private static uint[] caloriesArray = { 44, 88, 132 };
		public override uint Calories => caloriesArray[(uint)size];

		private Size size = Size.Small;
		public override Size Size { get => size; set => size = value; }

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Add Ice" };

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

		public override string ToString()
		{
			return $"{size} Aretino Apple Juice";
		}
	}
}
