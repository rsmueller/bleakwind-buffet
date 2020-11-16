using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/*
 * Author: Riley Mueller
 * Class Name: Combo.cs
 * Purpose: Provides a combination of entree, side, and drink as an IOrderItem
 */
namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {

        private Entree entree;
        /// <summary>
        /// The entree property of the combo
        /// </summary>
        public Entree Entree { get { return entree; } 
            set {
				if (entree != null)
				{
                    entree.PropertyChanged -= ItemPropertyChangedListener;
				}
                entree = value;
                entree.PropertyChanged += ItemPropertyChangedListener;
                OnPropertyChanged("Entree");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
            } 
        }

        private Side side;
        /// <summary>
        /// The side property of the combo
        /// </summary>
        public Side Side { get { return side; } 
            set {
                if (side != null)
                {
                    side.PropertyChanged -= ItemPropertyChangedListener;
                }
                side = value;
                side.PropertyChanged += ItemPropertyChangedListener;
                OnPropertyChanged("Side");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
            } 
        }

        private Drink drink;
        /// <summary>
        /// The drink property of the combo
        /// </summary>
        public Drink Drink { get { return drink; } 
            set {
                if (drink != null)
                {
                    drink.PropertyChanged -= ItemPropertyChangedListener;
                }
                drink = value;
                drink.PropertyChanged += ItemPropertyChangedListener;
                OnPropertyChanged("Drink");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
            } 
        }

        /// <summary>
        /// Display Name for a Combo Item
        /// </summary>
        public string DisplayName => "Combo";

        /// <summary>
        /// The price of the combo
        /// Has a dollar discount
        /// </summary>
        public double Price { get { return Entree.Price + Side.Price + Drink.Price - 1; } }

        /// <summary>
        /// The calories in the combo
        /// </summary>
        public uint Calories { get { return Entree.Calories + Side.Calories + Drink.Calories; } }

		/// <summary>
		/// The description of the Aretino Apple Juice
		/// </summary>
		public string Description { get; } = "A combo platter containing an Entree, Side, and Drink.";

		/// <summary>
		/// Special instructions for all items in the combo
		/// DisplayName of items seperates each items specific instructions
		/// </summary>
		public List<string> SpecialInstructions { 
            get
            {
                List<string> temp = new List<string>();
                temp.Add(Entree.ToString());
                temp.AddRange(Entree.SpecialInstructions);

                temp.Add(Side.ToString());
                temp.AddRange(Side.SpecialInstructions);
                
                temp.Add(Drink.ToString());
                temp.AddRange(Drink.SpecialInstructions);

                return temp;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ItemPropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
			switch (e.PropertyName)
			{
                case "Price":
                    OnPropertyChanged("Price");
                    break;
                case "Calories":
                    OnPropertyChanged("Calories");
                    break;
                case "Size":
                case "Flavor":
                case "SpecialInstructions":
                    OnPropertyChanged("SpecialInstructions");
                    break;
				default:
                    // we can safely ignore it otherwise.
					break;
			}
		}
    }
}
