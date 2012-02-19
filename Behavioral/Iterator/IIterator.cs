namespace Iterator {

	public interface IIterator {

		object CurrentItem();

		void First();

		bool IsDone();

		void Next();

	}
}