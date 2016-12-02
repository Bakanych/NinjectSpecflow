using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Functions
{
    public interface IFunction
    {
        string Evaluate(IList<object> args);
    }
}
