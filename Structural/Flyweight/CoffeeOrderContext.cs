namespace Flyweight {

	public class CoffeeOrderContext {

		public int Table {
			get;
			private set;
		}

		public CoffeeOrderContext(int tableNumber) {
			this.Table = tableNumber;
		}

	}
}