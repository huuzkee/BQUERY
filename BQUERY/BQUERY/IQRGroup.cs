using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQRGroup
    {
        bool canGroup { get; }

        bool Group();

        long NextGroupBreak(long row, long level);
    }
}
