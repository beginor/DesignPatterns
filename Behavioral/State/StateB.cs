using System;

namespace State {

	public class StateB : IState {

		private int _count;

		public void WriteName(StateContext stateContext, string name) {
			Console.WriteLine(name.ToUpper());
			if (++this._count > 1) {
				stateContext.SetState(new StateA());
			}
		}
	}
}