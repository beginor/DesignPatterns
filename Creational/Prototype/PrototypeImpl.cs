using System;

namespace Prototype {

	class PrototypeImpl : Prototype {

		private int _x;

		public override int X {
			get {
				return this._x;
			}
			set {
				this._x = value;
			}
		}

		public PrototypeImpl(int x) {
			this._x = x;
		}

		public override void PrintX() {
			Console.WriteLine("value : {0}", this.X);
		}

		public override object Clone() {
			return new PrototypeImpl(this._x);
		}
	}
}