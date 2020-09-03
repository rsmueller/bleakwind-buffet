using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: FriedMiraak.cs
 * Purpose: Implements the Fried Miraak side
 */
namespace Data.Sides
{
	public class FriedMiraak : Side
	{
		private static double[] priceArray = { 1.78, 2.01, 2.88 };
		public override double Price => priceArray[(int)size];

		private static uint[] caloriesArray = { 151, 236, 306 };
		public override uint Calories => caloriesArray[(int)size];

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		public override Size Size => size;

		public override string ToString()
		{
			return $"{size.ToString()} Fried Miraak";
		}
	}
}
