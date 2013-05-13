using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTSources : IQTSExport, IQTSImport, IQTSShare, IQTSRemote, IQTSObservable, IQTSObserver
    {
        bool supportsSources { get; }
    }
}
