using Core;
using Core.Functions;
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

        public string ReadContext(string key)
        {
            var args = new List<object>() { key };
            return root.Get<ContextValueFunction>().Evaluate(args);
        }

        public string GetScenarioId()
        {
            return root.Get<ScenarioIdFunction>().Evaluate(null);
        }
    }
}
