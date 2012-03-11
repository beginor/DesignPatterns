namespace Proxy {

	public class ProxyImage : IImage {

		private RealImage _realImage;
		private readonly string _fileName;

		public ProxyImage(string fileName) {
			this._fileName = fileName;
		}

		public void DisplayImage() {
			if (this._realImage == null) {
				this._realImage = new RealImage(this._fileName);
			}
			this._realImage.DisplayImage();
		}
	}
}