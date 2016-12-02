using Bindings;
using BoDi;
using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class StepsAfter
    {
        InstanceProvider provider;
        Core.ScenarioContext context;
        ITraceListener tracer;
        public StepsAfter(InstanceProvider instanceProvider, Core.ScenarioContext context, ITraceListener tracer)
        {
            provider = instanceProvider;
            this.context = context;
            this.tracer = tracer;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            foreach (var key in context.Keys)
            {
                var instance = provider.Create(key);
                Assert.AreEqual(context.Id.ToString(), instance.Resolver.GetScenarioId());

                tracer.WriteToolOutput($"context of {instance.Id}:");
                tracer.WriteToolOutput($"[scenarioId]={instance.Resolver.GetScenarioId()}");

                foreach (var item in instance.Context.Collection)
                {
                    tracer.WriteToolOutput($"[{item.Key}]={item.Value}");

                }
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // final cleanup logic
        }

    }
}
