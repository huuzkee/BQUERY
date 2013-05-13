using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTDFilter
    {
        bool canFilter { get; }

        IQuery Filter();

        IQuery SetFilter();
        
    }
}