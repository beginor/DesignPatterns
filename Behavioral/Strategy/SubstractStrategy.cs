namespace Strategy {

	public class SubstractStrategy : IStrategy {
		
		public int Execute(int a, int b) {
			return a - b;
		}
	}
}