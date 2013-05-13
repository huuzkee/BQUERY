using System;
using System.Linq;


namespace BQUERY
{
    public interface IQReportNested
    {
        bool isReportNested { get; }

        IQuery GetNestedChild(string name, out IQuery Child);

        IQuery SetNestedChild(string name, IQuery Child);

        bool HasNestedChild(string childname);

    }
}
