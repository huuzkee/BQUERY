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
//***  CLASS:       FieldNavigatorBase                                                                            ***//
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

namespace BQUERY.BASE
{
    public class FieldNavigatorBase : IFieldNavigator
    {
        string _framework = "BASE";
        object _parent;
        IQuery _parentQuery;
        bool _autoRefresh = false;
        ISubscriptionManager _subscribers;
        long _fieldNumber;
        string _fieldName;
        bool _success = false;
        eRecordBuffer _buffer = eRecordBuffer.Primary ;
        IRecordNavigator _parentRecordNavigator ;

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public eRecordBuffer Buffer
        {
            get
            {
                return _buffer;
            }
            set
            {
                _buffer = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public IRecordNavigator ParentRecordNavigator
        {
            get
            {
                return _parentRecordNavigator;
            }
            set
            {
                _parentRecordNavigator = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public object Parent
        {
            get
            {
                return _parent;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public string Framework
        {
            get
            {
                return _framework;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public bool Initialise()
        {
            _subscribers = new SubscriptionManagerBase();

            return true;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>   
        public IFieldNavigator First()
        {
            this.Select(1);
            if (this.AutoRefresh)
            {
                Refresh();
            }
            return this;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public IFieldNavigator Last()
        {
            Refresh();
            this.Select(this.Count);
            if (this.AutoRefresh)
            {
                Refresh();
            }
            return this;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public bool UnSubscribe(ISubscribe Subscriber, string Eventname)
        {
            return _subscribers.UnSubscribe(Subscriber, Eventname) ;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public bool AutoRefresh
        {
            get
            {
                return _autoRefresh ; 
            }
            set
            {
                _autoRefresh = value; 
                if (AutoRefresh)
                {
                    Refresh();
                };
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public IQuery ParentQuery
        {
            get
            {
                return _parentQuery; ;
            }
            set
            {
                _parentQuery = value;
            }
        }

        public bool Exists(long position)
        {
            return _parentQuery.FieldExists(position);
        }

        public bool Exists(string name)
        {
            return _parentQuery.FieldExists(name);
        }

        public bool HasType(string type)
        {
            if (_parentQuery.FieldTypeName(this.Number) == type)
            {
                return true;
            }
            else
            {
                return false ;
            }
        }

        public bool HasType(eFieldType type)
        {
            if (_parentQuery.FieldType(this.Number) == type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsString()
        {
            return HasType(eFieldType.String);
        }

        public bool IsNumber()
        {
            return HasType(eFieldType.Number);
        }

        public bool IsDecimal()
        {
            return HasType(eFieldType.Decimal);
        }

        public bool IsDate()
        {
            return HasType(eFieldType.Date);
        }

        public bool IsDateTime()
        {
            return HasType(eFieldType.DateTime);
        }

        public bool IsTime()
        {
            return HasType(eFieldType.Time);
        }

        public bool IsBLOB()
        {
            return HasType(eFieldType.BLOB);
        }

        public bool HasChild()
        {
            return _parentQuery.HasLookupChild(this.Number);
        }

        public bool Success()
        {
            return _success;
        }

        public IFieldNavigator Field
        {
            get
            {
                return this;
            }
        }

        public IQuery Child
        {
            get
            {
                IQuery child;
                _parentQuery.GetLookupChild(this._fieldName, out child);
                return child;
            }
            set
            {
                _parentQuery.SetLookupChild(_fieldName, value);
            }
        }

        public string Name
        {
            get
            {
                return _fieldName;
            }
            set
            {
                _fieldName = value;
                this.Refresh();
            }
        }

        public long Number
        {
            get
            {
                return _fieldNumber;
            }
            set
            {
                if ((value >= 1) & (value <= this.Count))
                {
                    _fieldNumber = value;
                    this.Refresh();
                    _success = true;
                }
                else
                {
                    _success = false; 
                }
            }
        }

        public long Count
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

        public IFieldNavigator Select()
        {
            throw new NotImplementedException();
        }

        public IFieldNavigator Select(long position)
        {
            this.Number = position;
            return this;
        }

        public IFieldNavigator Select(string Name)
        {
            if (ParentQuery.FieldExists(Name))
            {
                this.Number = ParentQuery.GetNamedField(Name);
                _success = true;
            }
            else
            {
                _success = false;
            }

            return this;
        }

        public IFieldNavigator Previous()
        {
            if (this.Number > 1)
            {
                this._success = true;
                this.Number++;
            }
            else
            {
                this._success = false;
            }
            return this;
        }

        public IFieldNavigator Next()
        {
            if (this.Number < this.Count)
            {
                this._success = true;
                this.Number++;
            }
            else
            {
                this._success = false;
            }
            return this;
        }

        public IFieldNavigator FindIncomplete()
        {
            this.FindIncomplete(true);
            return this;
        }

        public IFieldNavigator FindIncomplete(bool updateOnly)
        {
            _parentRecordNavigator.FindIncomplete(updateOnly);

            return this;
        }

        public IFieldNavigator FindIncompleteField()
        {
            _success = false;
            long nextcol = ParentQuery.FindIncompleteField();
            if (nextcol >= 1)
            {
                if (nextcol != this.Number)
                {
                    this.Number = nextcol;
                }
            }

            return this;
        }

        public IFieldNavigator this[string FieldName]
        {
            get
            {
                this.Name = FieldName;
                return this;
            }
            set
            {
                this.Name = FieldName;
                if (_success)
                {
                    this.Value = value.Value;
                }
            }
        }

        public IFieldNavigator this[long FieldNumber]
        {
            get
            {
                this.Number = FieldNumber;
                return this;
            }
            set
            {
                this.Number = FieldNumber;
                if (_success)
                {
                    this.Value = value.Value;
                }
            }
        }

        ///TODOS ///
        ///

        public IQuery Link
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

        public IFieldValue Value
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

        public bool Refresh()
        {
            throw new NotImplementedException();
        }
        
        public bool Receive(INotify Source, string Event)
        {
            throw new NotImplementedException();
        }

        public bool Receive(INotify Source, IEvent Event)
        {
            throw new NotImplementedException();
        }

        public bool Subscribe(ISubscribe Subscriber, string Eventname)
        {
            return _subscribers.Subscribe(Subscriber, Eventname);
        }

        public bool HasLink()
        {
            throw new NotImplementedException();
        }
    }
}