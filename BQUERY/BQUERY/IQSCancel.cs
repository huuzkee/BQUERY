using System;
using System.Linq;

namespace BQUERY
{
    public interface IQSCancel
    {
        bool canCancel { get; }

        IQuery CancelRequest();
    }
}