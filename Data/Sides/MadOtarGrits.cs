using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: MadOtarGrits.cs
 * Purpose: Implements the Mad Otar Grits side
 */
namespace BleakwindBuffet.Data.Sides
{
	public class MadOtarGrits : Side
	{
		private static double[] priceArray = { .93, 1.28, 1.82 };
		public override double Price => priceArray[(int)size];

		private static uint[] caloriesArray = { 41, 52, 73 };
		public override uint Calories => caloriesArray[(int)size];

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		public override Size Size => size;

		public override string ToString()
		{
			return $"{size.ToString()} Mad Otar Grits";
		}
	}
}
