using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Instance
    {
        public int Id { get; private set; }
        public Resolver Resolver { get; private set; }
        public ContextCollection<int> Context { get; set; }
        public Instance(Resolver resolver, ContextCollection<int> context, int id)
        {
            this.Id = id;
            this.Resolver = resolver;
            this.Context = context;
        }
    }
}
