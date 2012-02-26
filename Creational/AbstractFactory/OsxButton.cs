using System;

namespace AbstractFactory {

	public class OsxButton : IButton {

		public void Paint() {
			Console.WriteLine("I'm an OSXButton");
		}

	}
}