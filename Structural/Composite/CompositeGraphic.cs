using System.Collections.Generic;

namespace Composite {

	class CompositeGraphic : IGraphic {

		private readonly IList<IGraphic> _childGraphics = new List<IGraphic>();

		public void Print() {
			foreach (var childGraphic in this._childGraphics) {
				childGraphic.Print();
			}
		}

		public void Add(IGraphic graphic) {
			this._childGraphics.Add(graphic);
		}

		public void Remove(IGraphic graphic) {
			this._childGraphics.Remove(graphic);
		}

	}
}