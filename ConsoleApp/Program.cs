using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Bindings;
using Core;
using System.Threading;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            var container = new CoreModule();
            var kernel = new StandardKernel(container);
            Parallel.For(1, n + 1, (int i) =>
               {
                   var scenario = kernel.Get<Scenario>();
                   var instance = scenario.Provider.Create(i);
                   scenario.Provider.Create(i);
                   instance.Context[i.ToString()] = i;
                   var scenarioId = instance.Resolver.GetScenarioId();
                   var context = instance.Resolver.ReadContext(i.ToString());

                   Console.WriteLine($"instance[{instance.Id}]: scenarioId={scenarioId}, context={context}");
               }
            );
            Console.ReadKey();
        }
    }
}
