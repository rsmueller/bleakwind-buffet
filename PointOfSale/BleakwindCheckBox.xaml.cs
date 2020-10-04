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
 * Class Name: BleakwindCheckBox.cs
 * Purpose: Houses a checkbox to theme to Bleakwind theme
 */
namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for BleakwindCheckBox.xaml
	/// </summary>
	public partial class BleakwindCheckBox : UserControl
	{

		public CheckBox Box { get { return checkbox; } }
		public TextBlock TextBlock { get { return textblock; } }
		public BleakwindCheckBox()
		{
			InitializeComponent();
		}
	}
}
