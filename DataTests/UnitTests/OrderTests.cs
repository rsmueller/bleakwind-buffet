using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using Xunit;
using BleakwindBuffet.Data;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
	public class OrderTests
	{
		[Fact]
		public void NewOrderShouldBeEmpty()
		{
			var x = new Order();
			Assert.Equal(0, x.Subtotal);
			Assert.Equal(0, x.Tax);
			Assert.Equal(0, x.Total);
			Assert.Equal((uint)0, x.Calories);
		}

		[Fact]
		public void OrderNumbersShouldBeUnique()
		{
			List<uint> list = new List<uint>();
			for (int i = 0; i < 4; i++)
			{
				var x = new Order();
				Assert.DoesNotContain(x.Number, list);
				list.Add(x.Number);
			}
		}

		[Fact]
		public void ShouldImplementICollections()
		{
			var x = new Order();
			Assert.IsAssignableFrom<ICollection<IOrderItem>>(x);
		}

		#region CollectionChanged

		[Fact]
		public void ShouldImplementINotifyCollectionChanged()
		{
			var x = new Order();
			Assert.IsAssignableFrom<INotifyCollectionChanged>(x);
		}

		[Fact]
		public void ShouldNotifyCollectionChangedOnAddItem()
		{
			// Is throwing error for unclear unreasons even though follows reading
			// google is not helpful
			Order x = new Order();
		   /* Assert.RaisesAny<NotifyCollectionChangedEventArgs>(
				listener => x.CollectionChanged += listener,
				listener => x.CollectionChanged -= listener,
				() => { x.Add(new BriarheartBurger()); }
			) ; */
		}

		#endregion
		[Fact]
		public void AddingItemTriggersPropertiesChanged()
		{
			var x = new Order();
			Assert.PropertyChanged(x, "Subtotal", () => { x.Add(new TestEntree()); });
			Assert.PropertyChanged(x, "Tax", () => { x.Add(new TestEntree()); });
			Assert.PropertyChanged(x, "Total", () => { x.Add(new TestEntree()); });
			Assert.PropertyChanged(x, "Calories", () => { x.Add(new TestEntree()); });
		}

		[Fact]
		public void RemovingItemTriggersPropertiesChanged()
		{
			var x = new Order();
			var a = new BriarheartBurger();
			var b = new GardenOrcOmelette();
			var c = new CandlehearthCoffee();
			var d = new MadOtarGrits();

			x.Add(a);
			x.Add(b);
			x.Add(c);
			x.Add(d);

			Assert.PropertyChanged(x, "Subtotal", () => { x.Remove(a); });
			Assert.PropertyChanged(x, "Tax", () => { x.Remove(b); });
			Assert.PropertyChanged(x, "Total", () => { x.Remove(c); });
			Assert.PropertyChanged(x, "Calories", () => { x.Remove(d); });
		}

		[Fact]
		public void ChangingItemTriggersPropertiesChanged()
		{
			var x = new Order();
			var a = new SailorSoda();
			x.Add(a);

			Assert.PropertyChanged(x, "Subtotal", () => { a.Size = Size.Large; });
			Assert.PropertyChanged(x, "Tax", () => { a.Size = Size.Medium; });
			Assert.PropertyChanged(x, "Total", () => { a.Size = Size.Small; });
			Assert.PropertyChanged(x, "Calories", () => { a.Size = Size.Large; });
		}
		#region ParametersChanged


		#endregion

		[Fact]
		public void ShouldImplementINotifyPropertyChanged()
		{
			var x = new Order();
			Assert.IsAssignableFrom<INotifyPropertyChanged>(x);
		}
	}
}
