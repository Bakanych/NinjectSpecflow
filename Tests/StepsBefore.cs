using Bindings;
using BoDi;
using Core;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;

namespace Tests
{
    [Binding]
    public class StepsBefore
    {
        readonly IObjectContainer objectContainer;
        readonly ITraceListener tracer;
        InstanceProvider provider;
        Core.ScenarioContext context;
        public StepsBefore(IObjectContainer objectContainer, ITraceListener tracer)
        {
            this.objectContainer = objectContainer;
            this.tracer = tracer;
        }
        [BeforeScenario]
        public void Init()
        {
            var scenario = Kernel.Instance.Get<Scenario>();
            this.provider = scenario.Provider;
            this.context = scenario.Context;
            var instance = scenario.Provider.Get(0);
            context.Keys.Add(instance.Id);

            objectContainer.RegisterInstanceAs(provider);
            objectContainer.RegisterInstanceAs(context);
        }


    }
}
