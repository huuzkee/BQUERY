using System;
using System.Linq;


namespace BQUERY
{
    public interface IQDocument : IQDText, IQDVideo, IQDImage, IQDAudio, IQDBinary, IQDDirectory
    {
        bool isDocument { get; }

        eQueryDocumentType getDocumentType();

        string GetDocumentMediaFormat();
    }
}
