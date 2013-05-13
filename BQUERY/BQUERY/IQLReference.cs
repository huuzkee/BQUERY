using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQLReference
    {
        bool canReference { get; }

        // Reference Links are one to one//

        //bool HasReferenceLink(long pos);
        //bool HasReferenceLink(string field);
        //bool SetReferenceLink(string SourceField, string TargetTemplate, string TargetField );
        //bool ClearReferenceLink(string SourceField);
        //string GetLinkTargetTemplate(string field);
        //string GetLinkTargetFileld(string field);
    }
}
