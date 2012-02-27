using System;

namespace Prototype {

	abstract class Prototype : ICloneable {

		public abstract int X {
			get;
			set;
		}

		public abstract void PrintX();

		public abstract object Clone();

	}
}