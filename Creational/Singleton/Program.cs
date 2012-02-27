using System;
using System.Threading.Tasks;

namespace Singleton {

	class Program {

		static void Main(string[] args) {

			for (int i = 0; i < 100; i++) {
				Task.Factory.StartNew(() => Console.WriteLine(DoublecheckSingleton.Instance.ToString()));
			}

			for (int i = 0; i < 100; i++) {
				Task.Factory.StartNew(() => Console.WriteLine(LazySingleton.Instance.ToString()));
			}

			Console.ReadKey();
		}
	}
}
