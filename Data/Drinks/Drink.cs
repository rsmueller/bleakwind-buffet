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
	public abstract class Drink
	{
		public abstract double Price { get; }
		public abstract uint Calories { get; }
		public abstract List<string> SpecialInstructions { get; }
		public abstract Enums.Size Size { get; }
		public abstract bool Ice { get; set; }

		/// <summary>
		/// A String representation of the Entree
		/// </summary>
		/// <returns>The Entree's name</returns>
		public override abstract string ToString();
	}
}
