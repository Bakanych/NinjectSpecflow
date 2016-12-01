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
    public class Steps1
    {
        InstanceProvider provider;
        Core.ScenarioContext context;
        public Steps1(InstanceProvider provider, Core.ScenarioContext context)
        {
            this.provider = provider;
            this.context = context;
        }

        [Given("I switch to (.+)")]
        public void SwitchInstance(int id)
        {
            context.Keys.Add(provider.Get(id).Id);
        }
    }
}
