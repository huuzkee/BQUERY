using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQEvents
    {
        bool supportsEvents { get; }

        bool TriggerEvent(string eventName, long Arg01, long Arg02);
    }
}
