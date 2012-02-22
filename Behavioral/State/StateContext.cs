namespace State {

	public class StateContext {
		
		private IState _state;

		public StateContext() {
			this._state = new StateA();
		}

		public void SetState(IState state) {
			this._state = state;
		}

		public void WriteName(string name) {
			this._state.WriteName(this, name);
		}
	}
}