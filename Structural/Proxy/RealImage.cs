using System;

namespace Proxy {

	public class RealImage : IImage {

		private readonly string _fileName;

		public RealImage(string fileName) {
			this._fileName = fileName;
			this.LoadImageFromFile();
		}

		private void LoadImageFromFile() {
			Console.WriteLine("Load image from file {0}", this._fileName);
		}

		public void DisplayImage() {
			Console.WriteLine("Displaying image {0}", this._fileName);
		}

	}
}