namespace Decorator {

	class VerticalScrollbarWindow : WindowDecorator {

		public VerticalScrollbarWindow(IWindow decoratedWindow) : base(decoratedWindow) {
		}

		public override void Draw() {
			base.Draw();
			this.DrawVerticalScrollbar();
		}

		private void DrawVerticalScrollbar() {
			//
		}

		public override string GetDescription() {
			return this.DecoratedWindow.GetDescription() + ", include vertical scrollbars";
		}

	}
}