using System;

namespace Flyweight {

	public class CoffeeFlavor : ICoffeeOrder {

		public string Flavor {
			get;
			private set;
		}

		public CoffeeFlavor(string newFlavor) {
			this.Flavor = newFlavor;
		}

		public void ServeCoffee(CoffeeOrderContext context) {
			Console.WriteLine("Serving coffee flavor {0} to table {1} .", this.Flavor, context.Table);
		}

	}
}