namespace AbstractFactory {

	public class Application {

		public Application(IGuiFactory factory) {
			var button = factory.CreateButton();
			button.Paint();
		}

	}
}