
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
    public class LibraryBase : ILibrary
    {
        string _framework = "BASE";
        object _parent;

        string _filename;
        string _name;

        Dictionary<string, ITemplate> _templates;

     


        public string Filename 
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value ;
            }
        }

        public string Name
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



        public ILibrary Load()
        {
            throw new NotImplementedException();
        }

        public ILibrary Load(string Filename)
        {
            throw new NotImplementedException();
        }

        public ITemplate Select(string Name)
        {
            throw new NotImplementedException();
        }

        public ILibrary Register()
        {
            throw new NotImplementedException();
        }

        public ILibrary RegisterAs(string Name)
        {
            throw new NotImplementedException();
        }

        public ILibrary Register(string Name, string AliasName)
        {
            throw new NotImplementedException();
        }

        public ILibrary Register(string Name)
        {
            throw new NotImplementedException();
        }

        public ILibrary RegisterAll()
        {
            ITemplateIterator tIterator = this.FileDirectory();

            do {

                this.Register(tIterator.Current.TemplateName, tIterator.Current.TemplateLibraryName);

            } while (  tIterator.Next()) ;

            return this;
        }

        // TODO //
        public ITemplateIterator Directory()
        {
            throw new NotImplementedException();
        }

        // TODO //
        public ITemplateIterator FileDirectory()
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

        public  Boolean initialiseLibrary()
        {
             _templates = new Dictionary<string, ITemplate>();

             return true;


        }



        public long TemplatesRegistered()
        {
            return _templates.Count();
        }

        public ITemplate this[string Name]
        {
            get
            {
                ITemplate template = null ;
                if (!(_templates.TryGetValue(Name, out template))) { template = null; };
                return template;
            }
            set
            {
                _templates.Add(Name, value);
            }
        }

        public object GetEnumerator()
        {
            return (object)_templates.GetEnumerator();
        }
    }
}