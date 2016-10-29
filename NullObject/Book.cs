using System;

public class Book : AbstractCustomer {
	
	public Book (String title) {
		this.title = title;
	}
	
	public override string GetTitle() {
		return title;
	}
}