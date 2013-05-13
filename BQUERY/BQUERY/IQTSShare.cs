using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTSShare
    {
        bool canShare { get; }

        bool ShareData(IQuery Target);

        bool ShareDataOff();
    }
}
