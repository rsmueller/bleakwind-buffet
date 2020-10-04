using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

/*
 * Author: Riley Mueller
 * Class Name: Entree.cs
 * Purpose: Provides a base templete for all entrees
 */
namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Class for representing a general entree
	/// </summary>
	public abstract class Entree : IOrderItem, INotifyPropertyChanged
	{
		/// <summary>
		/// The display name of the entree
		/// </summary>
		public abstract string DisplayName { get; }
		/// <summary>
		/// The price of the entree
		/// </summary>
		public abstract double Price { get; }
		/// <summary>
		/// The calories in the entree
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// The description of the entree
		/// </summary>
		public abstract string Description { get; }
		/// <summary>
		/// A list of special instructions for preparing the entree
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }

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
		/// Returns a description of the entree
		/// </summary>
		/// <returns>A string describing the entree</returns>
		public override abstract string ToString();
	}
}
