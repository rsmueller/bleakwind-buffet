using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: PhillyPoacher.cs
 * Purpose: Implements the PhillyPoacher entree
 */
namespace Data.Entrees
{
	public class PhillyPoacher : Entree
	{
		private double price = 7.23;
		public override double Price => price;

		private uint calories = 784;
		public override uint Calories => calories;

		private static string description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
		public override string Description => description;

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold sirloin", "Hold onion", "Hold roll" };

		public bool Sirloin {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Sirloin) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}
		public bool Onion {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Onion) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}
		public bool Roll {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == Roll) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
			}
		}

		public override string ToString()
		{
			return "Philly Poacher";
		}
	}
}
