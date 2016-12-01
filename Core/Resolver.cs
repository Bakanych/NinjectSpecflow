using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Resolver
    {
        EntityCollection instanceContext;
        IResolutionRoot root;
        public Resolver(EntityCollection ic, IResolutionRoot root)
        {
            this.instanceContext = ic;
            this.root = root;
        }

        public int ReadContext(int key)
        {
            return instanceContext[key];
        }

        public int ReadScenarioId()
        {
            return root.Get<ScenarioId>().Calculate();
        }
    }
}
