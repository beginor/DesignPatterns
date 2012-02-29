using System;

namespace Composite {
	
	class Program {

		static void Main(string[] args) {
			var ellipse1 = new Ellipse();
			var ellipse2 = new Ellipse();
			var ellipse3 = new Ellipse();
			var ellipse4 = new Ellipse();

			var graphic = new CompositeGraphic();
			var graphic1 = new CompositeGraphic();
			var graphic2 = new CompositeGraphic();

			graphic1.Add(ellipse1);
			graphic1.Add(ellipse2);
			graphic1.Add(ellipse3);
						
			graphic2.Add(ellipse4);

			graphic.Add(graphic1);
			graphic.Add(graphic2);

			graphic.Print();

			Console.ReadKey();
		}
	}
}
