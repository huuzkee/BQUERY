using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQReportLookup
    {
        bool supportsReportLookup { get; }

        IQuery GetLookupChild(string name, out IQuery Child);

        IQuery SetLookupChild(string name, IQuery Child);

        bool HasLookupChild(long pos);

        bool HasLookupChild(string field);


    }
}
