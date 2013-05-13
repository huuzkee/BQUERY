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
//***  CLASS:       DiagnosticManagerBase                                                                             ***//
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

namespace BQUERY.BASE
{
    public class RecordNavigatorBase : IRecordNavigator
    {
        string _framework = "BASE";
        object _parent;
        bool _success = false ;
        IQuery _parenQuery;
        long _position ;
        eRecordBuffer _buffer;
        IFieldNavigator _fieldNavigator;
        string _searchExpression;
        bool _autoBind = false ;
        ISubscriptionManager _subscribers;
        bool _findIncompleteUpdateOnly = false;

        public object Parent
        {
            get
            {
                return _parent;
            }
        }

        public string Framework
        {
            get
            {
                return _framework;
            }
        }

        public bool IsEmpty()
        {
            if (ParentQuery.RecordCount < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Exists(long position)
        {
            if (ParentQuery.RecordCount >= position)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IFieldNavigator this[long pos]
        {
            get
            {
                this.Pos = pos;
                return this.FieldNavigator;
            }
            set
            {
                this.Pos = pos;
                this.FieldNavigator = value;
            }
        }

        public IFieldNavigator Select()
        {
            return this.FieldNavigator;
        }

        public IFieldNavigator Select(long position)
        {
            this.Pos = position;
            return this.FieldNavigator;
        }

        public IRecordNavigator Reset()
        {
            this._position = 0;
            return this;
        }

        public long Position
        {
            get
            {
                return this.Pos;
            }
            set
            {
                this.Pos = value;
            }
        }

        public long Pos
        {
            get
            {
                return _position;
            }
            set
            {
                Success = Exists(value);
                if (Success)
                {
                    _position = value;
                }
            }
        }

        public eRecordBuffer Buffer
        {
            get
            {
                return _buffer;
            }
            set
            {
                _buffer = value ;
            }
        }

        public IFieldNavigator FieldNavigator
        {
            get
            {
                return _fieldNavigator ;
            }
            set
            {
                _fieldNavigator = value ;
            }
        }

        public IFieldNavigator Current
        {
            get
            {
                return FieldNavigator;
            }
            set
            {
                FieldNavigator = value ;
            }
        }

        public IFieldNavigator Field
        {
            get
            {
                return FieldNavigator;
            }
            set
            {
                FieldNavigator = value;
            }
        }

        public IRecordNavigator First()
        {
            this.Pos = 1;
            return this;
        }

        public IRecordNavigator Last()
        {
            this.Pos = ParentQuery.RecordCount;
            return this;
        }

        public IRecordNavigator Previous()
        {
            if (Pos > 1)
            {
                Pos++;
            }
            else
            {
                Success = false; 
            }
            return this;
        }

        public IRecordNavigator Next()
        {
            if (Pos < ParentQuery.RecordCount)
            {
                Pos++;
            }
            else
            {
                Success = false;
            }
            return this;
        }

        public IRecordNavigator Copy(IRecordNavigator Target)
        {
            return this.CopyRange(Target, 1);
        }

        public IRecordNavigator Copy(IRecordNavigator Target, long buffer)
        {
            return this.CopyRange(Target, 1, buffer);
        }

        public IRecordNavigator Copy(IRecordNavigator Target, eRecordBuffer buffer)
        {
            return this.CopyRange(Target, 1, buffer);
        }

        public IRecordNavigator CopyRange(IRecordNavigator Target, long count)
        {
            return this.CopyRange(Target, count, this.Buffer);
        }

        public IRecordNavigator CopyRange(IRecordNavigator Target, long count, long buffer)
        {
            return this.CopyRange(Target, count, (eRecordBuffer)buffer);
        }

        public IRecordNavigator CopyRange(IRecordNavigator Target, long count, eRecordBuffer buffer)
        {
            ParentQuery.CopyRange(this.Buffer, this.Pos, this.Pos + count, Target.ParentQuery, buffer, Target.Pos);
            return this;
        }

        public IRecordNavigator Move(IRecordNavigator Target)
        {
            return MoveRange(Target, 1, Buffer);
        }

        public IRecordNavigator Move(IRecordNavigator Target, long buffer)
        {
            return MoveRange(Target, 1, (eRecordBuffer)buffer);
        }

        public IRecordNavigator Move(IRecordNavigator Target, eRecordBuffer buffer)
        {
            return MoveRange(Target, 1, buffer);
        }

        public IRecordNavigator MoveRange(IRecordNavigator Target, long count)
        {
            return MoveRange(Target, count, Buffer);
        }

        public IRecordNavigator MoveRange(IRecordNavigator Target, long count, long buffer)
        {
            return MoveRange(Target, count, (eRecordBuffer)buffer);
        }

        public IRecordNavigator MoveRange(IRecordNavigator Target, long count, eRecordBuffer buffer)
        {
            ParentQuery.MoveRange(this.Buffer, this.Pos, this.Pos + count, Target.ParentQuery, buffer, Target.Pos);
            return this;
        }

        public IRecordNavigator Insert()
        {
            return this.Insert(this.Pos);
        }

        public IRecordNavigator Insert(long pos)
        {
            ParentQuery.Insert(pos);
            return this;
        }

        public IRecordNavigator Delete()
        {
            return this.Delete(this.Pos);
        }

        public IRecordNavigator Delete(long pos)
        {
            ParentQuery.Delete(pos);
            return this;
        }

        public IRecordNavigator Add()
        {
            return this.Insert();
        }

        public IRecordNavigator Add(long pos)
        {
            return this.Insert(pos);
        }

        public IRecordNavigator Remove()
        {
            return this.Delete();
        }

        public IRecordNavigator Remove(long pos)
        {
            return this.Delete();
        }

        // TODO >>>>>>>>> //

        public IRecordNavigator Clear()
        {
            ParentQuery.Truncate();
            return this;
        }

        public IRecordNavigator Push()
        {
            Insert(ParentQuery.RecordCount);
            this.Pos = ParentQuery.RecordCount;
            return this ;
        }

        public IRecordNavigator Pop()
        {
            Delete(ParentQuery.RecordCount);
            this.Pos = ParentQuery.RecordCount;
            return this;
        }

        public IRecordNavigator Peek(long pos)
        {
            this.Pos = pos;
            return this;
        }

        public IRecordNavigator PeekHead()
        {
            this.Pos = ParentQuery.RecordCount;
            return this;
        }

        public IRecordNavigator PeekTail()
        {
            this.Pos = 1;
            return this;
        }

        public IRecordNavigator Enqueue()
        {
            Insert(ParentQuery.RecordCount);
            this.Pos = ParentQuery.RecordCount;
            return this;
        }

        public IRecordNavigator Dequeue()
        {
            Delete(1);
            this.Pos = 1;
            return this;
        }

        public long Count(eRecordBuffer buffer)
        {
            return ParentQuery.Count(buffer);
        }

        public long Count()
        {
            return ParentQuery.Count(this.Buffer);
        }

        public IRecordNavigator Search(string expression, long End)
        {
            _searchExpression = expression;
            ParentQuery.Search(_searchExpression, this.Pos, End);
            return this;
        }

        public IRecordNavigator Search()
        {
            this.Select(ParentQuery.SearchNext());
            this.Success = ParentQuery.Success;
            return this;
        }

        public IRecordNavigator FindIncomplete(bool UpdateOnly, IFieldNavigator FieldNav)
        {
            long nextcol = 0;

            long lRecord = this.Pos ; long lField = FieldNav.Number;  string lName = "";

            _success = false;

            this.Success = ParentQuery.FindIncomplete(this.Buffer, lRecord, lField, lName, UpdateOnly);

            if (this.Success)
            {
                this.Pos = lRecord;
            }

            return this;
        }

        public IRecordNavigator FindIncomplete(bool UpdateOnly)
        {
            return this.FindIncomplete(UpdateOnly, this.FieldNavigator);   
        }

        public IRecordNavigator FindIncomplete(IFieldNavigator FieldNav)
        {
            return this.FindIncomplete(true, FieldNav);   
        }

        public IRecordNavigator FindIncomplete()
        {
            return this.FindIncomplete(true, this.FieldNavigator);   
        }

        public IRecordNavigator GetNextModified()
        {
            return this.GetNextModified(this.Buffer);
        }

        public IRecordNavigator GetNextModified(eRecordBuffer buffer)
        {
            long pos = ParentQuery.GetNextModifiedRecord(this.Buffer, this.Pos);
            if (ParentQuery.Success)
            {
                this.Pos = pos; 
                this.Success = true ;
            }
            else
            {
                this.Success = false;
            }
            return this;
        }

        public long GetRecordID()
        {
            return ParentQuery.GetRecordID(this.Buffer, this.Pos);
        }

        public long GetRecordNumberFromRecordID(long recordId)
        {
            return ParentQuery.GetRecordNumberFromRecordID(recordId);
                  
        }



        public bool AutoBind
        {
            get
            {
                return _autoBind;
            }
            set
            {
                _autoBind = value ;
            }
        }

        public IQuery ParentQuery
        {
            get
            {
                return _parenQuery;
            }
            set
            {
                _parenQuery = value ;
            }
        }

        public bool Receive(INotify Source, string Event)
        {
            return _subscribers.Receive(Source, Event);
        }

        public bool Receive(INotify Source, IEvent Event)
        {
            return _subscribers.Receive( Source,  Event);
        }

        public bool Subscribe(ISubscribe Subscriber, string Eventname)
        {
            return _subscribers.Subscribe(Subscriber, Eventname);
        }

        public bool UnSubscribe(ISubscribe Subscriber, string Eventname)
        {
            return _subscribers.UnSubscribe(Subscriber, Eventname);
        }

        public bool Success
        {
            get
            {
                return _success;
            }
            set
            {
                _success = value;
            }
        }

        ///////  TODO ///////////////////////////////////////////

        public IFieldNavigator CreateFieldNavigator()
        {
            throw new NotImplementedException();
        }

        public IRecordNavigator Add(object boundobj)
        {
            throw new NotImplementedException();
        }

        public IRecordNavigator Remove(object boundobj)
        {
            throw new NotImplementedException();
        }

        public IRecordNavigator BindObject(object Target)
        {
            throw new NotImplementedException();
        }

        public IRecordNavigator BindType(Type type)
        {
            throw new NotImplementedException();
        }

        public IRecordBinding Binding
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}