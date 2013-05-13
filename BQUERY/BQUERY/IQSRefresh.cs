using System;
using System.Linq;


namespace BQUERY
{
    public interface IQSRefresh
    {
        bool canRefresh { get; }

        bool RefreshResult();
    }
}
