using System;
using System.Linq;

namespace BQUERY
{
    public interface IQTDBinding : IQTDBindObject, IQTDBindCollection
    {
        bool supportsBinding { get; }
    }
}