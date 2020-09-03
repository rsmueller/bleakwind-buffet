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
	public class ThugsTBone : Entree
	{
		private double price = 6.44;
		public override double Price => price;

		private uint calories = 982;
		public override uint Calories => calories;

		private static string description = "Juicy T-Bone not much else to say";
		public override string Description => description;

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		public override string ToString()
		{
			return "Thugs T-Bone";
		}
	}
}
