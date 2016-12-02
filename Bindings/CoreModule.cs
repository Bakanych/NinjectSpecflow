using Core;
using Ninject.Extensions.Factory;
using Ninject.Extensions.NamedScope;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class CoreModule : NinjectModule
    {
        // load ContextPreservationModule into Kernel
        Ninject.Extensions.ContextPreservation.ContextPreservationModule contextPreservationModule;

        // load Factory extension module into Kernel
        Ninject.Extensions.Factory.IInstanceProvider instanceProvider;
        public override void Load()
        {
            //Bind<InstanceProvider>().ToSelf().InSingletonScope();

            Bind<Scenario>().ToSelf().DefinesNamedScope("scenario");
            Bind<ScenarioContext>().ToSelf().InNamedScope("scenario");
            Bind<InstanceProvider>().ToSelf().InNamedScope("scenario");

            Bind<Instance>().ToSelf().DefinesNamedScope("instance");
            Bind(typeof(ContextCollection<>)).ToSelf().InNamedScope("instance");
            Bind<Resolver>().ToSelf().InNamedScope("instance");
        }
    }
}
