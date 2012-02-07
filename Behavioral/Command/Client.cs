using System;

namespace Command {

	class Client {
		
		static void Main(string[] args) {

			var invoker = new Invoker();

			var receiver = new Receiver();
			ICommand command = new ConcreteCommand(receiver);
			
			invoker.InvokeCommand(command);

			Console.ReadKey();
		}
	}
}
