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
    public interface IFieldNavigator : IChild, IFramework, ISubscribe, INotify
    {
        IQuery ParentQuery { get; set; }

        Boolean Exists(long position);

        Boolean Exists(String name);

        Boolean HasType(String type);

        Boolean HasType(eFieldType type);

        Boolean IsString();

        Boolean IsNumber();

        Boolean IsDate();

        Boolean IsDateTime();

        Boolean IsTime();

        Boolean IsDecimal();

        Boolean IsBLOB();

        Boolean HasChild();

        Boolean HasLink();

        Boolean Success();

        IFieldNavigator Field { get; }

        IQuery Child { get; set; }

        IQuery Link { get; set; }

        String Name { get; set; }

        long Number { get; set; }

        long Count { get; set; }
        
        IFieldNavigator Select();

        IFieldNavigator Select(long position);

        IFieldNavigator Select(String Name);

        IFieldNavigator First();

        IFieldNavigator Last();

        IFieldNavigator Previous();

        IFieldNavigator Next();

        IFieldNavigator FindIncomplete();

        IFieldNavigator FindIncomplete(bool updateOnly);
        
        IFieldNavigator this[string FieldName] { get; set; }

        IFieldNavigator this[long FieldNumber] { get; set; }

        IFieldValue Value { get; set; }

        bool Refresh();

        bool AutoRefresh { get; set; }

        eRecordBuffer Buffer { get; set; }

        IRecordNavigator ParentRecordNavigator { get; set; }
    }
}