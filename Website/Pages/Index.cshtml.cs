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

			OrderItems = Menu.Search(Menu.FullMenu(), SearchTerms);
			OrderItems = Menu.FilterByCategory(OrderItems, Categories);
			OrderItems = Menu.FilterByCalories(OrderItems, CalMin, CalMax);
			OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
		}
	}
}
