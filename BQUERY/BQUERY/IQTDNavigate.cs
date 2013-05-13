using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTDNavigate
    {
        bool canNavigate { get; }

        IRecordNavigator Record { get; set; }
    }
}
