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
 * Class Name: OrderList.cs
 * Purpose: Holds IOrderItems commited to an order
 * Responsible for buttons to cancel or finish the order
 */
namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for OrderList.xaml
	/// </summary>
	public partial class OrderList : UserControl
	{

		public Order CurrentOrder { get { return orders[orders.Count - 1]; } }
		private List<Order> orders;

		private Dictionary<Button, OrderItem> buttonItemPairs;

		public Button BtnFinishOrder { get => btnFinishOrder; }
		public Button BtnReturnToOrder { get => btnReturnToOrder; }

		/// <summary>
		/// Returns if the order already contains the item
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public bool ContainsItemInOrder(IOrderItem item)
		{
			return CurrentOrder.Contains(item);
		}

		/// <summary>
		/// Very temporary implementation of order
		/// </summary>
		/// <param name="item"></param>
		public void AddItemToOrder(IOrderItem item, ItemCustomizationPanel itemCustomizationPanel)
		{
			CurrentOrder.Add(item);
			OrderItem guiItem = new OrderItem(itemCustomizationPanel);
			buttonItemPairs.Add(guiItem.btnEdit, guiItem);
			buttonItemPairs.Add(guiItem.btnRemove, guiItem);
			guiItem.btnRemove.Click += OnBtnRemoveItemClicked;
			guiItem.btnEdit.Click += OnBtnEditItemClicked;
			stack.Children.Add(guiItem);
		}

		public OrderList()
		{
			buttonItemPairs = new Dictionary<Button, OrderItem>();
			InitializeComponent(); 
			btnCancelOrder.Click += OnCancelOrder;
			btnFinishOrder.Click += OnFinishOrder;
			btnReturnToOrder.Click += OnReturnToOrder;

			btnReturnToOrder.Click += OrderManager.singleton.OnBtnReturnToOrderClicked;
			btnFinishOrder.Click += OrderManager.singleton.OnBtnFinishOrderClicked;


			orders = new List<Order>();
			CreateNewOrder();
		}

		void OnBtnEditItemClicked(object sender, RoutedEventArgs e)
		{
			if (OrderManager.singleton.ShowingMenu)
			{
				OrderItem orderItem = buttonItemPairs[sender as Button];
				OrderManager.singleton.CustomizeItem(orderItem.DataContext as IOrderItem, orderItem.CustomizationPanel);
			}
		}

		void OnBtnRemoveItemClicked(object sender, RoutedEventArgs e)
		{
			OrderItem orderItem = buttonItemPairs[sender as Button];
			RemoveOrderItem(orderItem);
		}

		private void RemoveOrderItem(OrderItem orderItem)
		{
			CurrentOrder.Remove(orderItem.DataContext as IOrderItem);
			stack.Children.Remove(orderItem);
			orderItem.btnRemove.Click -= OnBtnRemoveItemClicked;
			orderItem.btnEdit.Click -= OnBtnEditItemClicked;
			buttonItemPairs.Remove(orderItem.BtnEdit);
			buttonItemPairs.Remove(orderItem.BtnRemove);
		}

		/// <summary>
		/// Clear the order of all items
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OnCancelOrder(object sender, RoutedEventArgs e)
		{
			Control[] arr = new Control[stack.Children.Count];
			stack.Children.CopyTo(arr, 0);
			foreach (Control item in arr)
			{
				if (item is OrderItem orderItem)
				{
					RemoveOrderItem(orderItem);
				}
			}
			CurrentOrder.Clear();
		}

		void CreateNewOrder()
		{
			orders.Add(new Order());
			DataContext = CurrentOrder;
			txtOrderNumber.Text = $"Order #{CurrentOrder.Number}";
		}

		void OnFinishOrder(object sender, RoutedEventArgs e)
		{
			if (CurrentOrder.Count == 0)
			{
				return;
			}

			foreach (Button button in buttonItemPairs.Keys)
			{
				button.IsEnabled = false;
				button.Visibility = Visibility.Collapsed;
			}



			/*previousOrders.Add(order);

			Control[] arr = new Control[stack.Children.Count];
			stack.Children.CopyTo(arr, 0);
			foreach (Control item in arr)
			{
				if (item is OrderItem orderItem)
				{
					RemoveOrderItem(orderItem);
				}
			}

			order = new Order();
			txtOrderNumber.Text = $"Order #{order.Number}";*/

			btnReturnToOrder.Visibility = Visibility.Visible;
			btnReturnToOrder.IsEnabled = true;

			btnCancelOrder.Visibility = Visibility.Hidden;
			btnCancelOrder.IsEnabled = false;
			btnFinishOrder.Visibility = Visibility.Hidden;
			btnFinishOrder.IsEnabled = false;
		}

		void OnReturnToOrder(object sender, RoutedEventArgs e)
		{
			foreach (Button button in buttonItemPairs.Keys)
			{
				button.IsEnabled = true;
				button.Visibility = Visibility.Visible;
			}
			btnReturnToOrder.Visibility = Visibility.Hidden;
			btnReturnToOrder.IsEnabled = false;

			btnCancelOrder.Visibility = Visibility.Visible;
			btnCancelOrder.IsEnabled = true;
			btnFinishOrder.Visibility = Visibility.Visible;
			btnFinishOrder.IsEnabled = true;
		}
	}
}
