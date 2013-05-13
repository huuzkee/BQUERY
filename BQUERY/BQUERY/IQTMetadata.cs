using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQTableMetadata
    {
        bool supportsTableMetadata { get; }

        bool FieldExists(long Field);

        long FieldCount { get; set; }

        string GetFieldName(long pos);

        long GetNamedField(string field);

        string FieldTypeNameTranslator(string rawtype);

        eFieldType FieldTypeTranslator(string FieldType);

        string FieldTypeNameRaw(long pos);

        string FieldTypeName(long pos);

        eFieldType FieldType(long pos);

        string FieldTypeNameRaw(string field);

        bool FieldExists(string Field);

        string FieldTypeName(string field);

        eFieldType FieldType(string field);
        
    }
}