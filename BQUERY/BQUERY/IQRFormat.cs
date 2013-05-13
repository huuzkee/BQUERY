using System;

using System.Linq;

namespace BQUERY
{
    public interface IQRFormat
    {
        bool canFormat { get; }

        string GetFormat(long Field);

        string GetFormat(string Field);

        bool SetFormat(long Field, string Format);

        bool SetFormat(string Field, string Format);
    }
}