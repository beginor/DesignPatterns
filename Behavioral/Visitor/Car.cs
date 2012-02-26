namespace Visitor {
	
	class Car : ICarElement {

		private readonly ICarElement[] _elements;

		public Car() {
			this._elements = new ICarElement[] {
				new Wheel("front left"),
				new Wheel("front right"),
				new Wheel("back left"),
				new Wheel("back right"),
				new Body(),
				new Engine()
			};
		}

		public void Accept(ICarElementVisitor visitor) {
			foreach (var element in this._elements) {
				element.Accept(visitor);
			}
			visitor.Visit(this);
		}
	}

}