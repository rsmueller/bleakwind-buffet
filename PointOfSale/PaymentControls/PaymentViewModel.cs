using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using RoundRegister;

namespace PointOfSale.PaymentControls
{
	public class PaymentViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;

		private double totalSale;
		public double TotalSale { get => totalSale;
			set 
			{
				totalSale = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalSale"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			} 
		}

		public bool EnoughPaid { get { return AmountDue == 0; } }

		/// <summary>
		/// How much change the customer is owed
		/// </summary>
		public double ChangeOwed { get => Math.Max(0, GivenTotal - TotalSale); }
		public double AmountDue { get { return Math.Max(0, TotalSale - GivenTotal); } }

		#region DrawerCash
		public int DrawerPennies { get => RoundRegister.CashDrawer.Pennies; set => RoundRegister.CashDrawer.Pennies = value; }
		public int DrawerNickels { get => RoundRegister.CashDrawer.Nickels; set => RoundRegister.CashDrawer.Nickels = value; }
		public int DrawerDimes { get => RoundRegister.CashDrawer.Dimes; set => RoundRegister.CashDrawer.Dimes = value; }
		public int DrawerQuarters { get => RoundRegister.CashDrawer.Quarters; set => RoundRegister.CashDrawer.Quarters = value; }
		public int DrawerHalfDollars { get => RoundRegister.CashDrawer.HalfDollars; set => RoundRegister.CashDrawer.HalfDollars = value; }
		public int DrawerDollarCoins { get => RoundRegister.CashDrawer.Dollars; set => RoundRegister.CashDrawer.Dollars = value; }
		public int DrawerOnes { get => RoundRegister.CashDrawer.Ones; set => RoundRegister.CashDrawer.Ones = value; }
		public int DrawerTwos { get => RoundRegister.CashDrawer.Twos; set => RoundRegister.CashDrawer.Twos = value; }
		public int DrawerFives { get => RoundRegister.CashDrawer.Fives; set => RoundRegister.CashDrawer.Fives = value; }
		public int DrawerTens { get => RoundRegister.CashDrawer.Tens; set => RoundRegister.CashDrawer.Tens = value; }
		public int DrawerTwenties { get => RoundRegister.CashDrawer.Twenties; set => RoundRegister.CashDrawer.Twenties = value; }
		public int DrawerFifties { get => RoundRegister.CashDrawer.Fifties; set => RoundRegister.CashDrawer.Fifties = value; }
		public int DrawerHundreds { get => RoundRegister.CashDrawer.Hundreds; set => RoundRegister.CashDrawer.Hundreds = value; }
		public double DrawerTotal { get => RoundRegister.CashDrawer.Total; }
		#endregion



		#region GivenCash 
		private int givenPennies;
		public int GivenPennies { get { return givenPennies; } 
			set 
			{
				givenPennies = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenPennies"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			} 
		}
		private int givenNickels;
		public int GivenNickels {
			get { return givenNickels; }
			set {
				givenNickels = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenNickels"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenDimes;
		public int GivenDimes {
			get { return givenDimes; }
			set {
				givenDimes = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenDimes"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenQuarters;
		public int GivenQuarters {
			get { return givenQuarters; }
			set {
				givenQuarters = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenQuarters"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenHalfDollars;
		public int GivenHalfDollars {
			get { return givenHalfDollars; }
			set {
				givenHalfDollars = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenHalfDollars"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenDollarCoins;
		public int GivenDollarCoins {
			get { return givenDollarCoins; }
			set {
				givenDollarCoins = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenDollarCoins"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenOnes;
		public int GivenOnes {
			get { return givenOnes; }
			set {
				givenOnes = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenOnes"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenTwos;
		public int GivenTwos {
			get { return givenTwos; }
			set {
				givenTwos = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTwos"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenFives;
		public int GivenFives {
			get { return givenFives; }
			set {
				givenFives = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenFives"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenTens;
		public int GivenTens {
			get { return givenTens; }
			set {
				givenTens = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTens"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenTwenties;
		public int GivenTwenties {
			get { return givenTwenties; }
			set {
				givenTwenties = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTwenties"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenFifties;
		public int GivenFifties {
			get { return givenFifties; }
			set {
				givenFifties = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenFifties"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			}
		}
		private int givenHundreds;
		public int GivenHundreds { get { return givenHundreds; } 
			set 
			{
				givenHundreds = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenTotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GivenHundreds"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnoughPaid"));
			} 
		}
		public double GivenTotal { get {
				return
					(GivenPennies * 0.01) +
					(GivenNickels * 0.05) +
					(GivenDimes * 0.10) +
					(GivenQuarters * 0.25) +
					(GivenHalfDollars * 0.50) +
					(GivenDollarCoins * 1) +
					(GivenOnes * 1) +
					(GivenTwos * 2) +
					(GivenFives * 5) +
					(GivenTens * 10) +
					(GivenTwenties * 20) +
					(GivenFifties * 50) +
					(GivenHundreds * 100);
					}
		}

		#endregion

		public int ReturnPennies { get; private set; }
		public int ReturnNickels { get; private set; }
		public int ReturnDimes { get; private set; }
		public int ReturnQuarters { get; private set; }
		public int ReturnHalfCoins { get; private set; }
		public int ReturnDollarCoins { get; private set; }
		public int ReturnOnes { get; private set; }
		public int ReturnTwos { get; private set; }
		public int ReturnFives { get; private set; }
		public int ReturnTens { get; private set; }
		public int ReturnTwenties { get; private set; }
		public int ReturnFifties { get; private set; }
		public int ReturnHundreds { get; private set; }

		private void CalculateReturn()
		{
			double x = ChangeOwed;

			while (x > 100 && DrawerHundreds > ReturnHundreds)
			{
				x -= 100;
				ReturnHundreds++;
			}
			while (x > 50 && DrawerFifties > ReturnFifties)
			{
				x -= 50;
				ReturnFifties++;
			} while (x > 20 && DrawerTwenties > ReturnTwenties)
			{
				x -= 20;
				ReturnTwenties++;
			} while (x > 10 && DrawerTens > ReturnTens)
			{
				x -= 10;
				ReturnTens++;
			} while (x > 5 && DrawerFives > ReturnFives)
			{
				x -= 5;
				ReturnFives++;
			} while (x > 2 && DrawerTwos > ReturnTwos)
			{
				x -= 2;
				ReturnTwos++;
			} while (x > 1 && DrawerOnes > ReturnOnes)
			{
				x -= 1;
				ReturnOnes++;
			} while (x > 1 && DrawerDollarCoins > ReturnDollarCoins)
			{
				x -= 1;
				ReturnDollarCoins++;
			} while (x > .50 && DrawerHalfDollars > ReturnHalfCoins)
			{
				x -= .50;
				ReturnHalfCoins++;
			} while (x > .25 && DrawerQuarters > ReturnQuarters)
			{
				x -= .25;
				ReturnQuarters++;
			} while (x > .10 && DrawerDimes > ReturnDimes)
			{
				x -= .10;
				ReturnDimes++;
			} while (x > .05 && DrawerNickels > ReturnNickels)
			{
				x -= .05;
				ReturnNickels++;
			} while (x > .01 && DrawerPennies > ReturnPennies)
			{
				x -= .01;
				ReturnPennies++;
			}

			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnHundreds"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnFifties"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnTwenties"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnTens"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnFives"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnTwos"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnOnes"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnDollarCoins"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnHalfCoins"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnQuarters"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnDimes"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnNickels"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReturnPennies"));

		}

		public void OpenDrawer()
		{
			RoundRegister.CashDrawer.OpenDrawer();
			RoundRegister.CashDrawer.Hundreds += GivenHundreds - ReturnHundreds;
			RoundRegister.CashDrawer.Fifties += GivenFifties - ReturnFifties;
			RoundRegister.CashDrawer.Twenties += GivenTwenties - ReturnTwenties;
			RoundRegister.CashDrawer.Tens += GivenTens - ReturnTens;
			RoundRegister.CashDrawer.Fives += GivenFives - ReturnFives;
			RoundRegister.CashDrawer.Twos += GivenTwos - ReturnTwos;
			RoundRegister.CashDrawer.Ones += GivenOnes - ReturnOnes;
			RoundRegister.CashDrawer.Dollars += GivenDollarCoins - ReturnDollarCoins;
			RoundRegister.CashDrawer.HalfDollars += GivenHalfDollars - ReturnHalfCoins;
			RoundRegister.CashDrawer.Quarters += GivenQuarters - ReturnQuarters;
			RoundRegister.CashDrawer.Dimes += GivenDimes - ReturnDimes;
			RoundRegister.CashDrawer.Nickels += GivenNickels - ReturnNickels;
		}

		private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "AmountDue")
			{
				CalculateReturn();
			}
		}

		public PaymentViewModel()
		{
			PropertyChanged += OnPropertyChanged;
		}

	}
}
