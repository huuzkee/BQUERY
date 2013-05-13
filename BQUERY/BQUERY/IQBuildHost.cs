using System;
using System.Linq;

namespace BQUERY
{
    public interface IQBuildHost
    {
        bool canBuildHost { get; }

        IHost Host { get; set; }

        IHost BuildHost(eBuildScript SriptType, String BuildScript, Object ImplementationObject);

        IHost BuildHost(eBuildScript SriptType, String BuildScript);

    }
}