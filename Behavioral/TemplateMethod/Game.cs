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
}