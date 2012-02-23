using System;

namespace Strategy {

	class Client {

		static void Main(string[] args) {

			Context context;

			// Three contexts following different strategies
			context = new Context(new AddStrategy());
			var resultA = context.ExecuteStrategy(3, 4);
			Console.WriteLine(resultA);

			context = new Context(new SubstractStrategy());
			var resultB = context.ExecuteStrategy(3, 4);
			Console.WriteLine(resultB);

			context = new Context(new MultiplyStrategy());
			var resultC = context.ExecuteStrategy(3, 4);
			Console.WriteLine(resultC);

			Console.ReadKey();
		}
	}
}
