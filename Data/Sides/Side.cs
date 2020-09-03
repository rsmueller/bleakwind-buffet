using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: Side.cs
 * Purpose: Provides a base templete for all sides
 */
namespace BleakwindBuffet.Data.Sides
{
	public abstract class Side
	{
		public abstract double Price { get; }
		public abstract uint Calories { get; }
		public abstract List<string> SpecialInstructions { get; }
		public abstract Enums.Size Size { get; }
		
		/// <summary>
		/// A String representation of the Entree
		/// </summary>
		/// <returns>The Entree's name</returns>
		public override abstract string ToString();
	}
}
