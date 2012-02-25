using System;

namespace TemplateMethod {
	
	public class Monopoly : Game {
		
		public override void InitializeGame() {
			Console.WriteLine("Initialize players");
			Console.WriteLine("Initialize money");
		}

		protected override void MakePlay(int player) {
			Console.WriteLine("Process one turn of player");
		}

		protected override bool EndOfGame() {
			Console.WriteLine("Return true if game is over, according to Monopoly rules.");
			return true;
		}

		protected override void PrintWinner() {
			Console.WriteLine("Whow won ?");
		}

	}
}