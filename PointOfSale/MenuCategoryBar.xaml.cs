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

/*
 * Author: Riley Mueller
 * Last Modified: 10/1/2020
 * Class Name: MenuCategoryBar.cs
 * Purpose: Houses buttons to swap between possible menus
 */
namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for MenuCategoryBar.xaml
	/// </summary>
	public partial class MenuCategoryBar : UserControl
	{
		/// <summary>
		/// Buttons that tells MenuDisplay to display all items in the menu
		/// </summary>
		public Button AllItemsMenuButton { get { return btnAllItems; } }
		/// <summary>
		/// Buttons that tells MenuDisplay to display entree items in the menu
		/// </summary>
		public Button EntreeMenuButton { get { return btnEntrees; } }
		/// <summary>
		/// Button that tells MenuDisplay to display side items in the menu
		/// </summary>
		public Button SidesMenuButton { get { return btnSides; } }
		/// <summary>
		/// Button that tells MenuDisplay to display drink items in the menu
		/// </summary>
		public Button DrinksMenuButton { get { return btnDrinks; } }

		public MenuCategoryBar()
		{
			InitializeComponent();
		}
	}
}
