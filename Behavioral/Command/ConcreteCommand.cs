namespace Command {

	public class ConcreteCommand : ICommand {

		private readonly Receiver _receiver;
		private object _state;

		public ConcreteCommand(Receiver receiver) {
			this._receiver = receiver;
		}

		public void Execute() {
			this._receiver.Action();
		}

	}
}