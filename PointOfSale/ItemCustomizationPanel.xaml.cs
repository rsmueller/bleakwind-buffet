using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for MenuItemCustomizationWindow.xaml
	/// </summary>
	public partial class ItemCustomizationPanel : UserControl
	{

		private static readonly string[] POSSIBLE_OPTIONS = { "Bun", "Ketchup", "Mustard", "Pickle", "Cheese", "Tomato", "Lettuce", "Mayo", "Bacon", "Egg", "Ice", "Decaf", "RoomForCream", "Lemon", "Flavor", "Size" };

		public Button BtnClose { get { return btnClose; } }
		public Button BtnAddToOrder { get { return btnAddToOrder; } }

		public ItemCustomizationPanel()
		{
			InitializeComponent();
		}

		private IOrderItem orderItem;

		/// <summary>
		/// Checks if the item has a property in POSSIBLE_OPTIONS and if so adds a checkbox or combo box for that property
		/// Binds that box to the property as well
		/// </summary>
		/// <param name="item"></param>
		public void LoadOptionsForItem(IOrderItem item)
		{

			label.Content = $"Customization Window for {item.DisplayName}";

			orderItem = item;

			foreach (string option in POSSIBLE_OPTIONS)
			{
				var property = item.GetType().GetProperty(option);
				if (property == null)
					continue;

				if (property.PropertyType == typeof(Boolean))
				{

					CheckBox box = new CheckBox();
					box.Tag = property;
					box.Checked += OnCheckBoxChecked;
					box.Unchecked += OnCheckBoxUnchecked;
					box.Content = option;

					box.IsChecked = (bool)property.GetValue(item);

					stack.Children.Add(box);
				}
				else if (property.PropertyType == typeof(Size))
				{
					ComboBox box = new ComboBox();
					box.Tag = property;
					box.ItemsSource = Sizes.GetSizes();
					box.SelectedIndex = 0;
					box.SelectionChanged += OnComboBoxSelectionChanged;
					
					stack.Children.Add(box);
				}
				else if (property.PropertyType == typeof(SodaFlavor))
				{
					ComboBox box = new ComboBox();
					box.Tag = property;
					box.ItemsSource = SodaFlavors.GetFlavors();
					box.SelectedIndex = 0;
					box.SelectionChanged += OnComboBoxSelectionChanged;

					stack.Children.Add(box);
				}

			}
		}

		private void OnComboBoxSelectionChanged(object sender, RoutedEventArgs e)
		{
			ComboBox box = sender as ComboBox;
			PropertyInfo property = box.Tag as PropertyInfo;
			property.SetValue(orderItem, box.SelectedItem);
		}

		private void OnCheckBoxChecked(object sender, RoutedEventArgs e)
		{
			CheckBox box = sender as CheckBox;
			PropertyInfo property = box.Tag as PropertyInfo;
			property.SetValue(orderItem, true);
		}

		private void OnCheckBoxUnchecked(object sender, RoutedEventArgs e)
		{
			CheckBox box = sender as CheckBox;
			PropertyInfo property = box.Tag as PropertyInfo;
			property.SetValue(orderItem, false);
		}

	}
}
