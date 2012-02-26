namespace AbstractFactory {

	public class WinFactory : IGuiFactory {

		IButton IGuiFactory.CreateButton() {
			return new WinButton();
		}

	}
}