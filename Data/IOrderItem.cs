﻿using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: IOrderItem.cs
 * Purpose: Interface for properties all orderable items should have
 */
namespace BleakwindBuffet.Data
{
	/// <summary>
	/// Interace representing an orderable item
	/// </summary>
	public interface IOrderItem
	{

		/// <summary>
		/// The string that should be displayed as a menu item
		/// </summary>
		public string DisplayName { get; }

		/// <summary>
		/// The price of the item
		/// </summary>
		public double Price { get; }
		/// <summary>
		/// The calories in the item
		/// </summary>
		public uint Calories { get; }
		/// <summary>
		/// A list of special instructions for preparing the item
		/// </summary>
		public List<string> SpecialInstructions { get; }

		/// <summary>
		/// A brief sentence describing the OrderItem.
		/// </summary>
		public string Description { get; }


	}
}
