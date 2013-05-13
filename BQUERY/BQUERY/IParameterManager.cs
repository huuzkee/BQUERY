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
    public interface IParameterManager : IChild, IFramework
    {
        // Connection Attributes //

        String ParameterString { get; set; }            // DBParm 

        String ServerName { get; set; }                 // ServerName

        String ServerAuthCredential { get; set; }       // LogID 

        String ServerAuthToken { get; set; }            // LogPass 

        String ServerClass { get; set; }                // DBMS   

        String ServiceName { get; set; }                // Database  

        String ServiceAuthCredential { get; set; }      // UserID  

        String ServiceAuthToken { get; set; }           // DBPass 

        String LockLevel { get; set; }                  // Lock  

        String AutoCommit { get; set; }                 // AutoCommit

        Object ConnectorProxy { get; set; }             // ADO Object 

        String TemplateSourceLanguage { get; set; } 

        String TemplateLanguage { get; set; } 

        // Request Parameter String // 

        string this[string Parameter] { get; set; }     // Sets Field Values, new fields are added after existing ones

        string this[long Position] { get; set; }        // Set the position of parameters if different from the sequence in which they were set

        IConnection BuildParameterString();



    }
}
