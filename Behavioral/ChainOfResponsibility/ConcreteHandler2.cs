using System;

namespace ChainOfResponsibility {

	public class ConcreteHandler2 : Handler {

		public ConcreteHandler2(Handler successor) : base(successor) {
		}

		public override void HandleRequest(Request request) {
			if (request is ConcreteRequest2) {
				Console.WriteLine("ConcreteRequest2 is handled by ConcreteHandler2");
			}
			else {
				this.Successor.HandleRequest(request);
			}
		}
	}
}