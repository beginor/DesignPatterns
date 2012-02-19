namespace Iterator {

	public class ConcreateAggregate : IAggregate {

		private readonly object[] _items;

		public ConcreateAggregate(params object[] items) {
			if (items != null) {
				this._items = new object[items.Length];
				for (var i = 0; i < items.Length; i++) {
					this._items[i] = items[i];
				}
			}
		}
		
		public IIterator CreateIterator() {
			return new ConcreteIterator(this._items);
		}

	}

}