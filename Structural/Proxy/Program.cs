using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy {

	class Program {

		static void Main(string[] args) {
			IImage image1 = new ProxyImage("HiRes_10MB_Photo1");
			IImage image2 = new ProxyImage("HiRes_10MB_Photo2");

			image1.DisplayImage();
			image1.DisplayImage();
			image2.DisplayImage();
			image2.DisplayImage();

			Console.ReadKey();
		}

	}

}
