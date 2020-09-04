using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: Drink.cs
 * Purpose: Provides a base templete for all drinks
 */
namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Class for representing a general drink
	/// </summary>
	public abstract class Drink
	{
		/// <summary>
		/// The price of the drink
		/// </summary>
		public abstract double Price { get; }
		/// <summary>
		/// The calories in the drink
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// A list of special instructions for preparing the drink
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }
		/// <summary>
		/// The size of the drink
		/// </summary>
		public abstract Enums.Size Size { get; set; }
		/// <summary>
		/// If the drink has ice in it
		/// </summary>
		public abstract bool Ice { get; set; }

		/// <summary>
		/// Returns a description of the drink
		/// </summary>
		/// <returns>A string describing the drink</returns>
		public override abstract string ToString();
	}
}
