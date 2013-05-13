using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQImplementationAccess
    {
        bool supportsImplementationAccess { get; }

        Object HostImplementationObject { get; set; }

        Object TemplateImplementationObject { get; set; }

        Object ConnectionImplementationObject { get; set; }

    }
}
