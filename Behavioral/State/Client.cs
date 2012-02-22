using System;

namespace State {

	class Client {

		static void Main(string[] args) {
			var sc = new StateContext();
			sc.WriteName("Monday");
			sc.WriteName("Tuesday");
			sc.WriteName("Wednesday");
			sc.WriteName("Thursday");
			sc.WriteName("Saturday");
			sc.WriteName("Sunday");

			Console.ReadKey();
		}
	}
}
