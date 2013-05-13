using System;
using System.Linq;


namespace BQUERY
{
    public interface IQService : IQSConnect, IQSRequest, IQSUpdate,  IQSCancel, IQSRefresh,IQSSupport
    {
        bool isService { get; }

        long ErrorCode { get; set; }
    }
}
