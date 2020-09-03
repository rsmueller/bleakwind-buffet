using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: VokunSalad.cs
 * Purpose: Implements the Vakun Salad side
 */
namespace Data.Sides
{
	public class VokunSalad : Side
	{
		private static double[] priceArray = { .93, 1.28, 1.82};
		public override double Price => priceArray[(int)size];

		private static uint[] caloriesArray = { 41, 52, 73};
		public override uint Calories => caloriesArray[(int)size];

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		public override Size Size => size;

		public override string ToString()
		{
			return $"{size.ToString()} Vokun Salad";
		}
	}
}
