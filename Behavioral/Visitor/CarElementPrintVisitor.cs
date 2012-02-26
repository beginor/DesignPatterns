using System;

namespace Visitor {
	
	class CarElementPrintVisitor : ICarElementVisitor {
		
		public void Visit(Wheel wheel) {
			Console.WriteLine("visiting {0} wheel", wheel.Name);
		}

		public void Visit(Engine engine) {
			Console.WriteLine("visiting engine");
		}

		public void Visit(Body body) {
			Console.WriteLine("visiting body");
		}

		public void Visit(Car car) {
			Console.WriteLine("visitig car");
		}

	}

}