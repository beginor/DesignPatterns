using System.Windows;
using System.Windows.Controls;

namespace Mediator {

	public class DisplayLabel : Label {

		private readonly IMediator _mediator;

		public DisplayLabel(IMediator mediator) {
			this.Content = "Starting ...";
			this.FontSize = 24;
			//this.FontWeight = new FontWeight();
			this._mediator = mediator;
			this._mediator.RegisterDisplay(this);
		}
	}
}