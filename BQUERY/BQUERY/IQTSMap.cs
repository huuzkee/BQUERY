using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTMap : IQTMapFormat, IQTMapQuery, IQTMapObject
    {
        bool canMap { get; }
    }
}
