using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTDSearch
    {
        bool canSearch { get; }

        long Search(String expression, long Start, long End);

        long SearchNext();


    }
}
