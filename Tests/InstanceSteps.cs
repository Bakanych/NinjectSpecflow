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
                var instance = provider.Create(context.Current);
                instance.Context[row[0]] = int.Parse(row[1]);
            }
        }

        [Given(@"I copy from (\w+) to (\w+)")]
        public void Copy(string from, string to)
        {
            var instance = provider.Create(context.Current);
            instance.Context[to] = instance.Resolver.ReadContext(from);
        }
    }
}
