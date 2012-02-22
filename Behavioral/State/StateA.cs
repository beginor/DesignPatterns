using System;

namespace State {

	public class StateA : IState {
		
		public void WriteName(StateContext stateContext, string name) {
			Console.WriteLine(name.ToLower());
			stateContext.SetState(new StateB());
		}
	}
}