using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Bindings;
using Core;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            int testThreads = 3;
            int instances = 2;
            Parallel.For(1, testThreads + 1, (thread) =>
               {
                   var scenario = Kernel.Instance.Get<Scenario>();
                   Parallel.For(1, instances + 1, (int i) =>
                   {
                       var instance = scenario.Provider.Create(i);

                       // cache test
                       Assert.AreSame(instance, scenario.Provider.Create(i));

                       instance.Context[i.ToString()] = i.ToString();
                       var scenarioId = instance.Resolver.GetScenarioId();
                       var context = instance.Resolver.ReadContext(i.ToString());

                       Console.WriteLine($"instance[{instance.Id}]: scenarioId={scenarioId}, context={context}");
                   });
               });
            Console.ReadKey();
        }
    }
}
