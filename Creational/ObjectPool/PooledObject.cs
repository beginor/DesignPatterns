using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectPool {

    public class PooledObject {

        public DateTime CreatedAt { get; } = DateTime.Now;

        public string TempData { get; set; }

    }

}
