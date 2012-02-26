namespace Visitor {
	
	interface ICarElement {

		void Accept(ICarElementVisitor visitor);

	}

}