using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
 * Class Name: OrderItem.xaml.cs
 * Purpose: GUI for an IOrderItem in OrderList.xaml
 */
namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for OrderItem.xaml
	/// </summary>
	public partial class OrderItem : UserControl
	{

		/// <summary>
		/// Button to pull up the ItemCustomizationPanel of this item
		/// </summary>
		public Button BtnEdit { get { return btnEdit; } }

		/// <summary>
		/// Button to remove this item from the order
		/// </summary>
		public Button BtnRemove { get { return btnRemove; } }

		public ItemCustomizationPanel CustomizationPanel { get; }
		public OrderItem(ItemCustomizationPanel panel)
		{
			CustomizationPanel = panel;
			this.DataContext = panel.DataContext;
			InitializeComponent();
			SetExtraInfo((DataContext as IOrderItem).SpecialInstructions);
			txtName.Text = DataContext.ToString();
			if (DataContext is INotifyPropertyChanged propertyChanged)
			{
				propertyChanged.PropertyChanged += OnPropertyChanged;
			}
		}

		private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			IOrderItem item = sender as IOrderItem;
			if (e.PropertyName == "SpecialInstructions")
			{
				SetExtraInfo(item.SpecialInstructions);
			}
			if (e.PropertyName == "Size")
			{
				txtName.Text = item.ToString();
			}
			else if (e.PropertyName == "Flavor")
			{
				txtName.Text = item.ToString();
			}
		}

		private void SetExtraInfo (List<string> info){

			stackPanel.Children.Clear();
			StringBuilder sb = new StringBuilder();
			foreach (string s in info)
			{
				sb.Append($"\n\t{s}");
			}

			if (sb.Length != 0)
			{
				sb.Remove(0, 1);
			}

			BleakwindTextBox box = new BleakwindTextBox();
			box.TextAlignment = TextAlignment.Left;
			box.Text = sb.ToString();
			stackPanel.Children.Add(box);
			
		}

	}
}
