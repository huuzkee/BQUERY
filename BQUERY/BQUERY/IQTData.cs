using System;
using System.Linq;

namespace BQUERY
{
    public interface IQTData : IQTDCopy, IQTDFilter, IQTDDictionary, IQTDMove, IQTDSearch, IQTDSort, IQTDValidate, IQTDCompletionCheck, IQTDCheckModification, IQTDGrid, IQTDNavigate, IQTDTruncate, IQTDBinding
    {
        bool supportsTableData { get; }

        long Count(eFieldStatus Buffer);

        long Count(eRecordBuffer Buffer);

        long Count();

        long RecordCount { get; set; }

        long GetRecordID(eRecordBuffer Buffer, long pos);

        long GetRecordNumberFromRecordID(long recordId);

        bool Reset();

        IQuery Delete(long pos);

        IQuery Insert(long pos);

        long NoOfDeletedRecords();

        long NoOfFilteredRecords();

        long NoOfModifiedRecords();
    }
}