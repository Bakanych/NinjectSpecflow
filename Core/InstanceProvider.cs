using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    //public interface InstanceProvider
    //{
    //    Instance Create(int id);
    //}
    public class InstanceProvider
    {
        ConcurrentDictionary<int, Instance> instances = new ConcurrentDictionary<int, Instance>();
        IResolutionRoot root;

        public InstanceProvider(IResolutionRoot root)
        {
            this.root = root;
        }
        public Instance Create(int id)
        {
            return instances.GetOrAdd(id, (value) =>
            {
                Console.WriteLine($"Creating instance {id}...");
                //Thread.Sleep(3000);
                return root.Get<Instance>(new ConstructorArgument("id",id));

            });
        }
    }
}
