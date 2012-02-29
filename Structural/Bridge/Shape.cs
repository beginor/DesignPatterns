namespace Bridge {

	abstract class Shape {

		protected IDrawingApi DrawingApi;

		protected Shape(IDrawingApi drawingApi) {
			this.DrawingApi = drawingApi;
		}

		public abstract void Draw();

		public abstract void ResizeByPercent(double percent);

	}
}