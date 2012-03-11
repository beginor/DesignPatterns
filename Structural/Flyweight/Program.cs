using System;

namespace Flyweight {

	class Program {

		private static readonly CoffeeFlavor[] Flavors = new CoffeeFlavor[100];
		private static readonly CoffeeOrderContext[] Tables = new CoffeeOrderContext[100];

		private static int _ordersMade;
		private static CoffeeFlavorFactory _factory;

		private static void TakeOrder(string flaver, int table) {
			Flavors[_ordersMade] = _factory.GetCoffeeFlavor(flaver);
			Tables[_ordersMade++] = new CoffeeOrderContext(table);
		}

		static void Main(string[] args) {
			_factory = new CoffeeFlavorFactory();

			TakeOrder("Cappuccino", 2);
			TakeOrder("Cappuccino", 2);
			TakeOrder("Frappe", 1);
			TakeOrder("Frappe", 1);
			TakeOrder("Xpresso", 1);
			TakeOrder("Frappe", 897);
			TakeOrder("Cappuccino", 97);
			TakeOrder("Cappuccino", 97);
			TakeOrder("Frappe", 3);
			TakeOrder("Xpresso", 3);
			TakeOrder("Cappuccino", 3);
			TakeOrder("Xpresso", 96);
			TakeOrder("Frappe", 552);
			TakeOrder("Cappuccino", 121);
			TakeOrder("Xpresso", 121);

			for (int i = 0; i < _ordersMade; i++) {
				Flavors[i].ServeCoffee(Tables[i]);
			}

			Console.WriteLine();
			Console.WriteLine("Total CoffeeFlavor objects made {0}", _factory.TotalFlaversMade);
			Console.ReadKey();
		}
	}
}
