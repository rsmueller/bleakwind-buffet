using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PointOfSale
{
	/// <summary>
	/// References to ImageSources given an IOrderItem
	/// </summary>
	public static class OrderItemImageLibrary
	{
		/// <summary>
		/// Image for if no image could be found
		/// </summary>
		public static readonly ImageSource NullImage = new BitmapImage(new Uri("src/error_no_img.png", UriKind.Relative));

		/// <summary>
		/// Returns an ImageSource for an item
		/// </summary>
		/// <param name="item"></param>
		/// <returns>An ImageSource image of item</returns>
		public static ImageSource GetImageForIOrderItem(Type item)
		{
			if (item == typeof(BriarheartBurger))
			{
				return new BitmapImage(new Uri("src/briarheart_burger.jpg", UriKind.Relative));
			}
			else if (item == typeof(DoubleDraugr))
			{
				return new BitmapImage(new Uri("src/double_draugr.jpg", UriKind.Relative));
			}
			else if (item == typeof(GardenOrcOmelette))
			{
				return new BitmapImage(new Uri("src/garden_orc_omelette.jpg", UriKind.Relative));
			}
			else if (item == typeof(PhillyPoacher))
			{
				return new BitmapImage(new Uri("src/philly_poacher.jpg", UriKind.Relative));
			}
			else if (item == typeof(SmokehouseSkeleton))
			{
				return new BitmapImage(new Uri("src/smokehouse_skeleton.jpg", UriKind.Relative));
			}
			else if (item == typeof(ThalmorTriple))
			{
				return new BitmapImage(new Uri("src/thalmor_triple.jpg", UriKind.Relative));
			}
			else if (item == typeof(ThugsTBone))
			{
				return new BitmapImage(new Uri("src/thugs_tbone.jpg", UriKind.Relative));
			}
			else if (item == typeof(AretinoAppleJuice))
			{
				return new BitmapImage(new Uri("src/aretino_apple_juice.jpg", UriKind.Relative));
			}
			else if (item == typeof(CandlehearthCoffee))
			{
				return new BitmapImage(new Uri("src/candlehearth_coffee.jpg", UriKind.Relative));
			}
			else if (item == typeof(MarkarthMilk))
			{
				return new BitmapImage(new Uri("src/markarth_milk.jpg", UriKind.Relative));
			}
			else if (item == typeof(SailorSoda))
			{
				return new BitmapImage(new Uri("src/sailor_soda.jpg", UriKind.Relative));
			}
			else if (item == typeof(WarriorWater))
			{
				return new BitmapImage(new Uri("src/warrior_water.jpg", UriKind.Relative));
			}
			else if (item == typeof(DragonbornWaffleFries))
			{
				return new BitmapImage(new Uri("src/dragonborn_waffle_fries.jpg", UriKind.Relative));
			}
			else if (item == typeof(FriedMiraak))
			{
				return new BitmapImage(new Uri("src/fried_miraak.jpg", UriKind.Relative));
			}
			else if (item == typeof(MadOtarGrits))
			{
				return new BitmapImage(new Uri("src/mad_otar_grits.jpg", UriKind.Relative));
			}
			else if (item == typeof(VokunSalad))
			{
				return new BitmapImage(new Uri("src/vokun_salad.jpg", UriKind.Relative));
			}
			else return NullImage;
		}
	}
}
