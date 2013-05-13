using System;
using System.Linq;


namespace BQUERY
{
    public interface IQTable : IQTData, IQTSources, IQTMap, IQTableMetadata
    {
       bool isTable { get; }
    }
}
