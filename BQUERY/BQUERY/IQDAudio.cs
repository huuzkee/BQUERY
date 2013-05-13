using System;
using System.Linq;


namespace BQUERY
{
    public interface IQDAudio
    {
        bool isAudio{ get; }

        byte[] AudioDocumentBinary { get; set; }
    }
}
