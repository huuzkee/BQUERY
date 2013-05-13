using System;
using System.Linq;


namespace BQUERY
{
    public interface IQDBinary
    {
        bool isBinary { get; }

        byte[] BinaryDocumentContent { get; set; }
    }
}
