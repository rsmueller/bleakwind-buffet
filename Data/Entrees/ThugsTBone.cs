using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: ThugsTBone.cs
 * Purpose: Implements the Thugs T-Bone entree
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class for representing the Thugs T-Bone entree
	/// </summary>
	public class ThugsTBone : Entree
	{
		private double price = 6.44;
		/// <summary>
		/// The price of the Thugs T-Bone
		/// </summary>
		public override double Price => price;

        private uint calories = 982;
		/// <summary>
		/// The calories in the Thugs T-Bone
		/// </summary>
		public override uint Calories => calories;

        private static string description = "Juicy T-Bone not much else to say";
		/// <summary>
		/// The description of the Thugs T-Bone
		/// </summary>
		public override string Description => description;

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Thugs T-Bone
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// Returns a description of the Thugs T-Bone
		/// </summary>
		/// <returns>A string describing the Thugs T-Bone</returns>
		/// <returns></returns>
		public override string ToString()
		{
			return "Thugs T-Bone";
		}
	}
}
