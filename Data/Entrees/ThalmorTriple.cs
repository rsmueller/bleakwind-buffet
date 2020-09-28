using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: ThalmorTriple.cs
 * Purpose: Implements the Thalmor Triple burger entree
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class for representing the Thalmor Triple Entree
	/// </summary>
	public class ThalmorTriple : Entree
	{
		/// <summary>
		/// The display name of the Thalmor Triple
		/// </summary>
		public override string DisplayName => "Thalmor Triple";

		private double price = 8.32;
		/// <summary>
		/// The price of the Thalmor Triple
		/// </summary>
		public override double Price => price;

        private uint calories = 943;
		/// <summary>
		/// The calories in the Thalmor Triple
		/// </summary>
		public override uint Calories => calories;

        private static string description = "Think you are strong enough to take on the Thalmor? Includes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
		/// <summary>
		/// The description of the Thalmor Triple
		/// </summary>
		public override string Description => description;

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Thalmor Triple
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold Bun", "Hold Ketchup", "Hold Mustard", "Hold Pickle", "Hold Cheese", "Hold Tomato", "Hold Lettuce", "Hold Mayo", "Hold Bacon", "Hold Egg" };

		/// <summary>
		/// If the Thalmor Triple has a bun
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
		/// If the Thalmor Triple has ketchup
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
		/// If the Thalmor Triple has mustard
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
		/// If the Thalmor Triple has pickles
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
		/// If the Thalmor Triple has cheese
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
		/// If the Thalmor Triple has tomato
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
		/// If the Thalmor Triple has lettuce
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
		/// If the Thalmor Triple has mayo
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
		/// If the Thalmor Triple has bacon
		/// </summary>
		public bool Bacon {
			get { return !specialInstructions.Contains(possibleInstructions[8]); }
			set {
				if (value == Bacon) return;
				if (!value) specialInstructions.Add(possibleInstructions[8]);
				else specialInstructions.Remove(possibleInstructions[8]);
			}
		}
		/// <summary>
		/// If the Thalmor Triple has egg
		/// </summary>
		public bool Egg {
			get { return !specialInstructions.Contains(possibleInstructions[9]); }
			set {
				if (value == Egg) return;
				if (!value) specialInstructions.Add(possibleInstructions[9]);
				else specialInstructions.Remove(possibleInstructions[9]);
			}
		}
		/// <summary>
		/// Returns a description of the Thalmor Triple
		/// </summary>
		/// <returns>A string describing the Thalmor Triple</returns>
		public override string ToString()
		{
			return "Thalmor Triple";
		}

	}
}
