using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ScenarioId
    {
        ScenarioContext context;
        public ScenarioId(IResolutionRoot root, ScenarioContext context)
        {
            this.context = context;
        }
        public int Calculate()
        {
            return context.Id;
        }
    }
}
