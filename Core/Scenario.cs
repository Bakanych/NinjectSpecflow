using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public class Scenario
    {

        public InstanceProvider Provider { get; private set; }
        public ScenarioContext Context { get; private set; }
        public IResolutionRoot ResolutionRoot { get; private set; }

        public Scenario(ScenarioContext context, InstanceProvider provider, IResolutionRoot resolutionRoot)
        {
            Context = context;
            Provider = provider;
            ResolutionRoot = resolutionRoot;
        }
    }
}
