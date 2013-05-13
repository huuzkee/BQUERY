using System;
using System.Linq;

namespace BQUERY
{
    public interface IQBTemplateRepository
    {
        bool supportsTemplateRepository { get; }

        ITemplate LoadTemplate(String Name);

        bool StoreTemplate(String Name, ITemplate Template);

        bool StoreTemplate(String Name);

        bool OpenTemplateRepository(String AccessParameters);

        bool CloseTemplateRepository(String AccessParameters);

        bool ValidTemplateRepository { get; }
    }
}