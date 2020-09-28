/*
 * Author: Zachery Brunner
 * Class name: Size.cs
 * Purpose: Class used to represent sizes through an enumeration
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Enums
{
    /// <summary>
    /// Provides available sizes
    /// </summary>
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    /// <summary>
    /// Provides an IEnumerable of Sizes
    /// </summary>
    public static class Sizes
    {
        /// <summary>
        /// Returns IEnumerable of sizes
        /// </summary>
        /// <returns>An IEnumerable of sizes</returns>
        public static IEnumerable<Size> GetSizes()
		{
            yield return Size.Small;
            yield return Size.Medium;
            yield return Size.Large;
		}
    }
}