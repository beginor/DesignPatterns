using System;

namespace Visitor {

	class CarElementDoVisitor : ICarElementVisitor {

		public void Visit(Wheel wheel) {
			Console.WriteLine("kicking my {0} wheel", wheel.Name);
		}

		public void Visit(Engine engine) {
			Console.WriteLine("starting my engine");
		}

		public void Visit(Body body) {
			Console.WriteLine("moving my body");
		}

		public void Visit(Car car) {
			Console.WriteLine("starting my car");
		}
	}

}