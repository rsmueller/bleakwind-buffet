using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: AretinoAppleJuice.cs
 * Purpose: Implements the Aretino Apple Juice drink
 */
namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Class for representing the Aretino Apple Juice drink
	/// </summary>
	public class AretinoAppleJuice : Drink
	{
		/// <summary>
		/// The display name of the Aretino Apple Juice
		/// </summary>
		public override string DisplayName => "Aretino Apple Juice";

		private static double[] priceArray = { .62, .87, 1.01 };
		/// <summary>
		/// The price of the Aretino Apple Juice
		/// </summary>
		public override double Price => priceArray[(uint)size];

		private static uint[] caloriesArray = { 44, 88, 132 };
		/// <summary>
		/// The calories in the Aretino Apple Juice
		/// </summary>
		public override uint Calories => caloriesArray[(uint)size];

		private Size size = Size.Small;
		/// <summary>
		/// The size of the Aretino Apple Juice
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

		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Aretino Apple Juice
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = { "Add Ice" };


		/// <summary>
		/// If the Aretino Apple Juice has ice in it
		/// </summary>
		public override bool Ice {
			//notice missing ! for get and 2nd if, this is intended
			//because operates on an "add" basis not conventional "hold" basis.
			get { return specialInstructions.Contains(possibleInstructions[0]); }
			set {
				if (value == Ice) return;
				if (value) specialInstructions.Add(possibleInstructions[0]);
				else specialInstructions.Remove(possibleInstructions[0]);
				OnPropertyChanged("Ice");
				OnPropertyChanged("SpecialInstructions");
			}
		}

		/// <summary>
		/// Returns a description of the Aretino Apple Juice
		/// </summary>
		/// <returns>A string describing the Aretino Apple Juice</returns>
		public override string ToString()
		{
			return $"{size} Aretino Apple Juice";
		}
	}
}
