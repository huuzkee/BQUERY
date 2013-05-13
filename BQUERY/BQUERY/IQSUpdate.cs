using System;
using System.Linq;

namespace BQUERY
{
    public interface IQSUpdate
    {
        bool canUpdate { get; }

        bool ClearUpdateFlags();

        IQuery Update();
    }
}