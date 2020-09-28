using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for Menu.xaml
	/// </summary>
	public partial class Menu : UserControl
	{
		public Menu()
		{
			InitializeComponent();
			menuCategoryBar.AllItemsMenuButton.Click += OnCategoryBarButtonClicked;
			menuCategoryBar.EntreeMenuButton.Click += OnCategoryBarButtonClicked;
			menuCategoryBar.SidesMenuButton.Click += OnCategoryBarButtonClicked;
			menuCategoryBar.DrinksMenuButton.Click += OnCategoryBarButtonClicked;
		}

		/// <summary>
		/// MenuCategoryBar buttons click handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCategoryBarButtonClicked(object sender, RoutedEventArgs e)
		{
			if (sender == menuCategoryBar.AllItemsMenuButton)
			{
				SwitchMenu(BleakwindBuffet.Data.Menu.FullMenuTypes());
			}
			else if (sender == menuCategoryBar.EntreeMenuButton)
			{
				SwitchMenu(BleakwindBuffet.Data.Menu.EntreeTypes());
			}
			else if (sender == menuCategoryBar.SidesMenuButton)
			{
				SwitchMenu(BleakwindBuffet.Data.Menu.SideTypes());
			}
			else if (sender == menuCategoryBar.DrinksMenuButton)
			{
				SwitchMenu(BleakwindBuffet.Data.Menu.DrinkTypes());
			}
		}

		/// <summary>
		/// Swaps out the items displayed in MenuDisplay with items in newMenu
		/// </summary>
		/// <param name="newMenu"></param>
		public void SwitchMenu(IEnumerable<Type> newMenu)
		{
			menuDisplay.NewMenu(newMenu);
			menuDisplay.ResizeItems();
		}
	}
}
