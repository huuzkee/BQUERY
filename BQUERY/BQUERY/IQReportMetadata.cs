using System;
using System.Linq;

namespace BQUERY
{
    public interface IQReportMetadata
    {
        bool supportsReportMetadata { get; }

        bool SetAttribute(String Value, String Property);

        bool SetAttribute(String Value, String Property, string TemplateItem) ;

        bool SetAttribute(String Value, String Property, string TemplateItem, string Component);

        bool SetAttribute(String Value, String Property, string TemplateItem, string Component, string SubComponent);

        string GetAttribute(String Property);

        string GetAttribute(String Property, string TemplateItem);

        string GetAttribute(String Property, string TemplateItem, string Component);

        string GetAttribute(String Property, string TemplateItem, string Component, string SubComponent);

        bool SetBandAttribute(String Value, String Property, string Band, long Level);

        string GetBandAttribute( String Property, string Band, long Level);

        string GetBands();

        string[] GetBandList();
    }
}