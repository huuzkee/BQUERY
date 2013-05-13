using System;
using System.Linq;


namespace BQUERY
{
    public interface IQDImage
    {
        bool isImage { get; }

        byte[] ImageDocumentBinary { get; set; }
    }
}
