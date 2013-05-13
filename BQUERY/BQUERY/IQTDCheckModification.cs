using System;
using System.Linq;

namespace BQUERY
{
    public interface IQTDCheckModification
    {
        bool canCheckModification { get; }

        long GetNextModifiedRecord(eRecordBuffer Buffer, long Record);
    }
}