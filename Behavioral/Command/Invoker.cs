using System.Collections.Generic;

namespace Command {

	public class Invoker {
		
		private readonly IList<ICommand> _commandHistory = new List<ICommand>();

		public void InvokeCommand(ICommand command) {
			command.Execute();
			this._commandHistory.Add(command);
		}
	}
}