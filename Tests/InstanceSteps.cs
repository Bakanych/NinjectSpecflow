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
    public class InstanceSteps
    {
        InstanceProvider provider;
        Core.ScenarioContext context;
        public InstanceSteps(InstanceProvider provider, Core.ScenarioContext context)
        {
            this.provider = provider;
            this.context = context;
        }

        [Given("I add to context")]
        public void AddToContext(Table table)
        {
            foreach (var row in table.Rows)
            {
                var instance = provider.Get(context.Current);
                instance.Context[int.Parse(row[0])] = int.Parse(row[1]);
            }
        }

    }
}
