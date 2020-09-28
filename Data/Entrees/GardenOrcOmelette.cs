using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: GardenOrcOmelette.cs
 * Purpose: Implements the GardenOrcOmelette breakfast combo entree
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// A class representing the Garden Orc Omelette
	/// </summary>
	public class GardenOrcOmelette : Entree
	{
		/// <summary>
		/// The display name of the Garden Orc Omelette
		/// </summary>
		public override string DisplayName => "Garden Orc Omelette";

		private double price = 4.57;
		/// <summary>
		/// The price of the Garden Orc Omelette
		/// </summary>
		public override double Price => price;

        private uint calories = 404;
		/// <summary>
		/// The calories in the Garden Orc Omelette
		/// </summary>
		public override uint Calories => calories;

        private static string description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
		/// <summary>
		/// The description of the Garden Orc Omelette
		/// </summary>
		public override string Description => description;

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Garden Orc Omelette
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold Broccoli", "Hold Tomato", "Hold Mushrooms", "Hold Cheddar" };

		/// <summary>
		/// If the Garden Orc Omelette has broccoli
		/// </summary>
		public bool Broccoli {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Broccoli) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}
		/// <summary>
		/// If the Garden Orc Omelette has tomato
		/// </summary>
		public bool Tomato {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Tomato) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}
		/// <summary>
		/// If the Garden Orc Omelette has mushrooms
		/// </summary>
		public bool Mushrooms {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == Mushrooms) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
			}
		}
		/// <summary>
		/// If the Garden Orc Omelette has cheddar in it
		/// </summary>
		public bool Cheddar {
			get { return !specialInstructions.Contains(possibleInstructions[3]); }
			set {
				if (value == Cheddar) return;
				if (!value) specialInstructions.Add(possibleInstructions[3]);
				else specialInstructions.Remove(possibleInstructions[3]);
			}
		}

		/// <summary>
		/// Returns a description of the Garden Orc Omelette
		/// </summary>
		/// <returns>A string describing the Garden Orc Omelette</returns>
		public override string ToString()
		{
			return "Garden Orc Omelette";
		}
	}
}
