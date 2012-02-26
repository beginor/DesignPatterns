using System;
using System.Configuration;

namespace AbstractFactory {

	public class ApplicationRunner {

		static IGuiFactory CreateOsSpecificFactory() {
			var sysType = ConfigurationManager.AppSettings["OS_TYPE"] ?? "Win";
			if (sysType == "Win") {
				return new WinFactory();
			}
			return new OsxFactory();
		}

		static void Main(string[] args) {
			new Application(CreateOsSpecificFactory());
			Console.ReadKey();
		}

	}

}