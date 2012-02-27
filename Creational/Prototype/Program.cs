using System;

namespace Prototype {

	class Program {

		static void Main(string[] args) {
			Prototype prototype = new PrototypeImpl(1000);

			for (int i = 1; i < 10; i++) {
				var tempotype = (Prototype)prototype.Clone();

				// Usage of values in prototype to derive a new value.
				tempotype.X = tempotype.X * i;
				tempotype.PrintX();
			}

			Console.ReadKey();
		}
	}
}
