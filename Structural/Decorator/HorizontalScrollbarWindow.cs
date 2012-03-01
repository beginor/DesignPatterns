namespace Decorator {

	class HorizontalScrollbarWindow : WindowDecorator {

		public HorizontalScrollbarWindow(IWindow decoratedWindow) : base(decoratedWindow) {
		}

		public override void Draw() {
			base.Draw();
			this.DrawHorizontalScrollbar();
		}

		private void DrawHorizontalScrollbar() {
			//
		}

		public override string GetDescription() {
			return this.DecoratedWindow.GetDescription() + ", include horizontal scrollbars";
		}

	}
}