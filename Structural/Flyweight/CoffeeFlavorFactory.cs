using System.Collections.Generic;

namespace Flyweight {

	public class CoffeeFlavorFactory {

		private readonly IDictionary<string, CoffeeFlavor> _flavors = new Dictionary<string, CoffeeFlavor>();

		public CoffeeFlavor GetCoffeeFlavor(string flavorName) {
			CoffeeFlavor flavor;
			if (this._flavors.TryGetValue(flavorName, out flavor)) {
				return flavor;
			}
			flavor = new CoffeeFlavor(flavorName);
			this._flavors.Add(flavorName, flavor);
			return flavor;
		}

		public int TotalFlaversMade {
			get {
				return this._flavors.Count;
			}
		}

	}
}