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
//***  CLASS:       SubscriptionManagerBase                                                                             ***//
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
    public class SubscriptionManagerBase : ISubscriptionManager
    {
        Dictionary<String, ISubsciberList> _subscriptions;
        bool _strict = false;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SubscriptionManagerBase()
        {
            _subscriptions = new Dictionary<String, ISubsciberList>();
        }

        /// <summary>
        /// Subscribes the specified subscriber.
        /// </summary>
        /// <param name="Subscriber">The subscriber.</param>
        /// <param name="Eventname">The eventname.</param>
        /// <returns></returns>
        public bool Subscribe(ISubscribe Subscriber, string EventName)
        {
            ISubsciberList _subs ;

            if (_subscriptions.TryGetValue(EventName, out _subs))
            {
                _subs.Add(Subscriber);
                return true;
            }
            else 
            { 
                if (StrictMode)
                {
                    return false;
                }
                else
                {
                    AddEvent(EventName);
                    if (_subscriptions.TryGetValue(EventName, out _subs))
                    {
                        _subs.Add(Subscriber);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Uns the subscribe.
        /// </summary>
        /// <param name="Subscriber">The subscriber.</param>
        /// <param name="Eventname">The eventname.</param>
        /// <returns></returns>
        public bool UnSubscribe(ISubscribe Subscriber, string EventName)
        {
            ISubsciberList _subs ;

            if (_subscriptions.TryGetValue(EventName, out _subs))
            {
                _subs.Remove(Subscriber);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Receives the specified source.
        /// </summary>
        /// <param name="Source">The source.</param>
        /// <param name="Event">The event.</param>
        /// <returns></returns>
        public bool Receive(INotify Source, string EventName )
        {
            ISubsciberList _subs;

            if (_subscriptions.TryGetValue(EventName, out _subs))
            {
                return _subs.Receive(Source, EventName );
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Receives the specified source.
        /// </summary>
        /// <param name="Source">The source.</param>
        /// <param name="Event">The event.</param>
        /// <returns></returns>
        public bool Receive(INotify Source, IEvent Event)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Events the exists.
        /// </summary>
        /// <param name="EventName">Name of the event.</param>
        /// <returns></returns>
        public bool EventExists(string EventName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the event.
        /// </summary>
        /// <param name="EventName">Name of the event.</param>
        /// <returns></returns>
        public ISubscriptionManager AddEvent(string EventName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the event.
        /// </summary>
        /// <param name="EventName">Name of the event.</param>
        /// <returns></returns>
        public ISubscriptionManager RemoveEvent(string EventName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes all events.
        /// </summary>
        /// <param name="EventName">Name of the event.</param>
        /// <returns></returns>
        public ISubscriptionManager RemoveAllEvents(string EventName)
        {
            _subscriptions = new Dictionary<String, ISubsciberList>();
            return this;
        }

        /// <summary>
        /// Removes all subscribers.
        /// </summary>
        /// <param name="EventName">Name of the event.</param>
        /// <returns></returns>
        public ISubscriptionManager RemoveAllSubscribers(string EventName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Indicates whether SubcriptionManager allows subscriptions for event not pre registered. Strict mode does not.
        /// </summary>
        public bool StrictMode
        {
            get
            {
                return _strict;
            }
            set
            {
                _strict = value;
            }
        }
    }
}