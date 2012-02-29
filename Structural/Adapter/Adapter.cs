namespace Adapter {

	class Adapter : ITarget {

		private readonly Adaptee _adaptee;

		public Adapter(Adaptee adaptee) {
			this._adaptee = adaptee;
		}
		
		void ITarget.Request() {
			this._adaptee.PerformRequest();
		}
	}
}