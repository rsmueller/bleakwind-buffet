using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Author: Riley Mueller
 * Class Name: Side.cs
 * Purpose: Provides a base templete for all sides
 */
namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// Class for representing a general side
	/// </summary>
	public abstract class Side : IOrderItem, INotifyPropertyChanged
	{
		/// <summary>
		/// The display name of the side
		/// </summary>
		public abstract string DisplayName { get; }
		/// <summary>
		/// Price of the side
		/// </summary>
		public abstract double Price { get; }
		/// <summary>
		/// Calories in the side
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// A list of special instructions for preparing the side
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }
		/// <summary>
		/// The size of the side
		/// </summary>
		public abstract Enums.Size Size { get; set; }

		/// <summary>
		/// Event invoked when a property is changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Wrapper method so that child classes may invoke PropertyChanged
		/// </summary>
		/// <param name="propertyName">String representing the property name</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>
		/// Returns a description of the side
		/// </summary>
		/// <returns>A string describing the side/returns>
		public override abstract string ToString();
	}
}
