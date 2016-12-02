using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Functions
{
    public class ScenarioIdFunction : IFunction
    {
        ScenarioContext context;
        public ScenarioIdFunction(ScenarioContext context)
        {
            this.context = context;
        }
        
        public string Evaluate(IList<object> args)
        {
            return context.Id.ToString();
        }
    }
}
