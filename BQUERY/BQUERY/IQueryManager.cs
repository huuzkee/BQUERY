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
    public interface IQueryManager : IChild, IFramework, ISubscribe, INotify
    {

        String DefaultHostClass { get; set; }

        ISyntaxGenerator Syntax { get; }

        IHostManager Host { get; }

        ITemplateManager Template { get; }


        // Query Dictionary //

        IQuery this[string Name ] { get; set; }     

        // Query Creation //

        IQuery Create(String Name, String TemplateName);

        IQuery Create(String Name, String TemplateName, String HostClassName );

        IQuery CreateFromResultSet(String Name, Object ADOResultset, String TemplateName);

        IQuery CreateFromResultSet(String Name, Object ADOResultset, String TemplateName, String HostClassName);

        IQuery CreateFromSQL(String Name, String SQL, String TemplateName );
    
        IQuery CreateFromSQL(String Name, String SQL, String TemplateName, String HostClassName);

        
 
    }
}
