using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: SmokehouseSkeleton.cs
 * Purpose: Implements the SmokehouseSkeleton breakfast combo entree
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class representing the Smokehouse Skeleton Entree
	/// </summary>
	public class SmokehouseSkeleton : Entree
	{
		private double price = 5.62;
		/// <summary>
		/// The price of the Smokehouse Skeleton
		/// </summary>
		public override double Price => price;

        private uint calories = 602;
		/// <summary>
		/// The calories in the Smokehouse Skeleton
		/// </summary>
		public override uint Calories => calories;

        private static string description = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
		/// <summary>
		/// The description of the Smokehouse Skeleton
		/// </summary>
		public override string Description => description;

        private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// A list of special instructions for preparing the Smokehouse Skeleton
		/// </summary>
		public override List<string> SpecialInstructions => specialInstructions;

		/// <summary>
		/// A list of possible special instruction strings that can be added to and removed from SpecialInstructions;
		/// Index order is very important as the ingredient bools rely on this order.
		/// </summary>
		private static string[] possibleInstructions = {"Hold Sausage", "Hold Egg", "Hold Hash Browns", "Hold Pancake"};

		/// <summary>
		/// If the Smokehouse Skeleton has sausage
		/// </summary>
		public bool SausageLink
        {
            get { return !specialInstructions.Contains(possibleInstructions[0]); }
            set
            {
                if (value == SausageLink) return;
                if (!value) specialInstructions.Add(possibleInstructions[0]);
                else specialInstructions.Remove(possibleInstructions[0]);
            }
        }
		/// <summary>
		/// If the Smokehouse Skeleton has egg
		/// </summary>
		public bool Egg {
			get { return !specialInstructions.Contains(possibleInstructions[1]); }
			set {
				if (value == Egg) return;
				if (!value) specialInstructions.Add(possibleInstructions[1]);
				else specialInstructions.Remove(possibleInstructions[1]);
			}
		}
		/// <summary>
		/// If the Smokehouse Skeleton has hash browns
		/// </summary>
		public bool HashBrowns {
			get { return !specialInstructions.Contains(possibleInstructions[2]); }
			set {
				if (value == HashBrowns) return;
				if (!value) specialInstructions.Add(possibleInstructions[2]);
				else specialInstructions.Remove(possibleInstructions[2]);
			}
		}
		/// <summary>
		/// If the Smokehouse Skeleton has pancake in it
		/// </summary>
		public bool Pancake {
			get { return !specialInstructions.Contains(possibleInstructions[3]); }
			set {
				if (value == Pancake) return;
				if (!value) specialInstructions.Add(possibleInstructions[3]);
				else specialInstructions.Remove(possibleInstructions[3]);
			}
		}
		/// <summary>
		/// Returns a description of the Smokehouse Skeleton
		/// </summary>
		/// <returns>A string describing the Smokehouse Skeleton</returns>
		public override string ToString()
		{
			return "Smokehouse Skeleton";
		}
	}
}
