namespace AbstractFactory {
	
	public class OsxFactory : IGuiFactory {

		IButton IGuiFactory.CreateButton() {
			return new OsxButton();
		}

	}
}