using System;
using System.Linq;

namespace BQUERY
{
    public interface IQSConnect
    {
        bool canConnect { get; }

        IConnection Connection { get; set; }


        object GetConnectionImplementation();

        bool SetConnectionImplementation(object implemention);
    }
}
