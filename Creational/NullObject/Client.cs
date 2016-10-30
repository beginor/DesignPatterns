using System;

public class NullPatternDemo {
	
	static void Main(string[] args) {
		
		AbstractCustomer c1 = BookFactory.GetBook("Book1");
		AbstractCustomer c2 = BookFactory.GetBook("Book5");
		AbstractCustomer c3 = BookFactory.GetBook("Book2");
		AbstractCustomer c4 = BookFactory.GetBook("Book3");
		AbstractCustomer c5 = BookFactory.GetBook("Book9");
		
		Console.WriteLine(c1.GetTitle());
		Console.WriteLine(c2.GetTitle());
		Console.WriteLine(c3.GetTitle());
		Console.WriteLine(c4.GetTitle());
		Console.WriteLine(c5.GetTitle());
	}
	
}