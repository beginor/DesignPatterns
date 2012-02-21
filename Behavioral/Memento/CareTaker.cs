using System;
using System.Collections.Generic;

namespace Memento {
	
	class CareTaker {

		static void Main(string[] args) {
			IList<Originator.Momento> savedStates = new List<Originator.Momento>();

			var originator = new Originator();
			originator.SetState("State1");
			originator.SetState("State2");
			savedStates.Add(originator.SaveToMomento());
			originator.SetState("State3");
			savedStates.Add(originator.SaveToMomento());
			originator.SetState("State4");
			originator.RestoreFromMomento(savedStates[0]);

			Console.ReadKey();
		}
	}
}
