namespace Strategy {

	public class MultiplyStrategy : IStrategy {
		
		public int Execute(int a, int b) {
			return a * b;
		}
	}
}