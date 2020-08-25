using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: Entree.cs
 * Purpose: Provides a base templete for all entrees
 */
namespace Data.Entrees
{
	abstract class Entree
	{
		public abstract double Price { get; }
		public abstract uint Calories { get; }
		public abstract string Description { get; }
		public abstract List<string> SpecialInstructions { get; }

		/// <summary>
		/// A String representation of the Entree
		/// </summary>
		/// <returns>The Entree's name</returns>
		public override abstract string ToString();
	}
}
