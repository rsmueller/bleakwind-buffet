using BleakwindBuffet.Data;
using System;
using System.CodeDom;
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
	/// Interaction logic for MenuDisplay.xaml
	/// </summary>
	public partial class MenuDisplay : UserControl
	{
		private const int ITEMS_PER_COLUMN = 4, ROWS_ON_SCREEN = 4;
		
		private StackPanel currentColumn;

		public MenuDisplay()
		{
			InitializeComponent();
			SizeChanged += OnWindowResized;
			AddColumnStack();
		}

		/// <summary>
		/// Display a new menu
		/// </summary>
		public void NewMenu(IEnumerable<Type> items)
		{
			ClearDisplay();
			foreach (Type item in items)
			{
				AddItem(item);
			}
		}

		/// <summary>
		/// Clears out all the menu
		/// </summary>
		private void ClearDisplay()
		{
			RowStack.Children.Clear();
			AddColumnStack();
		}

		/// <summary>
		/// Resizes the displayed items to properly fill the space
		/// </summary>
		public void ResizeItems()
		{
			foreach (StackPanel stack in RowStack.Children)
			{
				foreach (Item item in stack.Children)
				{
					item.Width = (ActualWidth - SystemParameters.VerticalScrollBarWidth) / ITEMS_PER_COLUMN;
					item.Height = ActualHeight / ROWS_ON_SCREEN;
				}
			}
		}

		/// <summary>
		/// Adds orderItem to the menu display into last available spot
		/// </summary>
		/// <param name="orderItem"></param>
		private void AddItem(Type orderItem)
		{
			if (currentColumn.Children.Count >= ITEMS_PER_COLUMN)
			{
				AddColumnStack(); 
			}

			Item item = new Item();
			currentColumn.Children.Add(item);
			item.ItemImage = OrderItemImageLibrary.GetImageForIOrderItem(orderItem);
			item.ItemName = ((IOrderItem)Activator.CreateInstance(orderItem)).DisplayName;
			item.ItemType = orderItem;
		}

		/// <summary>
		/// Creates a column stack and is placed inside the row stack
		/// Updates currentColumn
		/// </summary>
		private void AddColumnStack()
		{
			StackPanel columnStack = new StackPanel();
			columnStack.Orientation = Orientation.Horizontal;
			RowStack.Children.Add(columnStack);
			currentColumn = columnStack;
		}

		/// <summary>
		/// Resize the items when window is resized.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void OnWindowResized(object sender, RoutedEventArgs e)
		{
			ResizeItems();
		}
	}
}
