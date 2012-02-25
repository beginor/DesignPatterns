using System;

namespace TemplateMethod {

	public abstract class Game {

		protected int PlayerCount;

		public abstract void InitializeGame();

		protected abstract void MakePlay(int player);

		protected abstract bool EndOfGame();

		protected abstract void PrintWinner();

		public void PlayOneGame(int playerCount) {
			this.PlayerCount = playerCount;

			this.InitializeGame();

			var j = 0;
			while (!this.EndOfGame()) {
				this.MakePlay(j);
				j = (j + 1) % this.PlayerCount;
			}
			this.PrintWinner();
		}

	}

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

	public class Chess : Game {
		
		public override void InitializeGame() {
			throw new NotImplementedException();
		}

		protected override void MakePlay(int player) {
			throw new NotImplementedException();
		}

		protected override bool EndOfGame() {
			throw new NotImplementedException();
		}

		protected override void PrintWinner() {
			throw new NotImplementedException();
		}

	}

}