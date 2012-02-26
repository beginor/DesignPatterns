using System;

namespace Visitor {

	class Program {

		static void Main(string[] args) {

			var car = new Car();
			car.Accept(new CarElementPrintVisitor());
			car.Accept(new CarElementDoVisitor());

			Console.ReadKey();
		}
	}
}
