using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace Website.Pages
{
	public class IndexModel : PageModel
	{
		/// <summary>
		/// The list of OrderItems to display based of the search terms and filters
		/// </summary>
		public IEnumerable<IOrderItem> OrderItems { get; set; }
		public string SearchTerms { get; set; }
		/// <summary>
		/// The filtered categories (Entree, Side or Drink)
		/// </summary>
		public string[] Categories { get; set; }

		public int? CalMin { get; set; }
		public int? CalMax { get; set; }
		public double? PriceMin { get; set; }
		public double? PriceMax { get; set; }

		public void OnGet(string SearchTerms, string[] Categories, int? CalMin, int? CalMax, double? PriceMin, double? PriceMax)
		{
			this.SearchTerms = SearchTerms;
			this.Categories = Categories;
			this.CalMin = CalMin;
			this.CalMax = CalMax;
			this.PriceMin = PriceMin;
			this.PriceMax = PriceMax;

			/*OrderItems = Menu.Search(Menu.FullMenu(), SearchTerms);
			OrderItems = Menu.FilterByCategory(OrderItems, Categories);
			OrderItems = Menu.FilterByCalories(OrderItems, CalMin, CalMax);
			OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);*/
			OrderItems = Menu.FullMenu();
			if (SearchTerms != null && SearchTerms.Length != 0)
			{
				OrderItems = OrderItems.Where(item => DoesItemHaveSearchTerms(item));
			}
			if (Categories != null && Categories.Length != 0)
			{
				OrderItems = OrderItems.Where(item => IsItemOfCategory(item));
			}

			if (CalMin != null)
			{
				OrderItems = OrderItems.Where(item => item.Calories >= CalMin);
			}
			if (CalMax != null)
			{
				OrderItems = OrderItems.Where(item => item.Calories <= CalMax);
			}
			if (PriceMin != null)
			{
				OrderItems = OrderItems.Where(item => item.Price >= PriceMin);
			}
			if (PriceMax != null)
			{
				OrderItems = OrderItems.Where(item => item.Price <= PriceMax);
			}
		}

		private bool DoesItemHaveSearchTerms(IOrderItem item)
		{
			string[] terms = SearchTerms.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string itemString = item.DisplayName + " " + item.Description;
			foreach (string term in terms)
			{
				if ( ! itemString.Contains(term, StringComparison.InvariantCultureIgnoreCase))
				{
					return false;
				}
			}
			return true;
		}

		private bool IsItemOfCategory(IOrderItem item)
		{
			if (item is Entree)
			{
				return Categories.Contains("Entrees");
			}
			else if (item is Side)
			{
				return Categories.Contains("Sides");
			}
			else if (item is Drink)
			{
				return Categories.Contains("Drinks");
			}
			throw new NotImplementedException($"IOrderItem {item.DisplayName} is of an unimplemented category");
		}
	}
}
