using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: DoubleDraugr.cs
 * Purpose: Implements the double draugr burger entree
 */
namespace Data.Entrees
{
	class DoubleDraugr : Entree
	{
		private readonly double price = 7.32;
		public override double Price => price;

		private readonly uint calories = 843;
		public override uint Calories => calories;

		private readonly string description = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
		public override string Description => description;

		private readonly List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static readonly string[] possibleInstructions = { "Hold Bun", "Hold ketchup", "Hold mustard", "Hold pickle", "Hold cheese", "Hold tomato", "Hold lettuce", "Hold mayo" };

		public bool Bun {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Bun) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}
		public bool Ketchup {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Ketchup) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}
		public bool Mustard {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == Mustard) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
			}
		}
		public bool Pickle {
			get { return !specialInstructions.Contains(possibleInstructions[3]); }
			set {
				if (value == Pickle) return;
				if (!value) specialInstructions.Add(possibleInstructions[3]);
				else specialInstructions.Remove(possibleInstructions[3]);
			}
		}
		public bool Cheese {
			get { return !specialInstructions.Contains(possibleInstructions[4]); }
			set {
				if (value == Cheese) return;
				if (!value) specialInstructions.Add(possibleInstructions[4]);
				else specialInstructions.Remove(possibleInstructions[4]);
			}
		}
		public bool Tomato {
			get { return !specialInstructions.Contains(possibleInstructions[5]); }
			set {
				if (value == Tomato) return;
				if (!value) specialInstructions.Add(possibleInstructions[5]);
				else specialInstructions.Remove(possibleInstructions[5]);
			}
		}
		public bool Lettuce {
			get { return !specialInstructions.Contains(possibleInstructions[6]); }
			set {
				if (value == Lettuce) return;
				if (!value) specialInstructions.Add(possibleInstructions[6]);
				else specialInstructions.Remove(possibleInstructions[6]);
			}
		}
		public bool Mayo {
			get { return !specialInstructions.Contains(possibleInstructions[7]); }
			set {
				if (value == Mayo) return;
				if (!value) specialInstructions.Add(possibleInstructions[7]);
				else specialInstructions.Remove(possibleInstructions[7]);
			}
		}

		public override string ToString()
		{
			return "Double Draugr Burger";
		}

	}
}
