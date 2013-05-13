using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTSImport
    {

        bool canImport{ get; }

        IQuery Import(String File, eFileFormat Format);

        IQuery Import(String File, eFileFormat Format, long startrow, long endrow, long startcol, long endcol, long insertafter);

        IQuery ImportString(String Content, eFileFormat Format);

        IQuery ImportString(String Content, eFileFormat Format, long startrow, long endrow, long startcol, long endcol, long insertafter);
    }
}
