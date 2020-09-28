using System.Collections.Generic;
/*
 * Author: Riley Mueller
 * Class Name: SodaFlavor.cs
 * Purpose: Represents all possible soda flavors through enumeration
 */
namespace BleakwindBuffet.Data.Enums
{
	/// <summary>
	/// Provides available soda flavors
	/// </summary>
	public enum SodaFlavor
	{
		Blackberry,
		Cherry,
		Grapefruit,
		Lemon,
		Peach,
		Watermelon
	}

	/// <summary>
	/// Provides an IEnumerable of soda flavors
	/// </summary>
	public static class SodaFlavors
	{
		/// <summary>
		/// Returns IEnumerable of soda flavors
		/// </summary>
		/// <returns>An IEnumerable of soda flavors</returns>
		public static IEnumerable<SodaFlavor> GetFlavors()
		{
			yield return SodaFlavor.Blackberry;
			yield return SodaFlavor.Cherry;
			yield return SodaFlavor.Grapefruit; 
			yield return SodaFlavor.Lemon;
			yield return SodaFlavor.Peach; 
			yield return SodaFlavor.Watermelon;
		}
	}
}
