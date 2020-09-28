using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
	/// <summary>
	/// Static class representing the menu of orderable items
	/// </summary>
	public static class Menu
	{
		/// <summary>
		/// Returns an instance of all available entrees offered by Bleakwind Buffet
		/// </summary>
		/// <returns>An enumerable instance of all the entrees</returns>
		public static IEnumerable<IOrderItem> Entrees()
		{
			return new List<IOrderItem>() {
				new BriarheartBurger(),
				new DoubleDraugr(),
				new GardenOrcOmelette(),
				new PhillyPoacher(),
				new SmokehouseSkeleton(),
				new ThalmorTriple(),
				new ThugsTBone()
			};
		}

		/// <summary>
		/// Returns an instance of all available sides offered by Bleakwind Buffet
		/// </summary>
		/// <returns>An enumerable instance of all the sides with every variable possible size</returns>
		public static IEnumerable<IOrderItem> Sides()
		{
			return new List<IOrderItem>() {
				new DragonbornWaffleFries{ Size = Size.Small},
				new DragonbornWaffleFries{ Size = Size.Medium},
				new DragonbornWaffleFries{ Size = Size.Large},

				new FriedMiraak{ Size = Size.Small},
				new FriedMiraak{ Size = Size.Medium},
				new FriedMiraak{ Size = Size.Large},

				new MadOtarGrits{ Size = Size.Small},
				new MadOtarGrits{ Size = Size.Medium},
				new MadOtarGrits{ Size = Size.Large},

				new VokunSalad{ Size = Size.Small},
				new VokunSalad{ Size = Size.Medium},
				new VokunSalad{ Size = Size.Large} 
			};
		}

		/// <summary>
		/// Returns an instance of all available drinks offered by Bleakwind Buffet
		/// </summary>
		/// <returns>An enumerable instance of all the drinks with every variable size and flavor</returns>
		public static IEnumerable<IOrderItem> Drinks()
		{
			return new List<IOrderItem>() {
				new AretinoAppleJuice{ Size = Size.Small},
				new AretinoAppleJuice{ Size = Size.Medium},
				new AretinoAppleJuice{ Size = Size.Large},

				new CandlehearthCoffee{ Size = Size.Small},
				new CandlehearthCoffee{ Size = Size.Medium},
				new CandlehearthCoffee{ Size = Size.Large},

				new MarkarthMilk{ Size = Size.Small},
				new MarkarthMilk{ Size = Size.Medium},
				new MarkarthMilk{ Size = Size.Large},

				new WarriorWater{ Size = Size.Small},
				new WarriorWater{ Size = Size.Medium},
				new WarriorWater{ Size = Size.Large},

				new SailorSoda{ Size = Size.Small, Flavor = SodaFlavor.Blackberry },
				new SailorSoda{ Size = Size.Medium, Flavor = SodaFlavor.Blackberry },
				new SailorSoda{ Size = Size.Large, Flavor = SodaFlavor.Blackberry },

				new SailorSoda{ Size = Size.Small, Flavor = SodaFlavor.Cherry },
				new SailorSoda{ Size = Size.Medium, Flavor = SodaFlavor.Cherry },
				new SailorSoda{ Size = Size.Large, Flavor = SodaFlavor.Cherry },

				new SailorSoda{ Size = Size.Small, Flavor = SodaFlavor.Grapefruit },
				new SailorSoda{ Size = Size.Medium, Flavor = SodaFlavor.Grapefruit },
				new SailorSoda{ Size = Size.Large, Flavor = SodaFlavor.Grapefruit },

				new SailorSoda{ Size = Size.Small, Flavor = SodaFlavor.Lemon },
				new SailorSoda{ Size = Size.Medium, Flavor = SodaFlavor.Lemon },
				new SailorSoda{ Size = Size.Large, Flavor = SodaFlavor.Lemon },

				new SailorSoda{ Size = Size.Small, Flavor = SodaFlavor.Peach },
				new SailorSoda{ Size = Size.Medium, Flavor = SodaFlavor.Peach },
				new SailorSoda{ Size = Size.Large, Flavor = SodaFlavor.Peach },

				new SailorSoda{ Size = Size.Small, Flavor = SodaFlavor.Watermelon },
				new SailorSoda{ Size = Size.Medium, Flavor = SodaFlavor.Watermelon },
				new SailorSoda{ Size = Size.Large, Flavor = SodaFlavor.Watermelon }

			};
		}

		/// <summary>
		/// Returns an instance of all available menu items offered by Bleakwind Buffet
		/// </summary>
		/// <returns>An enumerable instance of all menu items with every variable size (and flavor)</returns>
		public static IEnumerable<IOrderItem> FullMenu()
		{
			return (new List<IOrderItem>())
				.Concat(Entrees())
				.Concat(Sides())
				.Concat(Drinks());
		}

		/// <summary>
		/// Full menu but with just the types
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<Type> FullMenuTypes()
		{
			foreach (var item in EntreeTypes())
			{
				yield return item;
			}
			foreach (var item in SideTypes())
			{
				yield return item;
			}
			foreach (var item in DrinkTypes())
			{
				yield return item;
			}
		}

		/// <summary>
		/// All entrees but just the types
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<Type> EntreeTypes()
		{
			yield return typeof(BriarheartBurger);
			yield return typeof(DoubleDraugr);
			yield return typeof(ThalmorTriple);
			yield return typeof(GardenOrcOmelette);
			yield return typeof(SmokehouseSkeleton);
			yield return typeof(PhillyPoacher);
			yield return typeof(ThugsTBone);
		}

		/// <summary>
		/// All sides but just the types
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<Type> SideTypes()
		{
			yield return typeof(DragonbornWaffleFries);
			yield return typeof(FriedMiraak);
			yield return typeof(MadOtarGrits);
			yield return typeof(VokunSalad);
		}

		/// <summary>
		/// All Drinks but just the types
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<Type> DrinkTypes()
		{
			yield return typeof(AretinoAppleJuice);
			yield return typeof(CandlehearthCoffee);
			yield return typeof(MarkarthMilk);
			yield return typeof(SailorSoda);
			yield return typeof(WarriorWater);
		}
	}
}
