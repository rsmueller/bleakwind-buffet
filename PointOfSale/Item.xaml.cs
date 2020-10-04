using BleakwindBuffet.Data;
using System;
using System.CodeDom;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * Author: Riley Mueller
 * Last Modified: 10/1/2020
 * Class Name: Item.cs
 * Purpose: Represents an orderable menu item.
 */
namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for Item.xaml
	/// </summary>
	public partial class Item : UserControl
	{
		public ImageSource ItemImage { get { return itemImage.Source; } set { itemImage.Source = value; } }

		public string ItemName { get { return itemName.Text; } set { itemName.Text = value; } }

		public Type ItemType { get; set; }

		public Item()
		{
			InitializeComponent();
			itemButton.Click += OnItemButtonClicked;
		}

		/// <summary>
		/// Tells the OrderManager to begin customization of this item
		/// Technically a copy of this item so that multiple in order are allowed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnItemButtonClicked(object sender, RoutedEventArgs e)
		{
			IOrderItem item = (IOrderItem)Activator.CreateInstance(ItemType);
			OrderManager.singleton.CustomizeItem(item);	
		}
	}
}
