using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod {
	
	class Client {
		
		static void Main(string[] args) {
			Game monopolyGame = new Monopoly();
			monopolyGame.PlayOneGame(4);

			Console.ReadKey();
		}
	}
}
