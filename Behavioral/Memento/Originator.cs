using System;

namespace Memento {

	public class Originator {

		private string _state;

		public void SetState(string state) {
			Console.WriteLine("Originator: setting momento to {0}", state);
			this._state = state;
		}

		public Momento SaveToMomento() {
			Console.WriteLine("Originator: saving to momento...");
			return new Originator.Momento(this._state);
		}

		public void RestoreFromMomento(Momento momento) {
			this._state = momento.State;
			Console.WriteLine("Originator: resotring from momento {0}", this._state);
		}
		
		public class Momento {

			private readonly string _state;

			internal Momento(string state) {
				this._state = state;
			}

			public string State {
				get {
					return this._state;
				}
			}
		}
	}
}