using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: SailorSoda.cs
 * Purpose: Implements the Sailor Soda drink
 */
namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Class for representing the Sailor Soda drink
	/// </summary>
	public class SailorSoda : Drink
	{
		/// <summary>
		/// The display name of the Sailor Soda
		/// </summary>
		public override string DisplayName => "Sailor Soda";

		private static double[] priceArray = { 1.42, 1.74, 2.07 };
		/// <summary>
		/// The price of the Sailor Soda
		/// </summary>
		public override double Price => priceArray[(uint)size];

		private static uint[] caloriesArray = { 117, 153, 205 };
		/// <summary>
		/// The calories in the Sailor Soda
		/// </summary>
		public override uint Calories => caloriesArray[(uint)size];
		
		private Size size = Size.Small;
		/// <summary>
		/// The size of the Sailor Soda
		/// </summary>
		public override Size Size {
			get => size;
			set {
				size = value;
				OnPropertyChanged("Calories");
				OnPropertyChanged("Price");
				OnPropertyChanged("Size");
			}
		}

		private SodaFlavor flavor = SodaFlavor.Blackberry;
		/// <summary>
		/// The flavor of the Sailor Soda
		/// </summary>
		public SodaFlavor Flavor { get => flavor; 
			set {
				flavor = value;
				OnPropertyChanged("Flavor");
			}
		}

		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Sailor Soda
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Hold Ice" };

		/// <summary>
		/// If the Sailor Soda has ice in it
		/// </summary>
		public override bool Ice {
			get { return !specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Ice) return;
				if (!value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
				OnPropertyChanged("Ice");
				OnPropertyChanged("SpecialInstructions");
			}
		}
		/// <summary>
		/// Returns a description of the Sailor Soda
		/// </summary>
		/// <returns>A string describing the Sailor Soda</returns>
		public override string ToString()
		{

			return $"{size} {flavor} Sailor Soda";
		}
	}
}
