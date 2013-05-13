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
    public class TemplateManagerBase : ITemplateManager
    {
        string _framework = "BASE";
        object _parent;


        ILibraryManager _libaryManager;

        string _defaultLibraryName = "";
        IConnection _defaultLibrary;
        Dictionary<string, ILibrary> _libraries;

        
        public string DefaultLibary
        {
            get
            {
                return _defaultLibraryName ;
            }
            set
            {
                _defaultLibraryName = value ;
            }
        }

        public ILibraryManager Library
        {
            get
            {
                return _libaryManager;
            }
            set
            {
                _libaryManager = value;
            }
        }

        public ITemplate this[string TemplateName]
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

        public ITemplate Create(string Name, string Syntax)
        {
            throw new NotImplementedException();
        }

        public ITemplate Create(string Name, string Syntax, string Libary)
        {
            throw new NotImplementedException();
        }

        public ITemplate Create(string Name, string Syntax, string Libary, string TemplateAlias)
        {
            throw new NotImplementedException();
        }

        public ITemplateManager Destroy(string HostName)
        {
            throw new NotImplementedException();
        }

        public ITemplate Register(string TemplateName, ITemplate Template)
        {
            throw new NotImplementedException();
        }

        public ITemplate Register(string TemplateName)
        {
            throw new NotImplementedException();
        }

        public ITemplate Register(string TemplateName, string TemplateAlias)
        {
            throw new NotImplementedException();
        }

        public ITemplateManager UnRegister(string TemplateName)
        {
            throw new NotImplementedException();
        }

        public ITemplate Select(string HostName)
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


        public object GetEnumerator()
        {
            return (object)_libraries.GetEnumerator();
        }
    }
}