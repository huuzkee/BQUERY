using System;
using System.Linq;


namespace BQUERY
{
    public interface IQDVideo
    {
        bool isVideo { get; }

        byte[] VideoDocumentBinary { get; set; }
    }
}
