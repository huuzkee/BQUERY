using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQImplementation : IQImplementationAccess
    {
        bool supportsImplementation { get; }


    }
}
