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
    public interface IRecordNavigator : IChild, IFramework, ISubscribe, INotify
    {
        Boolean Success { get; set; } 

        Boolean IsEmpty();

        Boolean Exists(long position);

        IFieldNavigator this[long pos] { get; set; }

        IFieldNavigator Select();

        IFieldNavigator Select(long position);

        IRecordNavigator Reset();

        long Position { get; set; }

        long Pos { get; set; }

        eRecordBuffer Buffer { get; set; }

        IFieldNavigator FieldNavigator { get; set; }

        IFieldNavigator CreateFieldNavigator();

        IFieldNavigator Current { get; set; }

        IFieldNavigator Field { get; set; }

        IRecordNavigator First();

        IRecordNavigator Last();

        IRecordNavigator Previous();

        IRecordNavigator Next();

        IRecordNavigator Copy(IRecordNavigator Target);

        IRecordNavigator Copy(IRecordNavigator Target, long buffer);

        IRecordNavigator Copy(IRecordNavigator Target, eRecordBuffer buffer);

        IRecordNavigator CopyRange(IRecordNavigator Target, long count);

        IRecordNavigator CopyRange(IRecordNavigator Target, long count, long buffer);

        IRecordNavigator CopyRange(IRecordNavigator Target, long count, eRecordBuffer buffer); 

        IRecordNavigator Move(IRecordNavigator Target);

        IRecordNavigator Move(IRecordNavigator Target, long buffer);

        IRecordNavigator Move(IRecordNavigator Target, eRecordBuffer buffer);

        IRecordNavigator MoveRange(IRecordNavigator Target, long count);

        IRecordNavigator MoveRange(IRecordNavigator Target, long count, long buffer);

        IRecordNavigator MoveRange(IRecordNavigator Target, long count, eRecordBuffer buffer);

        IRecordNavigator Insert();

        IRecordNavigator Insert(long Count);

        IRecordNavigator Delete();

        IRecordNavigator Delete(long Count);

        IRecordNavigator Add();

        IRecordNavigator Add(long pos);

        IRecordNavigator Add(object boundobj);

        IRecordNavigator Remove();

        IRecordNavigator Remove(long pos);

        IRecordNavigator Remove(object boundobj);

        IRecordNavigator Clear();

        IRecordNavigator Push();

        IRecordNavigator Pop();

        IRecordNavigator Peek( long pos );

        IRecordNavigator PeekHead();

        IRecordNavigator PeekTail();

        IRecordNavigator Enqueue();

        IRecordNavigator Dequeue();

        long Count(eRecordBuffer Buffer);

        long Count();

        IRecordNavigator Search(String expression,  long End);

        IRecordNavigator Search();

        IRecordNavigator FindIncomplete(bool UpdateOnly, IFieldNavigator FieldNav);

        IRecordNavigator FindIncomplete(bool UpdateOnly);
 
        IRecordNavigator FindIncomplete(IFieldNavigator FieldNav);

        IRecordNavigator FindIncomplete();

        IRecordNavigator GetNextModified();
        
        IRecordNavigator GetNextModified(eRecordBuffer Buffer);

        long GetRecordID();
        
        long GetRecordNumberFromRecordID(long recordId);

        IRecordNavigator BindObject(Object Target);

        IRecordNavigator BindType(Type type);

        IRecordBinding Binding { get; set; }

        bool AutoBind { get; set; }

        IQuery ParentQuery { get; set; }
    }
}