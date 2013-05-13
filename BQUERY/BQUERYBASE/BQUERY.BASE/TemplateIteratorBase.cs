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
//***  CLASS:       TemplateIteratorBase                                                                              ***//
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

namespace BQUERY.BASE
{
    public class TemplateIteratorBase : ITemplateIterator
    {
        string _framework = "BASE";
        object _parent;

        ILibrary _library;

        IEnumerator<ITemplate> _enumerator;

        public ITemplate Current
        {
            get
            {
                return _enumerator.Current;
            }
        }

        public bool Next()
        {
            return _enumerator.MoveNext();
        }

        public bool Empty()
        {
            if (Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            };
        }

        public long Count()
        {
            return _library.TemplatesRegistered();
        }

        public ILibrary Library
        {
            get
            {
                return _library;
            }
            set
            {
                _library = value;
                _parent = (object)value;
                _enumerator = (IEnumerator<ITemplate>)_library.GetEnumerator();
            }
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
    }
}