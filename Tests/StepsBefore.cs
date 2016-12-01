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

        public StepsBefore(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }
        [BeforeScenario]
        public void Init()
        {
            var scenario = Kernel.Instance.Get<Scenario>();
            var instance = scenario.Provider.Get(0);
            scenario.Context.Keys.Add(instance.Id);

            objectContainer.RegisterInstanceAs(scenario.Provider);
            objectContainer.RegisterInstanceAs(scenario.Context);
        }


    }
}
