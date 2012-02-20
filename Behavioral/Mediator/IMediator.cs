using System.Windows.Controls;

namespace Mediator {

	/// <summary>
	/// Mediator interface
	/// </summary>
	public interface IMediator {

		void Book();

		void View();

		void Search();

		void RegisterView(ViewButton viewButton);

		void RegisterSearch(SearchButton searchButton);

		void RegisterBook(BookButton bookButton);

		void RegisterDisplay(DisplayLabel displayLabel);

	}
}