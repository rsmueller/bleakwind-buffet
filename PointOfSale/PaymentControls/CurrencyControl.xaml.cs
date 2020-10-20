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

namespace PointOfSale.PaymentControls
{
	/// <summary>
	/// Interaction logic for CurrencyControl.xaml
	/// </summary>
	public partial class CurrencyControl : UserControl
	{

		public static DependencyProperty GivenProperty = DependencyProperty.Register("Given", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.AffectsRender));
		public static DependencyProperty ChangeProperty = DependencyProperty.Register("Change", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));
		public static DependencyProperty DenominationLabelProperty = DependencyProperty.Register("Denomination", typeof(string), typeof(CurrencyControl));
		public static DependencyProperty DenominationValueProperty = DependencyProperty.Register("DenominationValue", typeof(double), typeof(CurrencyControl));

		/// <summary>
		/// The amount of change for this denomination given by the customer.
		/// </summary>
		public int Given { get { return (int)GetValue(GivenProperty); } set { lblGiven.Content = value.ToString(); SetValue(GivenProperty, value); } }

		/// <summary>
		/// The amount of change to return to the customer.
		/// </summary>
		public int Change { 
			get { return (int)GetValue(ChangeProperty); } 
			set { lblChange.Content = value.ToString(); SetValue(ChangeProperty, value); } }

		/// <summary>
		/// The denomination label of change of this control
		/// </summary>
		public string DenominationLabel { get { return lblDenomination.Content as string; } set { lblDenomination.Content = value; } }

		public CurrencyControl()
		{
			InitializeComponent();
			btnAdd.Click += OnBtnAddClicked;
			btnSub.Click += OnBtnSubClicked;
		}

		private void OnBtnAddClicked(object sender, RoutedEventArgs e)
		{
			Given++;
		}
		private void OnBtnSubClicked(object sender, RoutedEventArgs e)
		{
			if (Given == 0)
				return;
			Given--;
		}
	}
}
