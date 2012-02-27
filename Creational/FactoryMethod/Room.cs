namespace FactoryMethod {

	class Room {

		private Room _next;

		public void Connect(Room other) {
			this._next = other;
		}
	}
}