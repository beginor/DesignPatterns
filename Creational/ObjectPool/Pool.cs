using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectPool {

    public static class Pool {

        private static readonly IList<PooledObject> InUsed = new List<PooledObject>();
        private static readonly IList<PooledObject> Available = new List<PooledObject>();

        public static PooledObject GetObject() {
            lock (Available) {
                PooledObject obj;
                if (Available.Count == 0) {
                    obj = new PooledObject();
                    InUsed.Add(obj);
                    return obj;
                }
                obj = Available[0];
                InUsed.Add(obj);
                Available.RemoveAt(0);
                return obj;
            }
        }

        public static void ReleaseObject(PooledObject obj) {
            CleanUp(obj);
            lock (Available) {
                InUsed.Remove(obj);
                Available.Add(obj);
            }
        }

        public static void CleanUp(PooledObject obj) {
            obj.TempData = null;
        }
    }

}
