//*********************************************************************************************************************//
//*********************************************************************************************************************//
//***  COPYRIGHT:   Copyright (c) 2000-2014 by Bancstreet Axellera Ltd. All Rights Reserved.                        ***//
//***                                                                                                               ***//
//***  IMPORTANT: This file contains proprietary confidential information and copyright protected maerial.          ***//
//***             Any use including but not limited to disclosure, distribution, copying, storage, compilation,     ***// 
//***             reverse engineering, execution or interpretation in a computer system requires prior written      ***//
//***             permission by Bancstreet Axellera Ltd.                                                            ***//
//***                                                                                                               ***//
//***===============================================================================================================***//
//***                                                                                                               ***//
//***  NAMESPACE:   BQUERY.BASE                                                                                     ***//
//***  INTERFACE:   IEventAttributeIterator                                                                         ***//
//***                                                                                                               ***//
//***  PURPOSE:                                                                                                     ***//
//***                                                                                                               ***//
//***                                                                                                               ***//
//***===============================================================================================================***//
//***    Version         |   Release Date |  Description                                                            ***//
//***---------------------------------------------------------------------------------------------------------------***//
//***    2.0             |   DD/MM/YYYY   |                                                                         ***//
//***===============================================================================================================***//
//***                                                                                                               ***//
//***  TODO:                                                                                                        ***//
//***                                                                                                               ***//
//***  [1]  A constructur configuring:  _framework, _parent and call INITIALISE()                                   ***//
//***  [2]  Implement public bool Open()                                                                            ***//
//***                                                                                                               ***//
//***===============================================================================================================***//
//***    QA Status       |   QA Date      |  QA Comments                                                            ***//
//***---------------------------------------------------------------------------------------------------------------***//
//***    REVIEW          |   16/04/2013   |                                                                         ***//
//***===============================================================================================================***//
//*********************************************************************************************************************//
//*********************************************************************************************************************//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BQUERY
{
    public interface ISubmitHelper
    {
        Boolean Submit_S(Object Implemenation, String Val01);
        Boolean Submit_SS(Object Implemenation, String Val01, String Val02);
        Boolean Submit_SSS(Object Implemenation, String Val01, String Val02, String Val03);
        Boolean Submit_SSSS(Object Implemenation, String Val01, String Val02, String Val03, String Val04);
        Boolean Submit_SSSSS(Object Implemenation, String Val01, String Val02, String Val03, String Val04, String Val05);

        Boolean Submit_N(Object Implemenation, Double Val01);
        Boolean Submit_NN(Object Implemenation, Double Val01, Double Val02);
        Boolean Submit_NNN(Object Implemenation, Double Val01, Double Val02, Double Val03);
        Boolean Submit_NNNN(Object Implemenation, Double Val01, Double Val02, Double Val03, Double Val04);
        Boolean Submit_NNNNN(Object Implemenation, Double Val01, Double Val02, Double Val03, Double Val04, Double Val05);

        Boolean Submit_A(Object Implemenation, Decimal Val01);
        Boolean Submit_AA(Object Implemenation, Decimal Val01, Decimal Val02);
        Boolean Submit_AAA(Object Implemenation, Decimal Val01, Decimal Val02, Decimal Val03);
        Boolean Submit_AAAA(Object Implemenation, Decimal Val01, Decimal Val02, Decimal Val03, Decimal Val04);
        Boolean Submit_AAAAA(Object Implemenation, Decimal Val01, Decimal Val02, Decimal Val03, Decimal Val04, Decimal Val05);

        Boolean Submit_D(Object Implemenation, DateTime Val01);
        Boolean Submit_DD(Object Implemenation, DateTime Val01, DateTime Val02);
        Boolean Submit_DDD(Object Implemenation, DateTime Val01, DateTime Val02, DateTime Val03);
        Boolean Submit_DDDD(Object Implemenation, DateTime Val01, DateTime Val02, DateTime Val03, DateTime Val04);
        Boolean Submit_DDDDD(Object Implemenation, DateTime Val01, DateTime Val02, DateTime Val03, DateTime Val04, DateTime Val05);

        Boolean Submit_NS(Object Implemenation, Double Val01, String Val02);
        Boolean Submit_NSS(Object Implemenation, Double Val01, String Val02, String Val03);
        Boolean Submit_NSSS(Object Implemenation, Double Val01, String Val02, String Val03, String Val04);
        Boolean Submit_NSSSS(Object Implemenation, Double Val01, String Val02, String Val03, String Val04, String Val05);
        Boolean Submit_NNS(Object Implemenation, Double Val01, Double Val02, String Val03);
        Boolean Submit_NNSS(Object Implemenation, Double Val01, Double  Val02, String Val03, String Val04);
        Boolean Submit_NNSSS(Object Implemenation, Double Val01, Double  Val02, String Val03, String Val04, String Val05);
        Boolean Submit_NNNS(Object Implemenation, Double Val01, Double  Val02, Double Val03, String Val04);
        Boolean Submit_NNNSS(Object Implemenation, Double Val01, Double  Val02, Double Val03, String Val04, String Val05);
        Boolean Submit_NNNNS(Object Implemenation, Double Val01, Double  Val02, Double Val03, String Val04, String Val05);

        Boolean Submit_ND(Object Implemenation, Double Val01, DateTime Val02);
        Boolean Submit_NDD(Object Implemenation, Double Val01, DateTime Val02, DateTime Val03);
        Boolean Submit_NDDD(Object Implemenation, Double Val01, DateTime Val02, DateTime Val03, DateTime Val04);
        Boolean Submit_NDDDD(Object Implemenation, Double Val01, DateTime Val02, DateTime Val03, DateTime Val04, DateTime Val05);

        
        Boolean Submit_SD(Object Implemenation, String  Val01, DateTime Val02);
        Boolean Submit_SDD(Object Implemenation, String  Val01, DateTime Val02, DateTime Val03);
        Boolean Submit_SDDD(Object Implemenation, String  Val01, DateTime Val02, DateTime Val03, DateTime Val04);
        Boolean Submit_SDDDD(Object Implemenation, String  Val01, DateTime Val02, DateTime Val03, DateTime Val04, DateTime Val05);

        Boolean Submit_NSD(Object Implemenation, Double Val01, String Val02, DateTime Val03);
        Boolean Submit_NSDD(Object Implemenation, Double Val01, String Val02, DateTime Val03, DateTime Val04);
        Boolean Submit_NSDDD(Object Implemenation, Double Val01, String Val02, DateTime Val03, DateTime Val04, DateTime Val05);
        Boolean Submit_NSDDDD(Object Implemenation, Double Val01, String Val02, DateTime Val03, DateTime Val04, DateTime Val05, DateTime Val06);

        Boolean Submit_NNSD(Object Implemenation, Double Val01, Double Val02, String Val03, DateTime Val04);
        Boolean Submit_NNSDD(Object Implemenation, Double Val01, Double Val02, String Val03, DateTime Val04, DateTime Val05 );
        Boolean Submit_NNSDDD(Object Implemenation, Double Val01, Double Val02, String Val03, DateTime Val04, DateTime Val05, DateTime Val06 );
        Boolean Submit_NNSDDDD(Object Implemenation, Double Val01, Double Val02, String Val03, DateTime Val04, DateTime Val05, DateTime Val06, DateTime Val07 );

        Boolean Submit_NNNSD(Object Implemenation, Double Val01, Double Val02, Double Val03, String Val04, DateTime Val05  );
        Boolean Submit_NNNSDD(Object Implemenation, Double Val01, Double Val02, Double Val03, String Val04, DateTime Val05, DateTime Val06  );
        Boolean Submit_NNNSDDD(Object Implemenation, Double Val01, Double Val02, Double Val03, String Val04, DateTime Val05, DateTime Val06, DateTime Val07  );
        Boolean Submit_NNNSDDDD(Object Implemenation, Double Val01, Double Val02, Double Val03, String Val04, DateTime Val05, DateTime Val06, DateTime Val07, DateTime Val08  );
        
        Boolean Submit_DYNAMIC(Object Implemenation);

        Boolean AddArgument(Object IFieldValue);
        Boolean ClearArguments( Object IFieldValue );
        Boolean Submit(Object Implemenation);

    }
}
