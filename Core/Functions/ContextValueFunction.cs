using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Functions
{
    public class ContextValueFunction : IFunction
    {
        ContextCollection<string> instanceContext;
        public ContextValueFunction(ContextCollection<string> context)
        {
            this.instanceContext = context;
        }

        public string Evaluate(IList<object> args)
        {
            return instanceContext[(string)args[0]].ToString();
        }
    }
}
