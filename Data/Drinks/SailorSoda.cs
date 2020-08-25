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
		private readonly double[] priceArray = { 1.42, 1.74, 2.07 };
		public override double Price => priceArray[(uint)size];

		private readonly uint[] caloriesArray = { 117, 153, 205 };
		public override uint Calories => caloriesArray[(uint)size];
		
		private readonly Size size = Size.Small;
		public override Size Size => size;

		private readonly SodaFlavor flavor = SodaFlavor.Cherry;
		public SodaFlavor Flavor => flavor;

		private readonly List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static readonly string[] possibleInstructions = { "Hold Ice" };

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
			string flavorString;
			switch (flavor)
			{
				case SodaFlavor.Blackberry:
					flavorString = "Blackberry";
					break;
				case SodaFlavor.Cherry:
					flavorString = "Cherry";
					break;
				case SodaFlavor.Grapefruit:
					flavorString = "Grapefruit";
					break;
				case SodaFlavor.Lemon:
					flavorString = "Lemon";
					break;
				case SodaFlavor.Peach:
					flavorString = "Peach";
					break;
				case SodaFlavor.Watermelon:
					flavorString = "Watermelon";
					break;
				default:
					flavorString = "FATAL ERROR AAAAAAAAAAAAAAAAAAAAAAH";
					break;
			}
			string sizeString;
			switch (size)
			{
				case Size.Small:
					sizeString = "Small";
					break;
				case Size.Medium:
					sizeString = "Medium";
					break;
				case Size.Large:
					sizeString = "Large";
					break;
				default:
					sizeString = "EVEN WORSE ERROR AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH";
					break;
			}
			return string.Format("{0} {1} Sailor Soda", sizeString, flavorString);
		}
	}
}
