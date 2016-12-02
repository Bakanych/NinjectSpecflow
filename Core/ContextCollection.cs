using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ContextCollection<T>
    {
        readonly ConcurrentDictionary<string, T> collection = new ConcurrentDictionary<string, T>();
        public IDictionary<string, T> Collection { get { return collection; } }
        public T this[string key]
        {
            get { return collection[key]; }
            set { collection[key] = value; }
        }
    }
}
