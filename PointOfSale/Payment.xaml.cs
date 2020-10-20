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
using BleakwindBuffet.Data;
using PointOfSale.PaymentControls;

namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for Payment.xaml
	/// </summary>
	public partial class Payment : UserControl
	{

		private PaymentViewModel pvm = new PaymentViewModel();


		public Payment()
		{
			InitializeComponent();
			cashDrawer.DataContext = pvm;
			DataContextChanged += OnDataContextChanged;
			btnCash.Click += OnCashPaymentClicked;
			btnCancel.Click += OnCancelCashPaymentClicked;
			btnCreditDebit.Click += OnCardPaymentClicked;
			btnFinalizeSale.Click += OnFinalizeSaleClicked;
		}

		public void OnFinalizeSaleClicked(object sender, RoutedEventArgs e)
		{
			if (cardPaid || pvm.EnoughPaid)
			{
				pvm.OpenDrawer();
				PrintReciept();
			}
		}

		private bool isCashpayment = false;
		private void PrintReciept()
		{
			Order order = DataContext as Order;
			List<string> list = new List<string>();
			list.Add($"Reciept #{order.Number} on {DateTime.Now}");
			foreach (IOrderItem item in order)
			{
				list.Add($"{item.ToString()} - {item.Price:C2}");
				foreach (string line in item.SpecialInstructions)
				{
					list.Add(line);
				}
			}
			list.Add($"Subtotal: {order.Subtotal:C2}");
			list.Add($"Tax: {order.Tax}");
			list.Add($"Total: {order.Total}");
			if (isCashpayment)
			{
				list.Add($"Cash payment with {pvm.ChangeOwed:C2}");
			}
			else
			{
				list.Add("Paid with card");
			}
			foreach (string line in list)
			{
				StringBuilder sb = new StringBuilder(line);
				while (sb.Length > 40)
				{
					RoundRegister.RecieptPrinter.PrintLine(sb.Remove(0, 40).ToString());
					sb.Append("\t", 0, 1);
				}
				RoundRegister.RecieptPrinter.PrintLine(sb.ToString());
			}
			RoundRegister.RecieptPrinter.CutTape();
		}

		private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{

			Order order = DataContext as Order;
			cardPaid = false;
			lblOrderNumber.Text = $"Payment for Order #{order.Number}";
			UpdateTotalSale();
		}

		public void UpdateTotalSale()
		{

			Order order = DataContext as Order;
			pvm.TotalSale = order.Total;
		}

		private void OnPVMPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "EnoughPaid")
			{
				if (pvm.EnoughPaid)
				{
					btnFinalizeSale.IsEnabled = true;
				}
			}
		}

		private bool cardPaid = false;

		private void OnCardPaymentClicked(object sender, RoutedEventArgs e)
		{
			isCashpayment = false;
			Order order = DataContext as Order;
			var result = RoundRegister.CardReader.RunCard(order.Total);
			switch (result)
			{
				case RoundRegister.CardTransactionResult.Approved:
					MessageBox.Show("Card Approved");
					cardPaid = true;
					break;
				case RoundRegister.CardTransactionResult.Declined:
					MessageBox.Show("Card Declinder");
					break;
				case RoundRegister.CardTransactionResult.InsufficientFunds:
					MessageBox.Show("Insufficient Funds");
					break;
				case RoundRegister.CardTransactionResult.IncorrectPin:
					MessageBox.Show("Incorrect Pin");
					break;
				case RoundRegister.CardTransactionResult.ReadError:
					MessageBox.Show("Read Error");
					break;
			}
		}

		private void OnCashPaymentClicked(object sender, RoutedEventArgs e)
		{
			isCashpayment = true;
			txtDisplayInfo.IsEnabled = false;
			txtDisplayInfo.Visibility = Visibility.Hidden;
			cashDrawer.IsEnabled = true;
			cashDrawer.Visibility = Visibility.Visible;

			btnCash.Visibility = Visibility.Hidden;
			btnCreditDebit.Visibility = Visibility.Hidden;

			btnCancel.Visibility = Visibility.Visible;

		}

		private void OnCancelCashPaymentClicked(object sender, RoutedEventArgs e)
		{
			txtDisplayInfo.IsEnabled = true;
			txtDisplayInfo.Visibility = Visibility.Visible;
			cashDrawer.IsEnabled = false;
			cashDrawer.Visibility = Visibility.Hidden;


			btnCash.Visibility = Visibility.Visible;
			btnCreditDebit.Visibility = Visibility.Visible;

			btnCancel.Visibility = Visibility.Hidden;
		}

	}
}
