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
//***  [1]  ...                                                                                                     ***//
//***  [2]  ...                                                                                                     ***//
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
    public class DiagnosticManagerBase : IDiagnosticManager
    {
        string _framework = "BASE";
        object _parent;

        Boolean _isActive = false ;
        Dictionary<string, string> _diagnostics ;
        ISubscriptionManager _subscribers;

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>  
        public bool Initialise()
        {
            _diagnostics = new Dictionary<string, string>();
            _subscribers = new SubscriptionManagerBase();

            return true;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;

            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string Status
        {
            get
            {
                return this["Status"];
            }
            set
            {
                this["Status"] = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string ResultCode
        {
            get
            {
                return this["ResultCode"];
            }
            set
            {
                this["ResultCode"] = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string ResultReasonCode
        {
            get
            {
                return this["ResultReasonCode"];
            }
            set
            {
                this["ResultReasonCode"] = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string ErrorMessage
        {
            get
            {
                return this["ErrorMessage"];
            }
            set
            {
                this["ErrorMessage"] = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string RecordCount
        {
            get
            {
                return this["RecordCount"];
            }
            set
            {
                this["RecordCount"] = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string ResultMessage
        {
            get
            {
                return this["ResultMessage"];
            }
            set
            {
                this["ResultMessage"] = value;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string this[string attributeName]
        {
            get
            {
                return this[attributeName];
            }
            set
            {
                this[attributeName] = value;
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
        public bool Receive(INotify Source, string Event)
        {
            return _subscribers.Receive(Source, Event);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool Receive(INotify Source, IEvent Event)
        {
            return _subscribers.Receive(Source, Event);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool Subscribe(ISubscribe Subscriber, string EventName)
        {
            return _subscribers.Subscribe( Subscriber, EventName);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool UnSubscribe(ISubscribe Subscriber, string EventName)
        {
            return _subscribers.Subscribe( Subscriber, EventName);
        }
    }
}