using System;
using System.Linq;
using BQUERY.BASE;
using PBQUERYLIB;
namespace BQUERY.IMP.PBQUERY
{
    public class Query : QueryBase
    {

        //connectionpb _conn ;
        protected pbdatastore _pbq ;
   

        new bool isTable
        {
            get { throw new NotImplementedException(); }
        }

        new bool supportsTableData
        {
             get
            {
                throw new NotImplementedException();
            }
        }

        new public long Count(eFieldStatus Buffer)
        {
            return (long) _pbq.rowcount();
        }

       
    }
}
