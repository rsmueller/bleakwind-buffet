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
			TextBox box = new TextBox();
			box.Text = item.ToString();
			stack.Children.Add(box);
		}

		public OrderList()
		{
			InitializeComponent();
			list = new List<IOrderItem>(); 
		}
	}
}
