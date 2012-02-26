namespace Visitor {
	
	class Engine : ICarElement {

		public void Accept(ICarElementVisitor visitor) {
			visitor.Visit(this);
		}

	}

}