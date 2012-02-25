using System;

namespace TemplateMethod {
	
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