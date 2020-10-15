using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
			// if this item is a combo item
			// load choice of entree, side, and drink
			if (item is Combo combo)
			{
				AddComboItemPanel(BleakwindBuffet.Data.Menu.EntreeTypes());
				AddComboItemPanel(BleakwindBuffet.Data.Menu.SideTypes());
				AddComboItemPanel(BleakwindBuffet.Data.Menu.DrinkTypes());
			}
			else
			{
				foreach (var property in item.GetType().GetProperties())
				{
					if (property == null)
						continue;

					string option = property.Name;

					if (property.PropertyType == typeof(Boolean))
					{
						AddCheckBox(property, option, (bool)property.GetValue(item));
					}
					else if (property.PropertyType == typeof(Size))
					{
						AddComboBox(property, Sizes.GetSizes());
					}
					else if (property.PropertyType == typeof(SodaFlavor))
					{
						AddComboBox(property, SodaFlavors.GetFlavors());
					}

				}
			}

		}

		private ComboBox AddComboItemPanel(IEnumerable itemsSource)
		{
			ComboBox box = new ComboBox();
			box.ItemsSource = itemsSource;
			box.DisplayMemberPath = "Name";
			var x = new ItemCustomizationPanel();
			x.grid.RowDefinitions.RemoveAt(0);
			x.grid.RowDefinitions.RemoveAt(1);
			x.btnAddToOrder.IsEnabled = false;
			x.btnClose.IsEnabled = false;
			x.label.IsEnabled = false;
			x.btnAddToOrder.Visibility = Visibility.Hidden;
			x.btnClose.Visibility = Visibility.Hidden;
			x.label.Visibility = Visibility.Hidden;
			box.Tag = x;
			box.SelectionChanged += OnComboItemChanged;
			stack.Children.Add(box);
			stack.Children.Add(box.Tag as UIElement);

			box.SelectedIndex = 0;
			return box;
		}


		private void OnComboItemChanged(object sender, RoutedEventArgs e)
		{
			ComboBox box = sender as ComboBox;
			ItemCustomizationPanel panel = box.Tag as ItemCustomizationPanel;

			panel.stack.Children.Clear();

			IOrderItem newItem = (IOrderItem)Activator.CreateInstance(box.SelectedItem as Type);
			Combo combo = DataContext as Combo;
			if (newItem is Entree entree)
			{
				combo.Entree = entree;
			}else if (newItem is Side side)
			{
				combo.Side = side;
			}else if (newItem is Drink drink)
			{
				combo.Drink = drink;
			}
			panel.LoadOptionsForItem(newItem);
		}

		private BleakwindCheckBox AddCheckBox(PropertyInfo propertyInfo, string label, bool defaultValue)
		{
			BleakwindCheckBox x = new BleakwindCheckBox();
			CheckBox box = x.Box;
			box.Tag = propertyInfo;
			box.Checked += OnCheckBoxChecked;
			box.Unchecked += OnCheckBoxUnchecked;
			x.TextBlock.Text = label;

			box.IsChecked = defaultValue;

			stack.Children.Add(x);
			return x;
		}

		private ComboBox AddComboBox(PropertyInfo propertyInfo, IEnumerable itemsSource)
		{

			ComboBox box = new ComboBox();
			box.Tag = propertyInfo;
			box.ItemsSource = itemsSource;
			box.SelectedIndex = 0;
			box.SelectionChanged += OnComboBoxSelectionChanged;

			stack.Children.Add(box);
			return box;
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
