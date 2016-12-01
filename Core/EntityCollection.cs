using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class EntityCollection
    {
        readonly ConcurrentDictionary<int, int> collection = new ConcurrentDictionary<int, int>();
        public ConcurrentDictionary<int, int> Collection { get { return collection; } }
        public int this[int key]
        {
            get { return collection[key]; }
            set { collection[key] = value; }
        }
    }
}
