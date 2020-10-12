using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections.ObjectModel;

/*
 * Author: Riley Mueller
 * Class Name: Order.cs
 * Purpose: Represents an order (Collection of IOrderItems)
 */
namespace BleakwindBuffet.Data
{
	public class Order : ObservableCollection<IOrderItem>, ICollection<IOrderItem>
	{

		/// <summary>
		/// Sales tax rate of the order
		/// </summary>
		public double SalesTaxRate { get; set; } = 0.12;

		/// <summary>
		/// Total price for all items in the order
		/// </summary>
		public double Subtotal { 
			get {
				double sum = 0;
				foreach (IOrderItem item in Items)
					sum += item.Price;
				return sum;
			}
		}

		/// <summary>
		/// Subtotal multiplied by SalesTaxRate
		/// </summary>
		public double Tax { get { return Subtotal * SalesTaxRate; } }

		/// <summary>
		/// Sum of the Subtotal and Tax
		/// </summary>
		public double Total { get { return Subtotal + Tax; } }

		/// <summary>
		/// Sum of all the calories of the items in the order
		/// </summary>
		public uint Calories { 
			get {
				uint sum = 0;
				foreach (IOrderItem item in Items)
					sum += item.Calories;
				return sum;
			} 
		}

		/// <summary>
		/// Unique identifier of this order
		/// </summary>
		public uint Number { get; }


		private static uint nextOrderNumber = 1;

		public Order()
		{
			Number = nextOrderNumber;
			nextOrderNumber++;
			CollectionChanged += CollectionChangedListener;
		}

		#region INotifyCollectionChangedSpecifics
		
		/// <summary>
		/// Listens to CollectionChanged to add/remove item listeners and trigger PropertyChanged
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
		{
			// No matter if an item was added or removed, these things still change
			OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
			OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
			OnPropertyChanged(new PropertyChangedEventArgs("Total"));
			OnPropertyChanged(new PropertyChangedEventArgs("Calories"));

			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
					foreach (var item in e.NewItems)
					{
						if (item is INotifyPropertyChanged notifiable)
						{
							notifiable.PropertyChanged += CollectionItemChangedListener;
						}
					}
					break;
				case NotifyCollectionChangedAction.Move:
					break;
				case NotifyCollectionChangedAction.Remove:
					foreach (var item in e.OldItems)
					{
						if (item is INotifyPropertyChanged notifiable)
						{
							notifiable.PropertyChanged -= CollectionItemChangedListener;
						}
					}
					break;
				case NotifyCollectionChangedAction.Replace:
					break;
				case NotifyCollectionChangedAction.Reset:
					foreach (var item in Items)
					{
						if (item is INotifyPropertyChanged notifiable)
						{
							notifiable.PropertyChanged -= CollectionItemChangedListener;
						}
					}
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// Listener added to IOrderItems to curry their Price and Calories PropertyChanged events
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Price")
			{
				OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
				OnPropertyChanged(new PropertyChangedEventArgs("Total"));
				OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
			}else if (e.PropertyName == "Calories")
			{
				OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
			}
		}
		
		#endregion
	}
}
