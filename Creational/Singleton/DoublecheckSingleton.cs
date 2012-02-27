using System;

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
}