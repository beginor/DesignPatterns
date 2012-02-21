using System;

namespace Observer {
	
	public class ConcreteObserver : IObserver {
		
		private readonly ConcreteSubject _subject;

		public ConcreteObserver(ConcreteSubject subject) {
			this._subject = subject;
		}

		public void Update() {
			Console.WriteLine("Observer: subject state updated to {0} .", this._subject.State);
		}
	}
}