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

/*
 * Author: Riley Mueller
 * Last Modified: 10/1/2020
 * Class Name: OrderManager.cs
 * Purpose: The overarching manager for all things related to creating a order
 */
namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for OrderManager.xaml
	/// </summary>
	public partial class OrderManager : UserControl
	{
		/// <summary>
		/// Reference to the runtime OrderManager object
		/// </summary>
		public static OrderManager singleton;

		/// <summary>
		/// Is the menu currently visible?
		/// </summary>
		public bool ShowingMenu { get; private set; }

		private ItemCustomizationPanel currentCustomizationPanel;

		private IOrderItem currentOrderItem;

		/// <summary>
		/// Switch from menu to customization panel for an item
		/// </summary>
		public void CustomizeItem(IOrderItem item)
		{
			ItemCustomizationPanel customizationPanel = new ItemCustomizationPanel();
			customizationPanel.BtnAddToOrder.Click += OnBtnAddToOrderClicked;
			customizationPanel.BtnClose.Click += OnBtnCloseClicked;
			customizationPanel.LoadOptionsForItem(item);

			CustomizeItem(item, customizationPanel);
		}

		/// <summary>
		/// Switch from menu to customization panel for an item
		/// that already has a customization panel generated for it.
		/// </summary>
		/// <param name="item"></param>
		/// <param name="customizationPanel"></param>
		public void CustomizeItem(IOrderItem item, ItemCustomizationPanel customizationPanel)
		{

			menu.IsEnabled = false;
			ShowingMenu = false;
			menu.Visibility = Visibility.Hidden;

			currentOrderItem = item;

			grid.Children.Add(customizationPanel);
			Grid.SetColumn(customizationPanel, 0);
			currentCustomizationPanel = customizationPanel;
		}


		public OrderManager()
		{
			singleton = this;
			InitializeComponent();
		}

		/// <summary>
		/// Close the customization panel and reopen the menu
		/// </summary>
		private void GoBackToMenu()
		{
			ShowingMenu = true;

			grid.Children.Remove(currentCustomizationPanel);
			menu.IsEnabled = true;
			menu.Visibility = Visibility.Visible;

			currentCustomizationPanel = null;
			currentOrderItem = null;
		}

		/// <summary>
		/// Just go back to the menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBtnCloseClicked(object sender, RoutedEventArgs e)
		{
			GoBackToMenu();
		}

		/// <summary>
		/// Save item to order then go back to menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBtnAddToOrderClicked(object sender, RoutedEventArgs e)
		{
			if ( ! orderList.ContainsItemInOrder(currentOrderItem))
			{
				orderList.AddItemToOrder(currentOrderItem, currentCustomizationPanel);
			}
			GoBackToMenu();
		}

	}
}
