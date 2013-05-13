using System;
using System.Linq;


namespace BQUERY
{
    public interface IQSSupport : IQSSupportSQL, IQSSupportWebService, IQSSupportREST
    {
    }
}
