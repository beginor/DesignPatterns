namespace ChainOfResponsibility {

	public abstract class Handler {

		private readonly Handler _successor;

		protected Handler(Handler successor) {
			this._successor = successor;
		}

		protected Handler Successor {
			get {
				return this._successor;
			}
		}

		public abstract void HandleRequest(Request request);

	}
}