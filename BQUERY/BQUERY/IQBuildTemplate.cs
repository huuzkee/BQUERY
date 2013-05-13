using System;
using System.Linq;


namespace BQUERY
{
    public interface IQBuildTemplate : IQBModifyTemplate, IQBTemplateRepository
    {
        bool canBuildTemplate { get; }

        ITemplate Template { get; set; }

        IHost BuildTemplate(eBuildScript ScriptType, String BuildScript, Object ImplementationObject);

        IHost BuildTemplate(eBuildScript ScriptType, String BuildScript);

        IHost BuildTemplate( Object ADOResultSet );

        String TemplateSyntax { get;  }

        String RequestSyntax { get;  }

        String UpdateSyntax { get;  }


    }
}
