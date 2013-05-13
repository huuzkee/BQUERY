using System;
using System.Linq;


namespace BQUERY
{
    public interface IQReport : IQReportLookup, IQReportComposite, IQReportNested, IQRFormat, IQRGroup, IQRBanded, IQRPrint, IQReportMetadata
    {
    }
}
