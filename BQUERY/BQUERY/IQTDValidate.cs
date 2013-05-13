using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTDValidate
    {
        bool canValidate { get; }

        string GetValidationRule(long field);

        string GetValidationRule(string field);

        bool SetValidationRule(long column, string rule);

        bool SetValidationRule(string column, string rule);
    }
}
