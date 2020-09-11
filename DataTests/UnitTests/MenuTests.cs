using System;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;

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
		public void ShouldReturnCorrectIEnumerableOfFullMenu()
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
	}
}
