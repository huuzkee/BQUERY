using System;
using System.Linq;

namespace BQUERY
{
    public interface IQTDGrid 
    {
        bool supportsGrid { get; }

        IFieldValue GetField(eRecordBuffer Buffer, long Record, long Field, bool Original);

        bool GetField(eRecordBuffer Buffer, long Record, long Field, bool Original, IFieldValue Value);

        DateTime GetFieldDate(eRecordBuffer Buffer, long Record, long Field, bool Original);

        DateTime GetFieldTime(eRecordBuffer Buffer, long Record, long Field, bool Original);

        DateTime GetFieldDateTime(eRecordBuffer Buffer, long Record, long Field, bool Original);

        Decimal GetFieldDecimal(eRecordBuffer Buffer, long Record, long Field, bool Original);

        Double GetFieldNumber(eRecordBuffer Buffer, long Record, long Field, bool Original);

        String GetFieldString(eRecordBuffer Buffer, long Record, long Field, bool Original);

        String GetFieldStringFormatted(eRecordBuffer Buffer, long Record, long Field, bool Original);

        String GetFieldStringRaw(eRecordBuffer Buffer, long Record, long Field, bool Original);

        eFieldStatus GetFieldStatus(eRecordBuffer Buffer, long Record, long Field);

        bool SetField(eRecordBuffer Buffer, long Record, long Field, bool Original, IFieldValue Value);

        bool SetFieldDate(eRecordBuffer Buffer, long Record, long Field, bool Original, DateTime Value);

        bool SetFieldTime(eRecordBuffer Buffer, long Record, long Field, bool Original, DateTime Value);

        bool SetFieldDateTime(eRecordBuffer Buffer, long Record, long Field, bool Original, DateTime Value);

        bool SetFieldDecimal(eRecordBuffer Buffer, long Record, long Field, bool Original, Decimal Value);

        bool SetFieldNumber(eRecordBuffer Buffer, long Record, long Field, bool Original, Double Value);

        bool SetFieldString(eRecordBuffer Buffer, long Record, long Field, bool Original, string Value);

        bool SetFieldStatus(eRecordBuffer Buffer, long Record, long Field, eFieldStatus status);
    }
}