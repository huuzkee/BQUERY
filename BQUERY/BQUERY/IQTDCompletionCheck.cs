using System;
using System.Linq;

namespace BQUERY
{
    public interface IQTDCompletionCheck
    {
        bool canCompletionCheck { get; }

        bool FindIncomplete(eRecordBuffer Buffer, long Record, long Field, string FieldName, bool UpdateOnly);

        long FindIncompleteField();

        long FindIncompleteRecord();
    }
}