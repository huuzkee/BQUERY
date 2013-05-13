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
    public class QueryManagerBase : IQueryManager
    {
        string _framework = "BASE";
        object _parent;

        ISubscriptionManager _subscriptions;

        Dictionary<String, IQuery> _queries;
        
        //// INITIALISE ///
        Boolean Initialise()
        {
            _subscriptions = new SubscriptionManagerBase();
            _queries = new Dictionary<String, IQuery>();
            return true;
        }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public object Parent
        {
            get
            {
                return _parent;
            }
        }

        /// <summary>
        /// Gets the framework.
        /// </summary>
        /// <value>The framework.</value>
        public string Framework
        {
            get
            {
                // TODO: Implement this property getter
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Subscribes the specified subscriber.
        /// </summary>
        /// <param name="Subscriber">The subscriber.</param>
        /// <param name="Eventname">The eventname.</param>
        /// <returns></returns>
        public bool Subscribe(ISubscribe Subscriber, string Eventname)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uns the subscribe.
        /// </summary>
        /// <param name="Subscriber">The subscriber.</param>
        /// <param name="Eventname">The eventname.</param>
        /// <returns></returns>
        public bool UnSubscribe(ISubscribe Subscriber, string Eventname)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the default host class.
        /// </summary>
        /// <value>The default host class.</value>
        public string DefaultHostClass
        {
            get
            {
                // TODO: Implement this property getter
                throw new NotImplementedException();
            }
            set
            {
                // TODO: Implement this property setter
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the syntax.
        /// </summary>
        /// <value>The syntax.</value>
        public ISyntaxGenerator Syntax
        {
            get
            {
                // TODO: Implement this property getter
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>The host.</value>
        public IHostManager Host
        {
            get
            {
                // TODO: Implement this property getter
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the template.
        /// </summary>
        /// <value>The template.</value>
        public ITemplateManager Template
        {
            get
            {
                // TODO: Implement this property getter
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="BQUERY.IQuery" /> with the specified name.
        /// </summary>
        /// <value></value>
        public IQuery this[string Name]
        {
            get
            {
                // TODO: Implement this indexer getter
                throw new NotImplementedException();
            }
            set
            {
                // TODO: Implement this indexer setter
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Creates the specified name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="TemplateName">Name of the template.</param>
        /// <returns></returns>
        public IQuery Create(string Name, string TemplateName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the specified name.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="TemplateName">Name of the template.</param>
        /// <param name="HostClassName">Name of the host class.</param>
        /// <returns></returns>
        public IQuery Create(string Name, string TemplateName, string HostClassName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates from result set.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="ADOResultset">The ADO resultset.</param>
        /// <param name="TemplateName">Name of the template.</param>
        /// <returns></returns>
        public IQuery CreateFromResultSet(string Name, object ADOResultset, string TemplateName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates from result set.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="ADOResultset">The ADO resultset.</param>
        /// <param name="TemplateName">Name of the template.</param>
        /// <param name="HostClassName">Name of the host class.</param>
        /// <returns></returns>
        public IQuery CreateFromResultSet(string Name, object ADOResultset, string TemplateName, string HostClassName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates from SQL.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="SQL">The SQL.</param>
        /// <param name="TemplateName">Name of the template.</param>
        /// <returns></returns>
        public IQuery CreateFromSQL(string Name, string SQL, string TemplateName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates from SQL.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="SQL">The SQL.</param>
        /// <param name="TemplateName">Name of the template.</param>
        /// <param name="HostClassName">Name of the host class.</param>
        /// <returns></returns>
        public IQuery CreateFromSQL(string Name, string SQL, string TemplateName, string HostClassName)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Receives the specified source.
        /// </summary>
        /// <param name="Source">The source.</param>
        /// <param name="Event">The event.</param>
        /// <returns></returns>
        public bool Receive(INotify Source, string Event)
        {
            return _subscriptions.Receive(Source, Event);
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
    }
}