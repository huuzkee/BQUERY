using System;
using System.Linq;

namespace BQUERY
{
    public interface IQTDCopy
    {
        bool canCopy { get; }

        bool CopyRange(eRecordBuffer SourceBuffer, long Start, long End, IQuery Target, eRecordBuffer TargetBuffer, long InsertPos);
    }
}
