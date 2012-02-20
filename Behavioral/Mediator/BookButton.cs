using System.Windows.Controls;

namespace Mediator {

	public class BookButton : Button, IColleague {
		
		private readonly IMediator _mediator;

		public BookButton(IMediator mediator) {
			this.Content = "Book";
			this._mediator = mediator;
			this._mediator.RegisterBook(this);
		}

		public void Execute() {
			this._mediator.Book();
		}
	}
}