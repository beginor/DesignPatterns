namespace Builder {

	public class Pizza {

		private string _dough = string.Empty;
		private string _sauce = string.Empty;
		private string _topping = string.Empty;

		public string Dough {
			get {
				return this._dough;
			}
			set {
				this._dough = value;
			}
		}

		public string Sauce {
			get {
				return this._sauce;
			}
			set {
				this._sauce = value;
			}
		}

		public string Topping {
			get {
				return this._topping;
			}
			set {
				this._topping = value;
			}
		}
	}
}