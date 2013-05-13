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
//***  CLASS:       EventBase                                                                                       ***//
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
//***  [1]  ...                                                                                                     ***//
//***  [2]  ..                                                                                                      ***//
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

namespace BQUERY
{
    public class EventBase : IEvent
    {
        string _name;
        Dictionary<string, IFieldValue> _attributes;

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        bool Intialise()
        {
            _attributes = new Dictionary<string, IFieldValue>();
            return true;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public string Name
        {
            get
            {
                return _name ;
            }
            set
            {
                _name = value ;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public IFieldValue this[string AttributeName]
        {
            get
            {
                IFieldValue attribute = null;
                if (!(_attributes.TryGetValue(Name, out attribute)))
                {
                    attribute = null;
                }
                return attribute;
            }
            set
            {
                _attributes.Add(Name, value);
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public long AttributeCount()
        {
            return _attributes.Count();
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="Source">...</param>
        /// <returns>...</returns> 
        public object GetEnumerator()
        {
            return (object)_attributes.GetEnumerator();
        }
    }
}