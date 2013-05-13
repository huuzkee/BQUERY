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
//***  CLASS:       ConnectionBase                                                                                  ***//
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
//***  [1]  A constructur configuring:  _framework, _parent,  _parameterManager,  _queryManager, _implementation;   ***//
//***  [2]  Implement public bool Open()                                                                            ***//
//***  [3]  Implement public bool Close()                                                                           ***//
//***  [4]  Implement public bool Commit()                                                                          ***//
//***  [5]  Implement public bool Rollback()                                                                        ***//        
//***                                                                                                               ***//
//***                                                                                                               ***//
//***===============================================================================================================***//
//***    QA Status       |   QA Date      |  QA Comments                                                            ***//
//***---------------------------------------------------------------------------------------------------------------***//
//***    REVIEW          |   16/04/2013   |                                                                         ***//
//***===============================================================================================================***//
//*********************************************************************************************************************//
//*********************************************************************************************************************//

using System;
using System.Linq;

namespace BQUERY.BASE
{
    public class ConnectionBase : IConnection
    {
        string _framework = "BASE";
        object _parent;
        IParameterManager _parameterManager ;
        IQueryManager _queryManager;
        IDiagnosticManager _diagnosticManager;
        ISubsciberList _objectors;
        object _implementation;
        long _objectionCount;


        public ConnectionBase()
        {

            _objectionCount = 0 ;
        }
        public ConnectionBase( object obj )
        {

            _objectionCount = 0;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool sendAdviseEventMsg(string EventName)
        {
            if (_objectors != null)
            {
                _objectors = new SubscriberListBase();
            }

            if (_objectors.Count() > 0)
            {
                _objectors = new SubscriberListBase();
            }

            _objectionCount = 0;

            if (_queryManager.Receive((this as INotify), EventName))
            {
                if (_objectionCount == 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public  bool sendAdviseEventMsg(IEvent Event)
        {
            if (_objectors != null)
            {
                _objectors = new SubscriberListBase();
            }

            if (_objectors.Count() > 0)
            {
                _objectors = new SubscriberListBase();
            }

            _objectionCount = 0;

            if (_queryManager.Receive((this as INotify), Event))
            {
                if (_objectionCount == 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public  long registerObjection(ISubscribe Objector)
        {
            _objectors.Add(Objector) ;
            _objectionCount = _objectors.Count();

            return _objectionCount ;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IParameterManager Parameter
        {
            get
            {
                return _parameterManager ;
            }
            set
            {
                _parameterManager = value ;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public virtual IQueryManager Query
        {
            get
            {
                return _queryManager;
            }
            set
            {
                _queryManager = value ;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IDiagnosticManager Request
        {
            get
            {
                return _diagnosticManager;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IDiagnosticManager Link
        {
            get
            {
                return _diagnosticManager;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public virtual object Implementation
        {
            get
            {
                return _implementation;
            }

                        set
            {
                _implementation = value ;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public virtual object Parent
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
        public bool RollbackTransaction()
        {
            return Rollback();
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool CommitTransaction()
        {
            return Commit();
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool AdviseCommit()
        {
            if (sendAdviseEventMsg("BQ_AdviseCommit"))
            {
                this.Commit();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool AdviseRollback()
        {
            if (sendAdviseEventMsg("BQ_AdviseRollback"))
            {
                this.Commit();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool AdviseClose()
        {
            if (sendAdviseEventMsg("BQ_AdviseClose"))
            {
                this.Commit();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public long ObjectCommit(ISubscribe Objector)
        {
            return registerObjection(Objector);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public long ObjectRollback(ISubscribe Objector)
        {
            return registerObjection(Objector);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public long ObjectClose(ISubscribe Objector)
        {
            return registerObjection(Objector);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool AdviseUpdate()
        {
            return sendAdviseEventMsg("BQ_AdviseUpdate");
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public long ObjectUpdate(ISubscribe Objector)
        {
            return registerObjection(Objector);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool RequestUpdate()
        {
            return sendAdviseEventMsg("BQ_RequestUpdate");
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool AdviseCancel()
        {
            return sendAdviseEventMsg("BQ_AdviseCancel");
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public long ObjectCancel(ISubscribe Objector)
        {
            return registerObjection(Objector);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool RequestCancel()
        {
            return sendAdviseEventMsg("BQ_RequestCancel");
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool AdviseAction(string EventName)
        {
            return sendAdviseEventMsg(EventName);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool AdviseAction(IEvent Event)
        {
            return sendAdviseEventMsg(Event);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public long ObjectAction(ISubscribe Objector)
        {
            return registerObjection(Objector);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool RequestAction(string EventName)
        {
            return sendAdviseEventMsg(EventName);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool RequestAction(IEvent Event)
        {
            return sendAdviseEventMsg(Event);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public ISubsciberList Objectors
        {
            get
            {
                return _objectors;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public long ObjectionCount
        {
            get
            {
                return _objectionCount;
            }

                        set
            {
                _objectionCount =value ;
            }
        }

        // TODO >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>//

        // [1] ImplementA CONSTRUCTOR METHOD CALLING THIS.INITIALISE();                     //
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        // .. ///

        // [2] Implement Open() using the connection implementation api                     //
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool Open()
        {
            throw new NotImplementedException();
        }

        // [3] Implement Close() using the connection implementation api                     //
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool Close()
        {
            throw new NotImplementedException();
        }

        // [4] Implement Commit() using the connection implementation api                   //
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public virtual bool Commit()
        {
            throw new NotImplementedException();
        }

        // [5] Implement Rollback() using the connection implementation api                 //
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public virtual bool Rollback()
        {
            throw new NotImplementedException();
        }
        // TODO <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<//


        ISubsciberList IConnection.Objectors
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





        public string InitialiseConnectionImplementation()
        {
            return "NO INITIALISATION IMPLEMENTED";
        }
    }
}