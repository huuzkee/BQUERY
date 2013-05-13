using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface IQLProject
    {
        bool canProject { get; }

        // Project Links are one to many with large or very very very  numbers - //
        // Thus Projections are aggregates with suitable additional query arguments//
    }
}
