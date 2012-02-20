using System.Windows.Controls;

namespace Mediator {

	public class SearchButton : Button, IColleague {

		private readonly IMediator _mediator;

		public SearchButton(IMediator mediator) {
			this.Content = "Search";
			this._mediator = mediator;
			this._mediator.RegisterSearch(this);
		}

		public void Execute() {
			this._mediator.Search();
		}
	}
}