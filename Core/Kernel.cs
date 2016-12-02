using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
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
                        // Ninject.Extensions.Binding module will be loaded automatically
                        instance = new StandardKernel();
                    }
                    return instance;
                }
            }
        }
    }
}
