using System;

namespace Bridge {

	class DrawingApi1 : IDrawingApi {

		public void DrawCircle(double x, double y, double radius) {
			Console.WriteLine("API1.circle at {0},{1} radius {2}", x, y, radius);
		}

	}
}