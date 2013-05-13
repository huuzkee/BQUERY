using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTDTruncate
    { 
        bool canTruncate { get; }
        
        bool Truncate(long Start, long End, eRecordBuffer Buffer);

        bool Truncate(eRecordBuffer Buffer);

        bool Truncate(long Start, long End);

        bool Truncate();


    }
}