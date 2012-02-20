using System.Windows.Controls;

namespace Mediator {

	public class ViewButton : Button, IColleague {

		private readonly IMediator _mediator;

		public ViewButton(IMediator mediator) {
			this.Content = "View";
			this._mediator = mediator;
			this._mediator.RegisterView(this);
		}

		public void Execute() {
			this._mediator.View();
		}
	}
}