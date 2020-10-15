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
		private enum Screen { Menu, Customization, Payment}
		private Screen currentScreen = Screen.Menu;
		private Screen previousScreen = Screen.Menu;

		/// <summary>
		/// Reference to the runtime OrderManager object
		/// </summary>
		public static OrderManager singleton;

		/// <summary>
		/// Is the menu currently visible?
		/// </summary>
		public bool ShowingMenu { get { return currentScreen == Screen.Menu; } }

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
			currentOrderItem = item;

			currentCustomizationPanel = customizationPanel;

			SwitchToScreen(Screen.Customization);
		}

		private void SwitchToScreen(Screen screen)
		{
			if (currentScreen == screen)
			{
				return;
			}

			previousScreen = currentScreen;
			currentScreen = screen;

			if (screen == Screen.Menu)
			{
				ShowMenu();
				HideCustomization();
				HidePayment();
			}else if (screen == Screen.Customization)
			{
				HideMenu();
				ShowCustomization();
				HidePayment();
			}else if (screen == Screen.Payment)
			{
				HideMenu();
				HideCustomization();
				ShowPayment();
			}
		}

		public OrderManager()
		{
			singleton = this;
			InitializeComponent();
		}

		private void ShowMenu()
		{
			menu.IsEnabled = true;
			menu.Visibility = Visibility.Visible;
		}

		private void HideMenu()
		{
			menu.IsEnabled = false;
			menu.Visibility = Visibility.Hidden;
		}

		private void ShowCustomization()
		{
			if (currentCustomizationPanel != null)
			{
				grid.Children.Add(currentCustomizationPanel);
				Grid.SetColumn(currentCustomizationPanel, 0);
			}
		}

		private void HideCustomization()
		{
			if (currentCustomizationPanel != null)
			{
				grid.Children.Remove(currentCustomizationPanel);
				currentCustomizationPanel = null;
				currentOrderItem = null;
			}
		}

		private void ShowPayment()
		{
			payment.IsEnabled = true;
			payment.Visibility = Visibility.Visible;
		}

		private void HidePayment()
		{
			payment.IsEnabled = false;
			payment.Visibility = Visibility.Hidden;
		}

		/// <summary>
		/// Return to previous screen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBtnCloseClicked(object sender, RoutedEventArgs e)
		{
			SwitchToScreen(previousScreen);
		}

		/// <summary>
		/// Save item to order then go back to previous screen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBtnAddToOrderClicked(object sender, RoutedEventArgs e)
		{
			if ( ! orderList.ContainsItemInOrder(currentOrderItem))
			{
				orderList.AddItemToOrder(currentOrderItem, currentCustomizationPanel);
			}
			SwitchToScreen(previousScreen);
		}

		private void OnBtnFinishOrderClicked(object sender, RoutedEventArgs e)
		{
			if (e.OriginalSource is Button button)
			{
				if (button.Name == "btnFinishOrder")
				{
					SwitchToScreen(Screen.Payment);
				}else if (button.Name == "btnReturnToOrder")
				{
					SwitchToScreen(Screen.Menu);
				}
			}
		}

	}
}
