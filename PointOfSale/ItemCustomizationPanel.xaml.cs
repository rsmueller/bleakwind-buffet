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

/*
 * Author: Riley Mueller
 * Last Modified: 10/1/2020
 * Class Name: ItemCustomizationPanel.cs
 * Purpose: A panel to customize the order of an item after it has been selected
 * Dynamically loads in the items public properties to fill with drop downs or check boxes
 */
namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for MenuItemCustomizationWindow.xaml
	/// </summary>
	public partial class ItemCustomizationPanel : UserControl
	{

		private static readonly string[] POSSIBLE_OPTIONS = { "Bun", "Ketchup", "Mustard", "Pickle", "Cheese", "Tomato", "Lettuce", "Mayo", "Bacon", "Egg", "Ice", "Decaf", "RoomForCream", "Lemon","Broccoli", "Mushrooms","Tomato","Cheddar","Sirloin","Onion","Roll","SausageLink","HashBrowns", "Flavor", "Size" };

		/// <summary>
		/// Button that closes the item customization panel without writing to order
		/// </summary>
		public Button BtnClose { get { return btnClose; } }
		/// <summary>
		/// Button that adds the item to the order and closes the item customization panel
		/// </summary>
		public Button BtnAddToOrder { get { return btnAddToOrder; } }

		public ItemCustomizationPanel()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Checks if the item has a property in POSSIBLE_OPTIONS and if so adds a checkbox or combo box for that property
		/// Binds that box to the property as well
		/// </summary>
		/// <param name="item"></param>
		public void LoadOptionsForItem(IOrderItem item)
		{

			label.Content = $"Customization Window for {item.DisplayName}";

			this.DataContext = item;

			foreach (var property in item.GetType().GetProperties())
			{
				if (property == null)
					continue;

				string option = property.Name;

				if (property.PropertyType == typeof(Boolean))
				{
					BleakwindCheckBox x = new BleakwindCheckBox();
					CheckBox box = x.Box;
					box.Tag = property;
					box.Checked += OnCheckBoxChecked;
					box.Unchecked += OnCheckBoxUnchecked;
					x.TextBlock.Text = option;

					box.IsChecked = (bool)property.GetValue(item);

					stack.Children.Add(x);
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

		/// <summary>
		/// Updates the property of the item associated with the sender
		/// </summary>
		/// <param name="sender">A ComboBox that triggered the event</param>
		/// <param name="e">arguements</param>
		private void OnComboBoxSelectionChanged(object sender, RoutedEventArgs e)
		{
			ComboBox box = sender as ComboBox;
			PropertyInfo property = box.Tag as PropertyInfo;
			property.SetValue(this.DataContext, box.SelectedItem);
		}

		/// <summary>
		/// Updates the property of the item associated with the sender
		/// </summary>
		/// <param name="sender">A CheckBox that triggered the event</param>
		/// <param name="e">arguements</param>
		private void OnCheckBoxChecked(object sender, RoutedEventArgs e)
		{
			CheckBox box = sender as CheckBox;
			PropertyInfo property = box.Tag as PropertyInfo;
			property.SetValue(this.DataContext, true);
		}

		/// <summary>
		/// Updates the property of the item associated with the sender
		/// </summary>
		/// <param name="sender">A CheckBox that triggered the event</param>
		/// <param name="e">arguements</param>
		private void OnCheckBoxUnchecked(object sender, RoutedEventArgs e)
		{
			CheckBox box = sender as CheckBox;
			PropertyInfo property = box.Tag as PropertyInfo;
			property.SetValue(this.DataContext, false);
		}

	}
}
