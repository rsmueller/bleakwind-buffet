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
		private List<IOrderItem> list;

		/// <summary>
		/// Very temporary implementation of order
		/// </summary>
		/// <param name="item"></param>
		public void AddItemToOrder(IOrderItem item)
		{
			list.Add(item);
			BleakwindTextBox box = new BleakwindTextBox();
			box.Text = item.ToString();
			stack.Children.Add(box);
		}

		public OrderList()
		{
			InitializeComponent();
			btnCancelOrder.Click += OnCancelOrder;
			btnFinishOrder.Click += OnFinishOrder;
			list = new List<IOrderItem>(); 
		}

		void OnFinishOrder(object sender, RoutedEventArgs e)
		{

		}
		void OnCancelOrder(object sender, RoutedEventArgs e)
		{
			stack.Children.Clear();
			list.Clear();
		}
	}
}
