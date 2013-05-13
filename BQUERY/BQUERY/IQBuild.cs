using System;
using System.Linq;

namespace BQUERY
{
    public interface IQBuild : IQBuildTemplate, IQBuildHost
    {
        bool canBuild { get; }

        IQuery Create(String TemplateName, String HostName);

        IQuery Create(String TemplateName);

        IQuery Create(ITemplate Template, IHost Host);

        IQuery Create(ITemplate Template);
    }
}