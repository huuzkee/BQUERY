using System;

using System.Linq;


namespace BQUERY
{
    public interface IQLink : IQLReference, IQLAggregate, IQLProject
    {
        bool canLink { get; }


    }
}
