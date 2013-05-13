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
    public class LibraryManagerBase : ILibraryManager
    {
        string _framework = "BASE";
        object _parent;

        ILibrary _defaultLibrary;
        string _defaultLibraryName;
                
        public ILibrary this[string LibName]
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

        public ILibraryIterator Iterator()
        {
            throw new NotImplementedException();
        }

        public ILibrary Register(string Name, string LibFile)
        {
            throw new NotImplementedException();
        }

        public ILibrary UnRegister(string Name, string LibFile)
        {
            throw new NotImplementedException();
        }

        public ILibrary Create(string Name, string LibFile)
        {
            throw new NotImplementedException();
        }

        public ILibrary Delete(string Name)
        {
            throw new NotImplementedException();
        }

 
        public object Parent
        {
            get
            {
                return _parent;
            }
        }

        public string Framework
        {
            get
            {
                return _framework;
            }
        }


        public ILibrary Select(string Name)
        {
            throw new NotImplementedException();
        }

        public ILibrary Select()
        {
            return _defaultLibrary;
        }

        public ILibrary DefaultLibrary
        {
            get
            {
                return _defaultLibrary;
            }
            set
            {
                _defaultLibrary = value ;
            }
        }

        public String DefaultLibraryName
        {
            get
            {
                return _defaultLibraryName;
            }
            set
            {
                _defaultLibraryName = value;
            }
        }


    }
}