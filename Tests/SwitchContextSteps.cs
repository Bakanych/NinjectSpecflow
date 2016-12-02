using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class SwitchContextSteps
    {
        InstanceProvider provider;
        Core.ScenarioContext context;
        public SwitchContextSteps(InstanceProvider provider, Core.ScenarioContext context)
        {
            this.provider = provider;
            this.context = context;
        }

        [Given(@"I switch to (\d+)")]
        public void SwitchInstance(int id)
        {
            context.Keys.Add(provider.Create(id).Id);
        }
    }
}
