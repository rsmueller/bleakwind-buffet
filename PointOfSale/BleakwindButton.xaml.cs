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
 * Class Name: BleakwindButton.cs
 * Purpose: Extends Button to theme to Bleakwind theme
 */
namespace PointOfSale
{

	/// <summary>
	/// Interaction logic for BleakwindButton.xaml
	/// </summary>
	public partial class BleakwindButton : Button
	{
		public BleakwindButton()
		{
			InitializeComponent();
			IsEnabledChanged += OnIsEnabledChanged;
		}

		private static SolidColorBrush WhiteBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
		private static SolidColorBrush GrayBrush = new SolidColorBrush(Color.FromRgb(135, 135, 135));

		private void OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (IsEnabled)
			{
				this.Foreground = WhiteBrush;
			}
			else
			{
				this.Foreground = GrayBrush;
			}
		}
	}
}
