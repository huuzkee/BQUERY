using System;
using System.Linq;

namespace BQUERY
{
    public interface IQSSupportSQL
    {
        bool canSupportSQL { get; }

        bool SetSQLPreview(string statement);

        bool SetSQLSelect(string statement);

        string GetSQLQuery();
    }
}