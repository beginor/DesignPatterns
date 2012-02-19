namespace Iterator {

	public class ConcreteIterator : IIterator {
		
		private readonly object[] _aggregateItems;
		private int _index;

		public ConcreteIterator(object[] aggregateItems) {
			this._aggregateItems = aggregateItems;
			this._index = 0;
		}

		public object CurrentItem() {
			return this._aggregateItems[this._index];
		}

		public void First() {
			this._index = 0;
		}

		public bool IsDone() {
			return this._index == this._aggregateItems.Length;
		}

		public void Next() {
			this._index += 1;
		}
	}
}