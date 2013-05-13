using System;
using System.Linq;

namespace BQUERY
{
    public interface IQComposite : IQCJoin, IQCUnion, IQCTree
    {
        bool isComposite { get; }

        long TableCount { get; }

        String GetTableName(long Table);

        long GetTableNumber(String Table);

        bool TableExists(String Table);

        eQueryComposite CompositeType { get; set;  }

        long CompositeChildCount { get; }

        eQueryComposite GetChildQueryCompositeType(long pos);

        IQComposite GetChildQueryComposite( long pos );

        IQCJoin GetChildQueryJoin(long pos);

        IQCUnion GetChildQueryUnion(long pos);

        IQCTree GetChildQueryTree(long pos);

        bool MakeTableUpdateable(long pos);

        String[]  GetTablePrimaryKeys (long pos);

        String[] GetTablePrimaryKeys(String TableName);

    }
}
