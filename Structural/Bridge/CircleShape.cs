namespace Bridge {
	
	class CircleShape : Shape {

		private readonly double _x;
		private readonly double _y;
		private double _radius;

		public CircleShape(double x, double y, double radius, IDrawingApi drawingApi)
			: base(drawingApi) {
			this._x = x;
			this._y = y;
			this._radius = radius;
		}

		public override void Draw() {
			this.DrawingApi.DrawCircle(this._x, this._y, this._radius);
		}

		public override void ResizeByPercent(double percent) {
			this._radius *= percent;
		}

	}
}