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
//***  CLASS:       BQueryFrameworkBase                                                                             ***//
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
//***  [1]  A constructur calling the initialise method                                                             ***//
//***  [2]  public IConnection CreateConnection(string ConnectionName, bool isDefault)                              ***//
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
    public class BQueryFrameworkBase : IBQueryFramework
    {
        string _framework = "BASE";
        string _defaultConnectionName = "" ;
        IConnection _defaultConnection ;
        Dictionary<string, IConnection> _connections;

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public bool Initialise()
        {
            _connections = new Dictionary<string, IConnection>();
            return true;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public string DefaultConnection
        {
            get
            {
                return _defaultConnectionName;
            }
            set
            {
                _defaultConnectionName = value;
                _defaultConnection = Connection(_defaultConnectionName);
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IConnection Connection()
        {
            return _defaultConnection;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IConnection Connection(string ConnectionName)
        {
            IConnection conn;
            _connections.TryGetValue(ConnectionName, out conn); 
            return conn ;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IConnection Conn()
        {
            return _defaultConnection;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IConnection Conn(string ConnectionName)
        {
            return Connection(ConnectionName);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IConnection CreateConnection(string ConnectionName)
        {
            return CreateConnection(ConnectionName, true);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IBQueryFramework RegisterConnection(string ConnectionName, IConnection Connection)
        {
            return RegisterConnection(ConnectionName, Connection, true);
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IBQueryFramework RegisterConnection(string ConnectionName, IConnection Connection, bool isDefault)
        {
            _connections.Add(ConnectionName, Connection);
            if (isDefault)
            {
                DefaultConnection = ConnectionName ;
            }
            return this;
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

        // TODO >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>//

        // [1] ImplementA CONSTRUCTOR METHOD CALLING THIS.INITIALISE();                    //
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        // .. ///

        // [2] Implement CreateConnection(...) to use the correct connection implemenation //
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns>
        public IConnection CreateConnection(string ConnectionName, bool isDefault)
        {
            throw new NotImplementedException();
        }
        // TODO <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<//
    }
}