namespace Strategy {

	public class Context {
		
		private readonly IStrategy _strategy;

		public Context(IStrategy strategy) {
			this._strategy = strategy;
		}

		public int ExecuteStrategy(int a, int b) {
			return this._strategy.Execute(a, b);
		}
	}
}