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
    public interface IConnection : IChild, IFramework
    {
        // Connection Parameters //
        IParameterManager Parameter { get; set; }

        // Connection Queries //

        IQueryManager Query { get; set; }

        // Diagnostics //

        IDiagnosticManager Request { get; }

        IDiagnosticManager Link { get; }

        // SubscriptionManager //


        // Connection Actions //

        Boolean Open();

        Boolean CommitTransaction();

        Boolean Commit();

        Boolean RollbackTransaction();

        Boolean Rollback();

        Boolean Close();

        // Advising Subscribed Queries of Actions//

        Boolean AdviseCommit();

        Boolean AdviseRollback();

        Boolean AdviseClose();

        long ObjectCommit( ISubscribe Objector );

        long ObjectRollback(ISubscribe Objector);

        long ObjectClose(ISubscribe Objector);

        Boolean AdviseUpdate();

        long ObjectUpdate(ISubscribe Objector);

        Boolean RequestUpdate();

        Boolean AdviseCancel();

        long ObjectCancel(ISubscribe Objector);

        Boolean RequestCancel();

        Boolean AdviseAction(string EventName);

        Boolean AdviseAction(IEvent Event);

        long ObjectAction(ISubscribe Objector);

        Boolean RequestAction(string EventName);

        Boolean RequestAction(IEvent Event);

        ISubsciberList Objectors { get; set; }

        long ObjectionCount { get; set;  }
             
        // Access to Implementation //

        Object Implementation { get; set; }

        string InitialiseConnectionImplementation();
    }
}