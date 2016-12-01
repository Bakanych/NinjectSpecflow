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
                   var instance = scenario.Provider.Get(i);
                   scenario.Provider.Get(i);
                   instance.Context[i] = i;
                   var scenarioId = instance.Resolver.ReadScenarioId();
                   var context = instance.Resolver.ReadContext(i);

                   Console.WriteLine($"instance[{instance.Id}]: scenarioId={scenarioId}, context={context}");
               }
            );
            Console.ReadKey();
        }
    }
}
