using System;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests
{
	/// <summary>
	/// Tests for the Menu
	/// </summary>
	public class MenuTests
	{
		[Fact]
		public void ShouldReturnCorrectIEnumerableOfEntrees()
		{
			Assert.Collection<IOrderItem>(Menu.Entrees(),
				item => Assert.IsType<BriarheartBurger>(item),
				item => Assert.IsType<DoubleDraugr>(item),
				item => Assert.IsType<GardenOrcOmelette>(item),
				item => Assert.IsType<PhillyPoacher>(item),
				item => Assert.IsType<SmokehouseSkeleton>(item),
				item => Assert.IsType<ThalmorTriple>(item),
				item => Assert.IsType<ThugsTBone>(item)
				) ; 
		}

		[Fact]
		public void ShouldReturnCorrectIEnumerableOfSides()
		{
			Assert.Collection<IOrderItem>(Menu.Sides(),
				item => {
					Assert.IsType<DragonbornWaffleFries>(item);
					Assert.Equal(Size.Small, (item as DragonbornWaffleFries).Size);
				},
				item => {
					Assert.IsType<DragonbornWaffleFries>(item);
					Assert.Equal(Size.Medium, (item as DragonbornWaffleFries).Size);
				},
				item => {
					Assert.IsType<DragonbornWaffleFries>(item);
					Assert.Equal(Size.Large, (item as DragonbornWaffleFries).Size);
				},

				item => {
					Assert.IsType<FriedMiraak>(item);
					Assert.Equal(Size.Small, (item as FriedMiraak).Size);
				},
				item => {
					Assert.IsType<FriedMiraak>(item);
					Assert.Equal(Size.Medium, (item as FriedMiraak).Size);
				},
				item => {
					Assert.IsType<FriedMiraak>(item);
					Assert.Equal(Size.Large, (item as FriedMiraak).Size);
				},

				item => {
					Assert.IsType<MadOtarGrits>(item);
					Assert.Equal(Size.Small, (item as MadOtarGrits).Size);
				},
				item => {
					Assert.IsType<MadOtarGrits>(item);
					Assert.Equal(Size.Medium, (item as MadOtarGrits).Size);
				},
				item => {
					Assert.IsType<MadOtarGrits>(item);
					Assert.Equal(Size.Large, (item as MadOtarGrits).Size);
				},

				item => {
					Assert.IsType<VokunSalad>(item);
					Assert.Equal(Size.Small, (item as VokunSalad).Size);
				},
				item => {
					Assert.IsType<VokunSalad>(item);
					Assert.Equal(Size.Medium, (item as VokunSalad).Size);
				},
				item => {
					Assert.IsType<VokunSalad>(item);
					Assert.Equal(Size.Large, (item as VokunSalad).Size);
				} 
			);
		}

		[Fact]
		public void ShouldReturnCorrectIEnumerableOfDrinks()
		{
			Assert.Collection<IOrderItem>(Menu.Drinks(),
				item => {
					Assert.IsType<AretinoAppleJuice>(item);
					Assert.Equal(Size.Small, (item as AretinoAppleJuice).Size);
				},
				item => {
					Assert.IsType<AretinoAppleJuice>(item);
					Assert.Equal(Size.Medium, (item as AretinoAppleJuice).Size);
				},
				item => {
					Assert.IsType<AretinoAppleJuice>(item);
					Assert.Equal(Size.Large, (item as AretinoAppleJuice).Size);
				},

				item => {
					Assert.IsType<CandlehearthCoffee>(item);
					Assert.Equal(Size.Small, (item as CandlehearthCoffee).Size);
				},
				item => {
					Assert.IsType<CandlehearthCoffee>(item);
					Assert.Equal(Size.Medium, (item as CandlehearthCoffee).Size);
				},
				item => {
					Assert.IsType<CandlehearthCoffee>(item);
					Assert.Equal(Size.Large, (item as CandlehearthCoffee).Size);
				},

				item => {
					Assert.IsType<MarkarthMilk>(item);
					Assert.Equal(Size.Small, (item as MarkarthMilk).Size);
				},
				item => {
					Assert.IsType<MarkarthMilk>(item);
					Assert.Equal(Size.Medium, (item as MarkarthMilk).Size);
				},
				item => {
					Assert.IsType<MarkarthMilk>(item);
					Assert.Equal(Size.Large, (item as MarkarthMilk).Size);
				},

				item => {
					Assert.IsType<WarriorWater>(item);
					Assert.Equal(Size.Small, (item as WarriorWater).Size);
				},
				item => {
					Assert.IsType<WarriorWater>(item);
					Assert.Equal(Size.Medium, (item as WarriorWater).Size);
				},
				item => {
					Assert.IsType<WarriorWater>(item);
					Assert.Equal(Size.Large, (item as WarriorWater).Size);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
				}
			);
		}

		[Fact]
		public void ShouldReturnCorrectIEnumerableInFullMenu()
		{
			Assert.Collection<IOrderItem>(Menu.FullMenu(),
				item => Assert.IsType<BriarheartBurger>(item),
				item => Assert.IsType<DoubleDraugr>(item),
				item => Assert.IsType<GardenOrcOmelette>(item),
				item => Assert.IsType<PhillyPoacher>(item),
				item => Assert.IsType<SmokehouseSkeleton>(item),
				item => Assert.IsType<ThalmorTriple>(item),
				item => Assert.IsType<ThugsTBone>(item),


				item => {
					Assert.IsType<DragonbornWaffleFries>(item);
					Assert.Equal(Size.Small, (item as DragonbornWaffleFries).Size);
				},
				item => {
					Assert.IsType<DragonbornWaffleFries>(item);
					Assert.Equal(Size.Medium, (item as DragonbornWaffleFries).Size);
				},
				item => {
					Assert.IsType<DragonbornWaffleFries>(item);
					Assert.Equal(Size.Large, (item as DragonbornWaffleFries).Size);
				},

				item => {
					Assert.IsType<FriedMiraak>(item);
					Assert.Equal(Size.Small, (item as FriedMiraak).Size);
				},
				item => {
					Assert.IsType<FriedMiraak>(item);
					Assert.Equal(Size.Medium, (item as FriedMiraak).Size);
				},
				item => {
					Assert.IsType<FriedMiraak>(item);
					Assert.Equal(Size.Large, (item as FriedMiraak).Size);
				},

				item => {
					Assert.IsType<MadOtarGrits>(item);
					Assert.Equal(Size.Small, (item as MadOtarGrits).Size);
				},
				item => {
					Assert.IsType<MadOtarGrits>(item);
					Assert.Equal(Size.Medium, (item as MadOtarGrits).Size);
				},
				item => {
					Assert.IsType<MadOtarGrits>(item);
					Assert.Equal(Size.Large, (item as MadOtarGrits).Size);
				},

				item => {
					Assert.IsType<VokunSalad>(item);
					Assert.Equal(Size.Small, (item as VokunSalad).Size);
				},
				item => {
					Assert.IsType<VokunSalad>(item);
					Assert.Equal(Size.Medium, (item as VokunSalad).Size);
				},
				item => {
					Assert.IsType<VokunSalad>(item);
					Assert.Equal(Size.Large, (item as VokunSalad).Size);
				},





				item => {
					Assert.IsType<AretinoAppleJuice>(item);
					Assert.Equal(Size.Small, (item as AretinoAppleJuice).Size);
				},
				item => {
					Assert.IsType<AretinoAppleJuice>(item);
					Assert.Equal(Size.Medium, (item as AretinoAppleJuice).Size);
				},
				item => {
					Assert.IsType<AretinoAppleJuice>(item);
					Assert.Equal(Size.Large, (item as AretinoAppleJuice).Size);
				},

				item => {
					Assert.IsType<CandlehearthCoffee>(item);
					Assert.Equal(Size.Small, (item as CandlehearthCoffee).Size);
				},
				item => {
					Assert.IsType<CandlehearthCoffee>(item);
					Assert.Equal(Size.Medium, (item as CandlehearthCoffee).Size);
				},
				item => {
					Assert.IsType<CandlehearthCoffee>(item);
					Assert.Equal(Size.Large, (item as CandlehearthCoffee).Size);
				},

				item => {
					Assert.IsType<MarkarthMilk>(item);
					Assert.Equal(Size.Small, (item as MarkarthMilk).Size);
				},
				item => {
					Assert.IsType<MarkarthMilk>(item);
					Assert.Equal(Size.Medium, (item as MarkarthMilk).Size);
				},
				item => {
					Assert.IsType<MarkarthMilk>(item);
					Assert.Equal(Size.Large, (item as MarkarthMilk).Size);
				},

				item => {
					Assert.IsType<WarriorWater>(item);
					Assert.Equal(Size.Small, (item as WarriorWater).Size);
				},
				item => {
					Assert.IsType<WarriorWater>(item);
					Assert.Equal(Size.Medium, (item as WarriorWater).Size);
				},
				item => {
					Assert.IsType<WarriorWater>(item);
					Assert.Equal(Size.Large, (item as WarriorWater).Size);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Blackberry, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Cherry, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Grapefruit, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Peach, (item as SailorSoda).Flavor);
				},

				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
				},
				item => {
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
					Assert.Equal(SodaFlavor.Watermelon, (item as SailorSoda).Flavor);
				}
			);
		}

		[Fact]
		public void ShouldReturnCorrectIEnumerableInFullMenuTypes()
        {
			Assert.Collection<Type>(Menu.FullMenuTypes(),
				item => Assert.Equal(typeof(BriarheartBurger), item),
				item => Assert.Equal(typeof(DoubleDraugr), item),
				item => Assert.Equal(typeof(ThalmorTriple), item),
				item => Assert.Equal(typeof(GardenOrcOmelette), item),
				item => Assert.Equal(typeof(SmokehouseSkeleton), item),
				item => Assert.Equal(typeof(PhillyPoacher), item),
				item => Assert.Equal(typeof(ThugsTBone), item),
				item => Assert.Equal(typeof(DragonbornWaffleFries), item),
				item => Assert.Equal(typeof(FriedMiraak), item),
				item => Assert.Equal(typeof(MadOtarGrits), item),
				item => Assert.Equal(typeof(VokunSalad), item),
				item => Assert.Equal(typeof(AretinoAppleJuice), item),
				item => Assert.Equal(typeof(CandlehearthCoffee), item),
				item => Assert.Equal(typeof(MarkarthMilk), item),
				item => Assert.Equal(typeof(SailorSoda), item),
				item => Assert.Equal(typeof(WarriorWater), item)
				); 
        }

		[Fact]
		public void ShouldReturnCorrectIEnumerableInEntreeTypes()
        {
			Assert.Collection<Type>(Menu.EntreeTypes(),
				item => Assert.Equal(typeof(BriarheartBurger), item),
				item => Assert.Equal(typeof(DoubleDraugr), item),
				item => Assert.Equal(typeof(ThalmorTriple), item),
				item => Assert.Equal(typeof(GardenOrcOmelette), item),
				item => Assert.Equal(typeof(SmokehouseSkeleton), item),
				item => Assert.Equal(typeof(PhillyPoacher), item),
				item => Assert.Equal(typeof(ThugsTBone), item)
				);

		}

		[Fact]
		public void ShouldReturnCorrectIEnumerableInSideTypes()
		{
			Assert.Collection<Type>(Menu.SideTypes(),
				item => Assert.Equal(typeof(DragonbornWaffleFries), item),
				item => Assert.Equal(typeof(FriedMiraak), item),
				item => Assert.Equal(typeof(MadOtarGrits), item),
				item => Assert.Equal(typeof(VokunSalad), item)
				);

		}

		[Fact]
		public void ShouldReturnCorrectIEnumerableInDrinkTypes()
		{
			Assert.Collection<Type>(Menu.DrinkTypes(),
				item => Assert.Equal(typeof(AretinoAppleJuice), item),
				item => Assert.Equal(typeof(CandlehearthCoffee), item),
				item => Assert.Equal(typeof(MarkarthMilk), item),
				item => Assert.Equal(typeof(SailorSoda), item),
				item => Assert.Equal(typeof(WarriorWater), item)
				);

		}

		[Fact]
		public void ShouldReturnCorrectSearch()
		{
			//null search should return entire menu
			IEnumerable<IOrderItem> x = Menu.FullMenu();
			foreach (IOrderItem item in Menu.Search(x, null))
			{
				Assert.Contains(item, x);
			}
			
			Assert.Collection<IOrderItem>(Menu.Search(Menu.FullMenu(), "Burger"),
				item =>
				{
					Assert.IsType<BriarheartBurger>(item);
				});
			Assert.Collection<IOrderItem>(Menu.Search(Menu.FullMenu(), "Lemon"),
				item =>
				{
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
					Assert.Equal(Size.Small, (item as SailorSoda).Size);
				},
				item =>
				{
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
					Assert.Equal(Size.Medium, (item as SailorSoda).Size);
				},
				item =>
				{
					Assert.IsType<SailorSoda>(item);
					Assert.Equal(SodaFlavor.Lemon, (item as SailorSoda).Flavor);
					Assert.Equal(Size.Large, (item as SailorSoda).Size);
				});
			
		}

		[Fact]
		public void ShouldFilterByCorrectCategory()
		{
			//null should return entire menu
			IEnumerable<IOrderItem> x = Menu.FullMenu();
			foreach (IOrderItem item in Menu.FilterByCategory(x, null))
			{
				Assert.Contains(item, x);
			}

			// should only contain entrees
			IEnumerable<IOrderItem> filtered = Menu.FilterByCategory(Menu.FullMenu(), new string[] { "Entrees" });
			Assert.Equal(Menu.Entrees().Count(), filtered.Count());
			foreach (IOrderItem item in filtered)
			{
				Assert.True(item is Entree);
			}

			//should contain everything but entrees
			filtered = Menu.FilterByCategory(Menu.FullMenu(), new string[] { "Sides", "Drinks" });
			Assert.Equal(Menu.Sides().Count() + Menu.Drinks().Count(), filtered.Count());
			foreach (IOrderItem item in filtered)
			{
				Assert.True(item is Side || item is Drink);
			}
		}

		[Fact]
		public void ShouldFilterByCalories()
		{
			//Should contain entire menu
			IEnumerable<IOrderItem> x = Menu.FullMenu();
			foreach (IOrderItem item in Menu.FilterByCalories(x, null, null))
			{
				Assert.Contains(item, x);
			}

			//should contain everything under 201 calories
			IEnumerable<IOrderItem> lessEq200 = Menu.FilterByCalories(Menu.FullMenu(), null, 200);
			foreach (IOrderItem item in lessEq200)
			{
				Assert.True(item.Calories <= 200);
			}

			//should contain everything over 200 calories
			IEnumerable<IOrderItem> great200 = Menu.FilterByCalories(Menu.FullMenu(), 201, null);
			foreach (IOrderItem item in great200)
			{
				Assert.True(item.Calories >= 201);
			}

			//The combined size of both should be the entire menu.
			Assert.Equal(Menu.FullMenu().Count(), lessEq200.Count() + great200.Count());

		}

		[Fact]
		public void ShouldFilterByPrices()
		{
			//Should contain entire menu
			IEnumerable<IOrderItem> x = Menu.FullMenu();
			foreach (IOrderItem item in Menu.FilterByPrice(x, null, null))
			{
				Assert.Contains(item, x);
			}

			//should contain everything under and including 3 dollars
			IEnumerable<IOrderItem> lessEq3 = Menu.FilterByPrice(Menu.FullMenu(), null, 3.0);
			foreach (IOrderItem item in lessEq3)
			{
				Assert.True(item.Price <= 3);
			}

			//should contain everything over 3 dollars
			IEnumerable<IOrderItem> great3 = Menu.FilterByPrice(Menu.FullMenu(), 3.01, null);
			foreach (IOrderItem item in great3)
			{
				Assert.True(item.Price >= 3.01);
			}

			//The combined size of both should be the entire menu.
			Assert.Equal(Menu.FullMenu().Count(), lessEq3.Count() + great3.Count());

		}
	}
}
