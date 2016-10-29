using System;

public class BookFactory {
	
	public static string[] books = {"Book1", "Book2", "Book3" };
	
	public static AbstractCustomer GetBook(string title) {
		for(int i = 0; i < books.Length; i++)
			if(books[i] == title)
				return new Book(title);
		return new NullBook();
	}
	
}