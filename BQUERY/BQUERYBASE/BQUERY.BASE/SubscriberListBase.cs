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
//***  CLASS:       SubscriberListBase                                                                                  ***//
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
//***  [1]  ...                                                                                                     ***//
//***  [2]  ...                                                                                                     ***//
//***                                                                                                               ***//
//***===============================================================================================================***//
//***    QA Status       |   QA Date      |  QA Comments                                                            ***//
//***---------------------------------------------------------------------------------------------------------------***//
//***    WIP          |   16/04/2013   |                                                                         ***//
//***===============================================================================================================***//
//*********************************************************************************************************************//
//*********************************************************************************************************************//

using System;
using System.Collections.Generic;
using System.Linq;

namespace BQUERY.BASE
{
    public class SubscriberListBase : ISubsciberList
    {
        private List<ISubscribe> _subscribers;
        private ISubscribe _current;
        private IEnumerator<ISubscribe> _enumerator;
        private bool _enumeratorInitialised = false;

        public SubscriberListBase()
        {
            _subscribers = new List<ISubscribe>();
            _current = null;
        }

        /// <summary>
        /// Currents this instance.
        /// </summary>
        /// <returns></returns>
        public ISubscribe Current()
        {
            return _current;
        }

        /// <summary>
        /// Firsts this instance.
        /// </summary>
        /// <returns></returns>
        public bool First()
        {
            if (! (Empty())) {
                _enumeratorInitialised = true ;
                _enumerator = _subscribers.GetEnumerator();
                _enumerator.Reset();
                return true ;
            }
            else
            {
                return false ;
            }
        }

        /// <summary>
        /// Moves to the next subscriber in the list
        /// </summary>
        /// <returns></returns>
        public bool Next()
        {
            if (! (_enumeratorInitialised))
            {
                _enumeratorInitialised = true;
                _enumerator = _subscribers.GetEnumerator();
                _enumerator.Reset();
            }

            if (_enumerator.MoveNext())
            {
                _current = _enumerator.Current;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns></returns>
        public bool Empty()
        {
            if (_subscribers.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Adds the specified subscriber.
        /// </summary>
        /// <param name="Subscriber">The subscriber.</param>
        /// <returns></returns>
        public long Add(ISubscribe Subscriber)
        {
            _subscribers.Add(Subscriber);
            _enumeratorInitialised = false;
            return _subscribers.Count();
        }

        /// <summary>
        /// Removes the specified subscriber.
        /// </summary>
        /// <param name="Subscriber">The subscriber.</param>
        /// <returns></returns>
        public long Remove(ISubscribe Subscriber)
        {
            _subscribers.Remove(Subscriber);
            _enumeratorInitialised = false;
            return _subscribers.Count();
        }

        /// <summary>
        /// Counts this instance.
        /// </summary>
        /// <returns></returns>
        public long Count()
        {
            return _subscribers.Count();
        }

        public bool Receive(INotify Source, string Event)
        {
            bool AllReceivedIndicator = true ;

            IEnumerator<ISubscribe> _enum = _subscribers.GetEnumerator();
            _enum.Reset();
            while (_enum.MoveNext())
            {
                if (! (_enum.Current.Receive(Source, Event)))
                {
                    AllReceivedIndicator = false ;
                }
            }
            return AllReceivedIndicator ;
        }

        public bool Receive(INotify Source, IEvent Event)
        {
            bool AllReceivedIndicator = true ;

            IEnumerator<ISubscribe> _enum = _subscribers.GetEnumerator();
            _enum.Reset();
            while (_enum.MoveNext())
            {
                if (! (_enum.Current.Receive(Source, Event)))
                {
                    AllReceivedIndicator = false ;
                }
            }
            return AllReceivedIndicator ;
        }
    }
}