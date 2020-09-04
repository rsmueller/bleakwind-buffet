using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: BriarheartBurger.cs
 * Purpose: Implements the braiarheart burger entree
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class for representing the Briarheart Burger entree
	/// </summary>
	public class BriarheartBurger : Entree
	{
		
		
		double price = 6.32;
		/// <summary>
		/// The price of the Briarheart Burger
		/// </summary>
		public override double Price => price;

		
		uint calories = 743;
		/// <summary>
		/// The calories in the Briarheart Burger
		/// </summary>
		public override uint Calories => calories;


        string description = "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
		/// <summary>
		/// The description of the Briarheart Burger
		/// </summary>
		public override string Description => description;

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions to prepare the Briarheart Burger
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the bools: Bun, Ketchup, Mustard, Pickle, and Cheese rely on this order.
		/// </summary>
		private static string[] possibleInstructions = {"Hold Bun", "Hold Ketchup", "Hold Mustard", "Hold Pickle", "Hold Cheese"};

		/// <summary>
		/// If the Briarheart Burger has a bun
		/// </summary>
		public bool Bun
        {
            get { return !specialInstructions.Contains(possibleInstructions[0]); }
            set
            {
                if (value == Bun) return;
                if (!value) specialInstructions.Add(possibleInstructions[0]);
                else specialInstructions.Remove(possibleInstructions[0]);
            }
        }
		/// <summary>
		/// If the Briarheart Burger has ketchup
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
		/// If the Briarheart Burger has mustard
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
		/// If the Briarheart Burger has pickles
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
		/// If the Briarheart Burger has cheese
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
		/// Returns a description of the Briarheart Burger
		/// </summary>
		/// <returns>A string describing the Briarheart Burger</returns>
		public override string ToString()
		{
			return "Briarheart Burger";
		}
	}
}
