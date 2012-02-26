using System;

namespace AbstractFactory {

	public class WinButton : IButton {

		public void Paint() {
			Console.WriteLine("I'm a WinButton");
		}

	}
}