using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: Menu.cs
 * Purpose: A "library" to quickly grab IEnumerable's of items on the menu
 */
namespace BleakwindBuffet.Data
{
	/// <summary>
	/// Static class representing the menu of orderable items
	/// </summary>
	public static class Menu
	{
		/// <summary>
		/// A list of all available IOrderItem categories
		/// </summary>
		public static IEnumerable<string> Categories { get { return new string[] { "Entrees", "Sides", "Drinks" }; } }
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

		/// <summary>
		/// Returns the menu filters by searchterms
		/// </summary>
		/// <param name="menu">starting collection of IOrderItems to filter</param>
		/// <param name="SearchTerms">the search terms to filter by. Can use any term that appears in the ToString()</param>
		/// <returns></returns>
		public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menu, string SearchTerms)
		{
			if (SearchTerms == null || SearchTerms.Length == 0)
			{
				return menu;
			}
			List<IOrderItem> filtered = new List<IOrderItem>();

			foreach (IOrderItem item in menu)
			{
				bool hasAllTerms = true;
				foreach (string term in SearchTerms.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
				{
					if (!item.ToString().Contains(term))
					{
						hasAllTerms = false;
						break;
					}
				}
				if (hasAllTerms)
				{
					filtered.Add(item);
				}
			}

			return filtered;
		}

		/// <summary>
		/// Returns the menu filterd to only include the included categories
		/// </summary>
		/// <param name="menu">starting collection of IOrderItems</param>
		/// <param name="categories">strings representing entree, side, and or drink</param>
		/// <returns></returns>
		public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> categories)
		{
			// currently only support for entrees, sides, and drinks
			if (categories == null || categories.Count() == 0 || categories.Count() == 3)
			{
				return menu;
			}
			List<IOrderItem> filtered = new List<IOrderItem>();
			foreach (IOrderItem item in menu)
			{
				string category = "";
				if (item is Entree)
				{
					category = "Entrees";
				}else if (item is Side)
				{
					category = "Sides";
				}else if (item is Drink)
				{
					category = "Drinks";
				}
				if (category.Length == 0)
				{
					throw new NotImplementedException("IOrderItem is not an entree, side, or drink");
				}
				if (categories.Contains(category))
				{
					filtered.Add(item);
				}
			}
			return filtered;
		}

		/// <summary>
		/// Returns filtered menu to only include items withen calorie range
		/// </summary>
		/// <param name="menu">starting collection of IOrderItems</param>
		/// <param name="min">lowest allowed calories </param>
		/// <param name="max">highest allowed calories</param>
		/// <returns></returns>
		public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
		{
			// currently only support for entrees, sides, and drinks
			if (min == null && max == null)
			{
				return menu;
			}
			List<IOrderItem> filtered = new List<IOrderItem>();
			foreach (IOrderItem item in menu)
			{
				if (min == null)
				{
					if (item.Calories <= max)
					{
						filtered.Add(item);
					}
				}
				else
				{
					if (max == null)
					{
						if (item.Calories >= min)
						{
							filtered.Add(item);
						}
					}
					else
					{
						//neither min or max is null
						if (item.Calories >= min && item.Calories <= max)
						{
							filtered.Add(item);
						}
					}
				}
			}
			return filtered;
		}
		/// <summary>
		/// Returns filtered menu to only include items withen price range
		/// </summary>
		/// <param name="menu">starting collection of IOrderItems</param>
		/// <param name="min">lowest allowed price </param>
		/// <param name="max">highest allowed price</param>
		/// <returns></returns>
		public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
		{
			// currently only support for entrees, sides, and drinks
			if (min == null && max == null)
			{
				return menu;
			}
			List<IOrderItem> filtered = new List<IOrderItem>();
			foreach (IOrderItem item in menu)
			{
				if (min == null)
				{
					if (item.Price <= max)
					{
						filtered.Add(item);
					}
				}
				else
				{
					if (max == null)
					{
						if (item.Price >= min)
						{
							filtered.Add(item);
						}
					}
					else
					{
						//neither min or max is null
						if (item.Price >= min && item.Price <= max)
						{
							filtered.Add(item);
						}
					}
				}
			}
			return filtered;
		}
	}
}
