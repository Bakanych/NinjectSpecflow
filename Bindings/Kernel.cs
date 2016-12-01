using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class Kernel
    {
        static readonly object _lockObject = new object();
        static IKernel instance;

        public static IKernel Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (instance == null)
                    {
                        var container = new CoreModule();
                        instance = new StandardKernel(container);
                    }
                    return instance;
                }
            }
        }
    }
}
