using System.Collections.Generic;

namespace Observer {

	public class ConcreteSubject : ISubject {

		private readonly IList<IObserver> _observers = new List<IObserver>();

		public string State {
			get;
			set;
		}

		public void Attach(IObserver observer) {
			if (!this._observers.Contains(observer)) {
				this._observers.Add(observer);
			}
		}

		public void Detach(IObserver observer) {
			if (this._observers.Contains(observer)) {
				this._observers.Remove(observer);
			}
		}

		public void Notify() {
			foreach (var observer in _observers) {
				observer.Update();
			}
		}
	}
}