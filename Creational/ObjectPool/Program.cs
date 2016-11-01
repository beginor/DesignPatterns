using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectPool {

    class Program {

        public static void Main(string[] args) {
            var po01 = Pool.GetObject();
            po01.TempData = DateTime.Now.ToString("s");
            var po02 = Pool.GetObject();
            po02.TempData = Guid.NewGuid().ToString("N");
            Thread.Sleep(100);
            Pool.ReleaseObject(po01);
            Pool.ReleaseObject(po02);
            Console.ReadLine();
        }

    }

}
