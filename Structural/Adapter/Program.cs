using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter {

	interface ITarget {

		void Request();

	}

	class Adapter : ITarget {

		private readonly Adaptee _adaptee;

		public Adapter(Adaptee adaptee) {
			this._adaptee = adaptee;
		}
		
		void ITarget.Request() {
			this._adaptee.PerformRequest();
		}
	}

	class Adaptee {
		
		public void PerformRequest() {
			Console.WriteLine("Addaptee perform request.");
		}

	}

	class Program {

		static void Main(string[] args) {
			ITarget target = new Adapter(new Adaptee());
			target.Request();

			Console.ReadLine();
		}
	}
}
