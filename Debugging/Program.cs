using System;
using Data.Entrees;

namespace Debugging
{
	class Program
	{
		static void Main(string[] args)
		{
			BriarheartBurger burger = new BriarheartBurger();
			burger.Bun = false;
			foreach (string ingr in burger.SpecialInstructions)
			{
				Console.WriteLine(ingr);
			}
		}
	}
}
