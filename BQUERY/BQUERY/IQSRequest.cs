using System;
using System.Linq;


namespace BQUERY
{
    public interface IQSRequest :IQSRBindParameters
    {
        bool canRequest { get; }

        IQuery Submit();

    }
}
