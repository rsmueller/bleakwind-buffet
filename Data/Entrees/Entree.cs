using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: Entree.cs
 * Purpose: Provides a base templete for all entrees
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class for representing a general entree
	/// </summary>
	public abstract class Entree : IOrderItem
	{
		/// <summary>
		/// The price of the entree
		/// </summary>
		public abstract double Price { get; }
		/// <summary>
		/// The calories in the entree
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// The description of the entree
		/// </summary>
		public abstract string Description { get; }
		/// <summary>
		/// A list of special instructions for preparing the entree
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }

		/// <summary>
		/// Returns a description of the entree
		/// </summary>
		/// <returns>A string describing the entree</returns>
		public override abstract string ToString();
	}
}
