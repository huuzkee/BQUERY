using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTSExport
    {
        bool canExport { get; }

        IQuery Export(String File, eFileFormat Format, eTextEncoding Encoding, Boolean withHeaders);

        IQuery ExportFormattedText(String File);

        IQuery ExportFormattedText(String File, eFileFormat Encoding, string separatorChar, string quoteChar, string lineTerminatorChar, bool keepLineFeeds);

        IQuery ExportText(String File);

        IQuery ExportText(String File, string separatorChar, string quoteChar, string lineTerminatorChar);

        IQuery ExportResultSet(object RSet);

        object ExportResultSet(object RSet, eRecordBuffer Buffer);
    }
}
