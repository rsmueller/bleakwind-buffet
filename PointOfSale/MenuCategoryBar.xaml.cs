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
	/// Interaction logic for MenuCategoryBar.xaml
	/// </summary>
	public partial class MenuCategoryBar : UserControl
	{

		public Button AllItemsMenuButton { get { return btnAllItems; } }
		public Button EntreeMenuButton { get { return btnEntrees; } }
		public Button SidesMenuButton { get { return btnSides; } }
		public Button DrinksMenuButton { get { return btnDrinks; } }

		public MenuCategoryBar()
		{
			InitializeComponent();
		}
	}
}
