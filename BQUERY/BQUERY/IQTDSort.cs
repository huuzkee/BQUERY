using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTDSort
    {
        bool canSort { get; }

        IQuery SetSortExpression( string SortExpression );

        IQuery Sort();
    }
}
