using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: SailorSoda.cs
 * Purpose: Implements the Sailor Soda drink
 */
namespace Data.Drinks
{
	public class SailorSoda : Drink
	{
		
		double[] priceArray = { 1.42, 1.74, 2.07 };
		public override double Price => priceArray[(uint)size];

		private uint[] caloriesArray = { 117, 153, 205 };
		public override uint Calories => caloriesArray[(uint)size];
		
		private Size size = Size.Small;
		public override Size Size => size;

		private SodaFlavor flavor = SodaFlavor.Cherry;
		public SodaFlavor Flavor => flavor;

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private string[] possibleInstructions = { "Hold Ice" };

		public override bool Ice {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Ice) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}

		public override string ToString()
		{

			return $"{size} {flavor} Sailor Soda";
		}
	}
}
