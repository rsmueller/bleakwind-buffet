using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: PhillyPoacher.cs
 * Purpose: Implements the PhillyPoacher entree
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class for representing the Philly Poacher entree
	/// </summary>
	public class PhillyPoacher : Entree
	{
		/// <summary>
		/// The display name of the Philly Poacher
		/// </summary>
		public override string DisplayName => "Philly Poacher";

		private double price = 7.23;
		/// <summary>
		/// The price of the Philly Poacher
		/// </summary>
		public override double Price => price;

		private uint calories = 784;
		/// <summary>
		/// The calories in the Philly Poacher
		/// </summary>
		public override uint Calories => calories;

        private static string description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
		/// <summary>
		/// The description of the Philly Poacher
		/// </summary>
		public override string Description => description;

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Philly Poacher
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold Sirloin", "Hold Onion", "Hold Roll" };

		/// <summary>
		/// If the Philly Poacher has sirloin
		/// </summary>
		public bool Sirloin {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Sirloin) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
				OnPropertyChanged("Sirloin");
				OnPropertyChanged("SpecialInstructions");
			}
		}
		/// <summary>
		/// If the Philly Poacher has onion
		/// </summary>
		public bool Onion {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Onion) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
				OnPropertyChanged("Onion");
				OnPropertyChanged("SpecialInstructions");
			}
		}
		/// <summary>
		/// If the Philly Poacher has a roll
		/// </summary>
		public bool Roll {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == Roll) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
				OnPropertyChanged("Roll");
				OnPropertyChanged("SpecialInstructions");
			}
		}
		/// <summary>
		/// Returns a description of the Warrior Water
		/// </summary>
		/// <returns>A string describing the Warrior Water</returns>
		public override string ToString()
		{
			return "Philly Poacher";
		}
	}
}
