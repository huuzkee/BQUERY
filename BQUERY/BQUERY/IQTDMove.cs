using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTDMove
    {
        bool canMove { get; }

        bool MoveRange(eRecordBuffer SourceBuffer, long Start, long End, IQuery Target, eRecordBuffer TargetBuffer, long InsertPos);

    }
}
