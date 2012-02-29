using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter {
	class Program {

		static void Main(string[] args) {
			ITarget target = new Adapter(new Adaptee());
			target.Request();

			Console.ReadLine();
		}
	}
}
