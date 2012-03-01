using System;

namespace Decorator {

	class Program {
		
		static void Main(string[] args) {
			IWindow window = new HorizontalScrollbarWindow(new VerticalScrollbarWindow(new SimpleWindow()));
			Console.WriteLine(window.GetDescription());

			Console.ReadKey();
		}
	}
}
