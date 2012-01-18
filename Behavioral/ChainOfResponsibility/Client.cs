using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility {

	class Client {

		static void Main(string[] args) {
			Handler handlerChain = new ConcreteHandler1(new ConcreteHandler2(null));

			Request request1 = new ConcreteRequest1();
			handlerChain.HandleRequest(request1);

			Request request2 = new ConcreteRequest2();
			handlerChain.HandleRequest(request2);

			Console.ReadKey();
		}
	}

}
