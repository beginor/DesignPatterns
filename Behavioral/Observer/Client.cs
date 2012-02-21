using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer {

	class Client {
		
		static void Main(string[] args) {
			var subject = new ConcreteSubject();

			subject.Attach(new ConcreteObserver(subject));
			subject.Attach(new ConcreteObserver(subject));

			subject.State = "State1";
			subject.Notify();

			subject.State = "State2";
			subject.Notify();

			Console.ReadKey();
		}
	}
}
