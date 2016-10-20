using System;

class NullBook : AbstractCustomer {
	
	public override string GetTitle() {
		return "Not avaible in Customer Database";
	}
	
}