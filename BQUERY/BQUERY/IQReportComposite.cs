using System;
using System.Linq;


namespace BQUERY
{
    public interface IQReportComposite
    {
        bool supportsReportComposite { get; }

        IQuery GetCompositeChild(string name, out IQuery Child);

        IQuery SetCompositeChild(string name, IQuery Child);

        bool HasCompositeChild(string childname);


    }
}