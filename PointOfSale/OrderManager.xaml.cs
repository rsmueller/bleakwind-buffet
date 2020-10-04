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

		private ItemCustomizationPanel currentCustomizationPanel;

		private IOrderItem currentOrderItem;

		/// <summary>
		/// Switch from menu to customization panel
		/// </summary>
		public void CustomizeItem(IOrderItem item)
		{
			menu.IsEnabled = false;
			menu.Visibility = Visibility.Hidden;

			ItemCustomizationPanel customizationPanel = new ItemCustomizationPanel();
			grid.Children.Add(customizationPanel);
			Grid.SetColumn(customizationPanel, 0);
			customizationPanel.BtnAddToOrder.Click += OnBtnAddToOrderClicked;
			customizationPanel.BtnClose.Click += OnBtnCloseClicked;

			customizationPanel.LoadOptionsForItem(item);

			currentCustomizationPanel = customizationPanel;
			currentOrderItem = item;
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
			orderList.AddItemToOrder(currentOrderItem);
			GoBackToMenu();
		}
	}
}
