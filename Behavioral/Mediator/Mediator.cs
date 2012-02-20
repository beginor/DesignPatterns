namespace Mediator {

	class Mediator : IMediator {

		private ViewButton _viewButton;
		private SearchButton _searchButton;
		private BookButton _bookButton;
		private DisplayLabel _displayLabel;
		
		public void Book() {
			this._bookButton.IsEnabled = false;
			this._viewButton.IsEnabled = true;
			this._searchButton.IsEnabled = true;
			this._displayLabel.Content = "Booking ...";
		}

		public void View() {
			this._bookButton.IsEnabled = true;
			this._viewButton.IsEnabled = false;
			this._searchButton.IsEnabled = true;
			this._displayLabel.Content = "Viewing ...";
		}

		public void Search() {
			this._bookButton.IsEnabled = true;
			this._viewButton.IsEnabled = true;
			this._searchButton.IsEnabled = false;
			this._displayLabel.Content = "Searching ...";
		}

		public void RegisterView(ViewButton viewButton) {
			this._viewButton = viewButton;
		}

		public void RegisterSearch(SearchButton searchButton) {
			this._searchButton = searchButton;
		}

		public void RegisterBook(BookButton bookButton) {
			this._bookButton = bookButton;
		}

		public void RegisterDisplay(DisplayLabel displayLabel) {
			this._displayLabel = displayLabel;
		}
	}
}