using Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: DragonbornWaffleFries.cs
 * Purpose: Implements the Dragonbord Waffle Fries side
 */
namespace Data.Sides
{
	public class DragonbornWaffleFries : Side
	{
		private double[] priceArray = { .42, .76, .96 };
		public override double Price => priceArray[(int)size];

		private uint[] caloriesArray = { 77, 89, 100 };
		public override uint Calories => caloriesArray[(int)size];

		private List<string> specialInstructions = new List<string>();
		public override List<string> SpecialInstructions => specialInstructions;

		private Size size;
		public override Size Size => size;

		public override string ToString()
		{
			return $"{size.ToString()} Dragonborn Waffle Fries";
		}
	}
}
