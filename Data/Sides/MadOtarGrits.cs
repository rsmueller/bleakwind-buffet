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
		private static double[] priceArray = { 1.22, 1.58, 1.93 };
		public override double Price => priceArray[(int)size];

		private static uint[] caloriesArray = { 105, 142, 179 };
		public override uint Calories => caloriesArray[(int)size];

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		public override Size Size { get => size; set => size = value; }

		public override string ToString()
		{
			return $"{size.ToString()} Mad Otar Grits";
		}
	}
}
