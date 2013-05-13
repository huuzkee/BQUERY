using System;
using System.Linq;

namespace BQUERY
{
    public interface IQBModifyTemplate
    {
        bool canModifyTemplate { get; }

        string DescribeTemplateProperties(string propertyList);

        bool ModifyTemplateProperty(string Request);
    }
}