using Ninject.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public class ScenarioContext
    {
        public HashSet<int> Keys { get; set; }
        public int Current
        {
            get { return Keys.Last(); }
        }

        public int Id { get; private set; }
        public ScenarioContext()
        {
            var rnd = new Random(this.GetHashCode() ^ Environment.TickCount ^ Thread.CurrentThread.ManagedThreadId);
            Id = rnd.Next(1, 9999);
            Keys = new HashSet<int>();
        }
    }
}
