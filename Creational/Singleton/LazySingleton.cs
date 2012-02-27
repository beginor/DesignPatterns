using System;

namespace Singleton {

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
}