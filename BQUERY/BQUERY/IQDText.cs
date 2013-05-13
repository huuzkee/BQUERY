using System;
using System.Linq;


namespace BQUERY
{
    public interface IQDText
    {
        bool isText { get; }

        long DocumentFind(String expression, long Start, long End);

        long DocumentFindNext();

        long InsertDocument(string File, bool Replace, eTextFileType FileType);

        bool InsertDocumentContent(string Content, eTemplateBand Band, eTextFileType FileType);

        string TextDocumentContent { get; set; }

        string TextDocumentEncoding { get; set; }


    }
}
