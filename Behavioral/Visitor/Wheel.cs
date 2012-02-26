namespace Visitor {

	class Wheel : ICarElement {

		public string Name {
			get;
			private set;
		}

		public Wheel(string name) {
			this.Name = name;
		}

		public void Accept(ICarElementVisitor visitor) {
			visitor.Visit(this);
		}

	}

}