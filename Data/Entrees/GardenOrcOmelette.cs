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
	public class GardenOrcOmelette : Entree
	{
		
		double price = 4.57;
		public override double Price => price;

		private uint calories = 404;
		public override uint Calories => calories;

		private static string description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
		public override string Description => description;

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold brocoli", "Hold tomato", "Hold mushrooms", "Hold cheddar" };

		public bool Brocoli {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Brocoli) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
			}
		}
		public bool Tomato {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Tomato) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}
		public bool Mushrooms {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == Mushrooms) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
			}
		}
		public bool Cheddar {
			get { return !specialInstructions.Contains(possibleInstructions[3]); }
			set {
				if (value == Cheddar) return;
				if (!value) specialInstructions.Add(possibleInstructions[3]);
				else specialInstructions.Remove(possibleInstructions[3]);
			}
		}

		public override string ToString()
		{
			return "Garden Orc Omelette";
		}
	}
}
