using System;

namespace Iterator {
	
	class Client {

		static void Main(string[] args) {
			IAggregate aggregate = new ConcreateAggregate("Item1", "Item2", "Item3", "Item4");
			IIterator iterator = aggregate.CreateIterator();

			if (iterator.IsDone()) {
				iterator.First();
			}
			while (!iterator.IsDone()) {
				Console.WriteLine(iterator.CurrentItem());
				iterator.Next();
			}

			Console.ReadKey();
		}
	}

}
