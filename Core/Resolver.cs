using Core;
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
        ContextCollection<int> instanceContext;
        IResolutionRoot root;
        public Resolver(ContextCollection<int> ic, IResolutionRoot root)
        {
            this.instanceContext = ic;
            this.root = root;
        }

        public int ReadContext(string key)
        {
            return instanceContext[key];
        }

        public int GetScenarioId()
        {
            return root.Get<ScenarioId>().Calculate();
        }
    }
}
