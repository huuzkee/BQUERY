using System;
using System.Linq;


namespace BQUERY
{
    public interface IQRPrint
    {
        bool canPrint { get; }

        bool Print(bool ShowPrintDialog, bool ShowCancelDialog);

        bool Print();

        bool PrintCancel();
    }
}