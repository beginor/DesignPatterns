using System;
using System.Threading.Tasks;

namespace Singleton {

	public class DoublecheckSingleton {

		private volatile static DoublecheckSingleton _instance;

		private DoublecheckSingleton() {
		}

		public static DoublecheckSingleton Instance {
			get {
				if (_instance == null) {
					lock (typeof(DoublecheckSingleton)) {
						if (_instance == null) {
							Console.WriteLine("Initialize a double check singleton.");
							_instance = new DoublecheckSingleton();
						}
					}
				}
				return _instance;
			}
		}
	}

	public class LazySingleton {

		private static readonly Lazy<LazySingleton> LazyInstance = new Lazy<LazySingleton>(() => {
			Console.WriteLine("Initialize a lazy singleton.");
			return new LazySingleton();
		});

		private LazySingleton() {
		}

		public static LazySingleton Instance {
			get {
				return LazyInstance.Value;
			}
		}
	}

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
