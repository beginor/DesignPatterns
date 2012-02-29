using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge {

	class Program {

		static void Main(string[] args) {
			
			var shapes = new Shape[] {
				new CircleShape(1, 2, 3, new DrawingApi1()),
				new CircleShape(5, 7, 11, new DrawingApi2()),
			};
			
			foreach (var shape in shapes) {
				shape.ResizeByPercent(2.5);
				shape.Draw();
			}

			Console.ReadKey();
		}
	}
}
