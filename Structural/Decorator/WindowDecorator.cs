namespace Decorator {

	class WindowDecorator : IWindow {
		
		protected IWindow DecoratedWindow;

		public WindowDecorator(IWindow decoratedWindow) {
			this.DecoratedWindow = decoratedWindow;
		}

		public virtual void Draw() {
			this.DecoratedWindow.Draw();
		}

		public virtual string GetDescription() {
			return "Window decorator";
		}

	}
}