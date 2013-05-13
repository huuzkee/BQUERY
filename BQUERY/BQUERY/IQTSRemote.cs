using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTSRemote
    {
        bool canRemote { get; }


        byte[] GetChanges();

        object GetChangesObject();

        byte[] SetChanges();

        object SetChangesObject();


        byte[] SetQueryImage();

        object SetQueryImageObject();

        byte[] GetQueryImage();

        object GetQueryImageObject();

        //long dwcontrol.GetFullState ( blob dwasblob )

    }
}
