using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: DoubleDraugr.cs
 * Purpose: Implements the double draugr burger entree
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class for representing the Double Draugr entree
	/// </summary>
	public class DoubleDraugr : Entree
	{
        double price = 7.32;
		/// <summary>
		/// The price of the Double Draugr
		/// </summary>
		public override double Price => price;

        uint calories = 843;
		/// <summary>
		/// The calories in the Double Draugr
		/// </summary>
		public override uint Calories => calories;

        string description = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
		/// <summary>
		/// The description of the Double Draugr
		/// </summary>
		public override string Description => description;

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Double Draugr
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold Bun", "Hold Ketchup", "Hold Mustard", "Hold Pickle", "Hold Cheese", "Hold Tomato", "Hold Lettuce", "Hold Mayo" };

		/// <summary>
		/// If the Double Draugr has a bun
		/// </summary>
		public bool Bun {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Bun) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}
		/// <summary>
		/// If the Double Draugr has ketchup
		/// </summary>
		public bool Ketchup {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Ketchup) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}
		/// <summary>
		/// If the Double Draugr has mustard
		/// </summary>
		public bool Mustard {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == Mustard) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
			}
		}
		/// <summary>
		/// If the Double Draugr has pickles
		/// </summary>
		public bool Pickle {
			get { return !specialInstructions.Contains(possibleInstructions[3]); }
			set {
				if (value == Pickle) return;
				if (!value) specialInstructions.Add(possibleInstructions[3]);
				else specialInstructions.Remove(possibleInstructions[3]);
			}
		}
		/// <summary>
		/// If the Double Draugr has cheese
		/// </summary>
		public bool Cheese {
			get { return !specialInstructions.Contains(possibleInstructions[4]); }
			set {
				if (value == Cheese) return;
				if (!value) specialInstructions.Add(possibleInstructions[4]);
				else specialInstructions.Remove(possibleInstructions[4]);
			}
		}
		/// <summary>
		/// If the Double Draugr has tomato
		/// </summary>
		public bool Tomato {
			get { return !specialInstructions.Contains(possibleInstructions[5]); }
			set {
				if (value == Tomato) return;
				if (!value) specialInstructions.Add(possibleInstructions[5]);
				else specialInstructions.Remove(possibleInstructions[5]);
			}
		}
		/// <summary>
		/// If the Double Draugr has lettuce
		/// </summary>
		public bool Lettuce {
			get { return !specialInstructions.Contains(possibleInstructions[6]); }
			set {
				if (value == Lettuce) return;
				if (!value) specialInstructions.Add(possibleInstructions[6]);
				else specialInstructions.Remove(possibleInstructions[6]);
			}
		}
		/// <summary>
		/// If the Double Draugr has mayo
		/// </summary>
		public bool Mayo {
			get { return !specialInstructions.Contains(possibleInstructions[7]); }
			set {
				if (value == Mayo) return;
				if (!value) specialInstructions.Add(possibleInstructions[7]);
				else specialInstructions.Remove(possibleInstructions[7]);
			}
		}


		/// <summary>
		/// Returns a description of the Double Draugr
		/// </summary>
		/// <returns>A string describing the Double Draugr</returns>
		public override string ToString()
		{
			return "Double Draugr";
		}

	}
}
