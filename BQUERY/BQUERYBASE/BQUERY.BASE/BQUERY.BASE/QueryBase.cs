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
    public class QueryBase : IQuery
    {
        string _framework = "BASE";
        object _parent;



        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <value>The parent.</value>
        public object Parent
        {
            get
            {
                return _parent; ;
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
                return _framework;
            }
        }

        /// <summary>
        /// ....
        /// </summary>
        /// <value>...</value>
        public eFieldType FieldTypeTranslator(string type)
        {
            if (type == "Number")
            {
                return eFieldType.Number;
            }
            else if (type == "String")
            {
                return eFieldType.String;
            }
            else if (type == "Decimal")
            {
                return eFieldType.Decimal;
            }
            else if (type == "BLOB")
            {
                return eFieldType.BLOB;
            }
            else if (type == "Date")
            {
                return eFieldType.Date;
            }
            else if (type == "DateTime")
            {
                return eFieldType.DateTime;
            }
            else if (type == "Time")
            {
                return eFieldType.Time;
            }
            else
            {
                return eFieldType.Unknown;
            }
        }






        public bool isTable
        {
            get { throw new NotImplementedException(); }
        }

        public bool supportsTableData
        {
            get { throw new NotImplementedException(); }
        }

        public long Count(eFieldStatus Buffer)
        {
            throw new NotImplementedException();
        }

        public long Count(eRecordBuffer Buffer)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            throw new NotImplementedException();
        }

        public long RecordCount
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

        public long GetRecordID(eRecordBuffer Buffer, long pos)
        {
            throw new NotImplementedException();
        }

        public long GetRecordNumberFromRecordID(long recordId)
        {
            throw new NotImplementedException();
        }

        public bool Reset()
        {
            throw new NotImplementedException();
        }

        public IQuery Delete(long pos)
        {
            throw new NotImplementedException();
        }

        public IQuery Insert(long pos)
        {
            throw new NotImplementedException();
        }

        public long NoOfDeletedRecords()
        {
            throw new NotImplementedException();
        }

        public long NoOfFilteredRecords()
        {
            throw new NotImplementedException();
        }

        public long NoOfModifiedRecords()
        {
            throw new NotImplementedException();
        }

        public bool canCopy
        {
            get { throw new NotImplementedException(); }
        }

        public bool CopyRange(eRecordBuffer SourceBuffer, long Start, long End, IQuery Target, eRecordBuffer TargetBuffer, long InsertPos)
        {
            throw new NotImplementedException();
        }

        public bool canFilter
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery Filter()
        {
            throw new NotImplementedException();
        }

        public IQuery SetFilter()
        {
            throw new NotImplementedException();
        }

        public bool supportsDictionary
        {
            get { throw new NotImplementedException(); }
        }

        public IFieldValue GetField(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public bool GetField(eRecordBuffer Buffer, long Record, string Field, bool Original, IFieldValue Value)
        {
            throw new NotImplementedException();
        }

        public DateTime GetFieldDate(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public DateTime GetFieldTime(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public DateTime GetFieldDateTime(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public decimal GetFieldDecimal(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public double GetFieldNumber(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public decimal GetFieldString(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public decimal GetFieldStringFormatted(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public decimal GetFieldStringRaw(eRecordBuffer Buffer, long Record, string Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public eFieldStatus GetFieldStatus(eRecordBuffer Buffer, long Record, string Field)
        {
            throw new NotImplementedException();
        }

        public bool SetField(eRecordBuffer Buffer, long Record, string Field, bool Original, IFieldValue Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldDate(eRecordBuffer Buffer, long Record, string Field, bool Original, DateTime Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldTime(eRecordBuffer Buffer, long Record, string Field, bool Original, DateTime Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldDateTime(eRecordBuffer Buffer, long Record, string Field, bool Original, DateTime Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldDecimal(eRecordBuffer Buffer, long Record, string Field, bool Original, decimal Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldNumber(eRecordBuffer Buffer, long Record, string Field, bool Original, double Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldString(eRecordBuffer Buffer, long Record, string Field, bool Original, string Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldStatus(eRecordBuffer Buffer, long Record, string Field, eFieldStatus status)
        {
            throw new NotImplementedException();
        }

        public bool canMove
        {
            get { throw new NotImplementedException(); }
        }

        public bool MoveRange(eRecordBuffer SourceBuffer, long Start, long End, IQuery Target, eRecordBuffer TargetBuffer, long InsertPos)
        {
            throw new NotImplementedException();
        }

        public bool canSearch
        {
            get { throw new NotImplementedException(); }
        }

        public long Search(string expression, long Start, long End)
        {
            throw new NotImplementedException();
        }

        public long SearchNext()
        {
            throw new NotImplementedException();
        }

        public bool canSort
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery SetSortExpression(string SortExpression)
        {
            throw new NotImplementedException();
        }

        public IQuery Sort()
        {
            throw new NotImplementedException();
        }

        public bool canValidate
        {
            get { throw new NotImplementedException(); }
        }

        public string GetValidationRule(long field)
        {
            throw new NotImplementedException();
        }

        public string GetValidationRule(string field)
        {
            throw new NotImplementedException();
        }

        public bool SetValidationRule(long column, string rule)
        {
            throw new NotImplementedException();
        }

        public bool SetValidationRule(string column, string rule)
        {
            throw new NotImplementedException();
        }

        public bool canCompletionCheck
        {
            get { throw new NotImplementedException(); }
        }

        public bool FindIncomplete(eRecordBuffer Buffer, long Record, long Field, string FieldName, bool UpdateOnly)
        {
            throw new NotImplementedException();
        }

        public long FindIncompleteField()
        {
            throw new NotImplementedException();
        }

        public long FindIncompleteRecord()
        {
            throw new NotImplementedException();
        }

        public bool canCheckModification
        {
            get { throw new NotImplementedException(); }
        }

        public long GetNextModifiedRecord(eRecordBuffer Buffer, long Record)
        {
            throw new NotImplementedException();
        }

        public bool supportsGrid
        {
            get { throw new NotImplementedException(); }
        }

        public IFieldValue GetField(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public bool GetField(eRecordBuffer Buffer, long Record, long Field, bool Original, IFieldValue Value)
        {
            throw new NotImplementedException();
        }

        public DateTime GetFieldDate(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public DateTime GetFieldTime(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public DateTime GetFieldDateTime(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public decimal GetFieldDecimal(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public double GetFieldNumber(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public string GetFieldString(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public string GetFieldStringFormatted(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public string GetFieldStringRaw(eRecordBuffer Buffer, long Record, long Field, bool Original)
        {
            throw new NotImplementedException();
        }

        public eFieldStatus GetFieldStatus(eRecordBuffer Buffer, long Record, long Field)
        {
            throw new NotImplementedException();
        }

        public bool SetField(eRecordBuffer Buffer, long Record, long Field, bool Original, IFieldValue Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldDate(eRecordBuffer Buffer, long Record, long Field, bool Original, DateTime Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldTime(eRecordBuffer Buffer, long Record, long Field, bool Original, DateTime Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldDateTime(eRecordBuffer Buffer, long Record, long Field, bool Original, DateTime Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldDecimal(eRecordBuffer Buffer, long Record, long Field, bool Original, decimal Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldNumber(eRecordBuffer Buffer, long Record, long Field, bool Original, double Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldString(eRecordBuffer Buffer, long Record, long Field, bool Original, string Value)
        {
            throw new NotImplementedException();
        }

        public bool SetFieldStatus(eRecordBuffer Buffer, long Record, long Field, eFieldStatus status)
        {
            throw new NotImplementedException();
        }

        public bool canNavigate
        {
            get { throw new NotImplementedException(); }
        }

        public IRecordNavigator Record
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

        public bool canTruncate
        {
            get { throw new NotImplementedException(); }
        }

        public bool Truncate(long Start, long End, eRecordBuffer Buffer)
        {
            throw new NotImplementedException();
        }

        public bool Truncate(eRecordBuffer Buffer)
        {
            throw new NotImplementedException();
        }

        public bool Truncate(long Start, long End)
        {
            throw new NotImplementedException();
        }

        public bool Truncate()
        {
            throw new NotImplementedException();
        }

        public bool supportsBinding
        {
            get { throw new NotImplementedException(); }
        }

        public bool canBindObject
        {
            get { throw new NotImplementedException(); }
        }

        public bool canBindCollection
        {
            get { throw new NotImplementedException(); }
        }

        public bool supportsSources
        {
            get { throw new NotImplementedException(); }
        }

        public bool canExport
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery Export(string File, eFileFormat Format, eTextEncoding Encoding, bool withHeaders)
        {
            throw new NotImplementedException();
        }

        public IQuery ExportFormattedText(string File)
        {
            throw new NotImplementedException();
        }

        public IQuery ExportFormattedText(string File, eFileFormat Encoding, string separatorChar, string quoteChar, string lineTerminatorChar, bool keepLineFeeds)
        {
            throw new NotImplementedException();
        }

        public IQuery ExportText(string File)
        {
            throw new NotImplementedException();
        }

        public IQuery ExportText(string File, string separatorChar, string quoteChar, string lineTerminatorChar)
        {
            throw new NotImplementedException();
        }

        public IQuery ExportResultSet(object RSet)
        {
            throw new NotImplementedException();
        }

        public object ExportResultSet(object RSet, eRecordBuffer Buffer)
        {
            throw new NotImplementedException();
        }

        public bool canImport
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery Import(string File, eFileFormat Format)
        {
            throw new NotImplementedException();
        }

        public IQuery Import(string File, eFileFormat Format, long startrow, long endrow, long startcol, long endcol, long insertafter)
        {
            throw new NotImplementedException();
        }

        public IQuery ImportString(string Content, eFileFormat Format)
        {
            throw new NotImplementedException();
        }

        public IQuery ImportString(string Content, eFileFormat Format, long startrow, long endrow, long startcol, long endcol, long insertafter)
        {
            throw new NotImplementedException();
        }

        public bool canShare
        {
            get { throw new NotImplementedException(); }
        }

        public bool ShareData(IQuery Target)
        {
            throw new NotImplementedException();
        }

        public bool ShareDataOff()
        {
            throw new NotImplementedException();
        }

        public bool canRemote
        {
            get { throw new NotImplementedException(); }
        }

        public byte[] GetChanges()
        {
            throw new NotImplementedException();
        }

        public object GetChangesObject()
        {
            throw new NotImplementedException();
        }

        public byte[] SetChanges()
        {
            throw new NotImplementedException();
        }

        public object SetChangesObject()
        {
            throw new NotImplementedException();
        }

        public byte[] SetQueryImage()
        {
            throw new NotImplementedException();
        }

        public object SetQueryImageObject()
        {
            throw new NotImplementedException();
        }

        public byte[] GetQueryImage()
        {
            throw new NotImplementedException();
        }

        public object GetQueryImageObject()
        {
            throw new NotImplementedException();
        }

        public bool isObservable
        {
            get { throw new NotImplementedException(); }
        }

        public bool isObserver
        {
            get { throw new NotImplementedException(); }
        }

        public bool canMap
        {
            get { throw new NotImplementedException(); }
        }

        public bool canMapFormat
        {
            get { throw new NotImplementedException(); }
        }

        public bool canMapQuery
        {
            get { throw new NotImplementedException(); }
        }

        public bool canMapObject
        {
            get { throw new NotImplementedException(); }
        }

        public bool supportsTableMetadata
        {
            get { throw new NotImplementedException(); }
        }

        public bool FieldExists(long Field)
        {
            throw new NotImplementedException();
        }

        public long FieldCount
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

        public string GetFieldName(long pos)
        {
            throw new NotImplementedException();
        }

        public long GetNamedField(string field)
        {
            throw new NotImplementedException();
        }

        public string FieldTypeNameTranslator(string rawtype)
        {
            throw new NotImplementedException();
        }

        public string FieldTypeNameRaw(long pos)
        {
            throw new NotImplementedException();
        }

        public string FieldTypeName(long pos)
        {
            throw new NotImplementedException();
        }

        public eFieldType FieldType(long pos)
        {
            throw new NotImplementedException();
        }

        public string FieldTypeNameRaw(string field)
        {
            throw new NotImplementedException();
        }

        public bool FieldExists(string Field)
        {
            throw new NotImplementedException();
        }

        public string FieldTypeName(string field)
        {
            throw new NotImplementedException();
        }

        public eFieldType FieldType(string field)
        {
            throw new NotImplementedException();
        }

        public bool supportsEvents
        {
            get { throw new NotImplementedException(); }
        }

        public bool TriggerEvent(string eventName, long Arg01, long Arg02)
        {
            throw new NotImplementedException();
        }

        public bool isService
        {
            get { throw new NotImplementedException(); }
        }

        public long ErrorCode
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

        public bool canConnect
        {
            get { throw new NotImplementedException(); }
        }

        public IConnection Connection
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

        public object GetConnectionImplementation()
        {
            throw new NotImplementedException();
        }

        public bool SetConnectionImplementation(object implemention)
        {
            throw new NotImplementedException();
        }

        public bool canRequest
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery Submit()
        {
            throw new NotImplementedException();
        }

        public bool canBindParameters
        {
            get { throw new NotImplementedException(); }
        }

        public bool canUpdate
        {
            get { throw new NotImplementedException(); }
        }

        public bool ClearUpdateFlags()
        {
            throw new NotImplementedException();
        }

        public IQuery Update()
        {
            throw new NotImplementedException();
        }

        public bool canCancel
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery CancelRequest()
        {
            throw new NotImplementedException();
        }

        public bool canRefresh
        {
            get { throw new NotImplementedException(); }
        }

        public bool RefreshResult()
        {
            throw new NotImplementedException();
        }

        public bool canSupportSQL
        {
            get { throw new NotImplementedException(); }
        }

        public bool SetSQLPreview(string statement)
        {
            throw new NotImplementedException();
        }

        public bool SetSQLSelect(string statement)
        {
            throw new NotImplementedException();
        }

        public string GetSQLQuery()
        {
            throw new NotImplementedException();
        }

        public bool canSupportWebService
        {
            get { throw new NotImplementedException(); }
        }

        public bool canSupportREST
        {
            get { throw new NotImplementedException(); }
        }

        public bool supportsReportLookup
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery GetLookupChild(string name, out IQuery Child)
        {
            throw new NotImplementedException();
        }

        public IQuery SetLookupChild(string name, IQuery Child)
        {
            throw new NotImplementedException();
        }

        public bool HasLookupChild(long pos)
        {
            throw new NotImplementedException();
        }

        public bool HasLookupChild(string field)
        {
            throw new NotImplementedException();
        }

        public bool supportsReportComposite
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery GetCompositeChild(string name, out IQuery Child)
        {
            throw new NotImplementedException();
        }

        public IQuery SetCompositeChild(string name, IQuery Child)
        {
            throw new NotImplementedException();
        }

        public bool HasCompositeChild(string childname)
        {
            throw new NotImplementedException();
        }

        public bool isReportNested
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery GetNestedChild(string name, out IQuery Child)
        {
            throw new NotImplementedException();
        }

        public IQuery SetNestedChild(string name, IQuery Child)
        {
            throw new NotImplementedException();
        }

        public bool HasNestedChild(string childname)
        {
            throw new NotImplementedException();
        }

        public bool canFormat
        {
            get { throw new NotImplementedException(); }
        }

        public string GetFormat(long Field)
        {
            throw new NotImplementedException();
        }

        public string GetFormat(string Field)
        {
            throw new NotImplementedException();
        }

        public bool SetFormat(long Field, string Format)
        {
            throw new NotImplementedException();
        }

        public bool SetFormat(string Field, string Format)
        {
            throw new NotImplementedException();
        }

        public bool canGroup
        {
            get { throw new NotImplementedException(); }
        }

        public bool Group()
        {
            throw new NotImplementedException();
        }

        public long NextGroupBreak(long row, long level)
        {
            throw new NotImplementedException();
        }

        public bool isBanded
        {
            get { throw new NotImplementedException(); }
        }

        public bool canPrint
        {
            get { throw new NotImplementedException(); }
        }

        public bool Print(bool ShowPrintDialog, bool ShowCancelDialog)
        {
            throw new NotImplementedException();
        }

        public bool Print()
        {
            throw new NotImplementedException();
        }

        public bool PrintCancel()
        {
            throw new NotImplementedException();
        }

        public bool supportsReportMetadata
        {
            get { throw new NotImplementedException(); }
        }

        public bool SetAttribute(string Value, string Property)
        {
            throw new NotImplementedException();
        }

        public bool SetAttribute(string Value, string Property, string TemplateItem)
        {
            throw new NotImplementedException();
        }

        public bool SetAttribute(string Value, string Property, string TemplateItem, string Component)
        {
            throw new NotImplementedException();
        }

        public bool SetAttribute(string Value, string Property, string TemplateItem, string Component, string SubComponent)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string Property)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string Property, string TemplateItem)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string Property, string TemplateItem, string Component)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string Property, string TemplateItem, string Component, string SubComponent)
        {
            throw new NotImplementedException();
        }

        public bool SetBandAttribute(string Value, string Property, string Band, long Level)
        {
            throw new NotImplementedException();
        }

        public string GetBandAttribute(string Property, string Band, long Level)
        {
            throw new NotImplementedException();
        }

        public string GetBands()
        {
            throw new NotImplementedException();
        }

        public string[] GetBandList()
        {
            throw new NotImplementedException();
        }

        public bool canLink
        {
            get { throw new NotImplementedException(); }
        }

        public bool canReference
        {
            get { throw new NotImplementedException(); }
        }

        public bool canAggregate
        {
            get { throw new NotImplementedException(); }
        }

        public bool canProject
        {
            get { throw new NotImplementedException(); }
        }

        public bool isComposite
        {
            get { throw new NotImplementedException(); }
        }

        public long TableCount
        {
            get { throw new NotImplementedException(); }
        }

        public string GetTableName(long Table)
        {
            throw new NotImplementedException();
        }

        public long GetTableNumber(string Table)
        {
            throw new NotImplementedException();
        }

        public bool TableExists(string Table)
        {
            throw new NotImplementedException();
        }

        public eQueryComposite CompositeType
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

        public long CompositeChildCount
        {
            get { throw new NotImplementedException(); }
        }

        public eQueryComposite GetChildQueryCompositeType(long pos)
        {
            throw new NotImplementedException();
        }

        public IQComposite GetChildQueryComposite(long pos)
        {
            throw new NotImplementedException();
        }

        public IQCJoin GetChildQueryJoin(long pos)
        {
            throw new NotImplementedException();
        }

        public IQCUnion GetChildQueryUnion(long pos)
        {
            throw new NotImplementedException();
        }

        public IQCTree GetChildQueryTree(long pos)
        {
            throw new NotImplementedException();
        }

        public bool MakeTableUpdateable(long pos)
        {
            throw new NotImplementedException();
        }

        public string[] GetTablePrimaryKeys(long pos)
        {
            throw new NotImplementedException();
        }

        public string[] GetTablePrimaryKeys(string TableName)
        {
            throw new NotImplementedException();
        }

        public bool isJoin
        {
            get { throw new NotImplementedException(); }
        }

        public bool isUnion
        {
            get { throw new NotImplementedException(); }
        }

        public bool isTree
        {
            get { throw new NotImplementedException(); }
        }

        public bool isDocument
        {
            get { throw new NotImplementedException(); }
        }

        public eQueryDocumentType getDocumentType()
        {
            throw new NotImplementedException();
        }

        public string GetDocumentMediaFormat()
        {
            throw new NotImplementedException();
        }

        public bool isText
        {
            get { throw new NotImplementedException(); }
        }

        public long DocumentFind(string expression, long Start, long End)
        {
            throw new NotImplementedException();
        }

        public long DocumentFindNext()
        {
            throw new NotImplementedException();
        }

        public long InsertDocument(string File, bool Replace, eTextFileType FileType)
        {
            throw new NotImplementedException();
        }

        public bool InsertDocumentContent(string Content, eTemplateBand Band, eTextFileType FileType)
        {
            throw new NotImplementedException();
        }

        public string TextDocumentContent
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

        public string TextDocumentEncoding
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

        public bool isVideo
        {
            get { throw new NotImplementedException(); }
        }

        public byte[] VideoDocumentBinary
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

        public bool isImage
        {
            get { throw new NotImplementedException(); }
        }

        public byte[] ImageDocumentBinary
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

        public bool isAudio
        {
            get { throw new NotImplementedException(); }
        }

        public byte[] AudioDocumentBinary
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

        public bool isBinary
        {
            get { throw new NotImplementedException(); }
        }

        public byte[] BinaryDocumentContent
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

        public bool isDirectory
        {
            get { throw new NotImplementedException(); }
        }

        public bool canBuild
        {
            get { throw new NotImplementedException(); }
        }

        public IQuery Create(string TemplateName, string HostName)
        {
            throw new NotImplementedException();
        }

        public IQuery Create(string TemplateName)
        {
            throw new NotImplementedException();
        }

        public IQuery Create(ITemplate Template, IHost Host)
        {
            throw new NotImplementedException();
        }

        public IQuery Create(ITemplate Template)
        {
            throw new NotImplementedException();
        }

        public bool canBuildTemplate
        {
            get { throw new NotImplementedException(); }
        }

        public ITemplate Template
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

        public IHost BuildTemplate(eBuildScript ScriptType, string BuildScript, object ImplementationObject)
        {
            throw new NotImplementedException();
        }

        public IHost BuildTemplate(eBuildScript ScriptType, string BuildScript)
        {
            throw new NotImplementedException();
        }

        public IHost BuildTemplate(object ADOResultSet)
        {
            throw new NotImplementedException();
        }

        public string TemplateSyntax
        {
            get { throw new NotImplementedException(); }
        }

        public string RequestSyntax
        {
            get { throw new NotImplementedException(); }
        }

        public string UpdateSyntax
        {
            get { throw new NotImplementedException(); }
        }

        public bool canModifyTemplate
        {
            get { throw new NotImplementedException(); }
        }

        public string DescribeTemplateProperties(string propertyList)
        {
            throw new NotImplementedException();
        }

        public bool ModifyTemplateProperty(string Request)
        {
            throw new NotImplementedException();
        }

        public bool supportsTemplateRepository
        {
            get { throw new NotImplementedException(); }
        }

        public ITemplate LoadTemplate(string Name)
        {
            throw new NotImplementedException();
        }

        public bool StoreTemplate(string Name, ITemplate Template)
        {
            throw new NotImplementedException();
        }

        public bool StoreTemplate(string Name)
        {
            throw new NotImplementedException();
        }

        public bool OpenTemplateRepository(string AccessParameters)
        {
            throw new NotImplementedException();
        }

        public bool CloseTemplateRepository(string AccessParameters)
        {
            throw new NotImplementedException();
        }

        public bool ValidTemplateRepository
        {
            get { throw new NotImplementedException(); }
        }

        public bool canBuildHost
        {
            get { throw new NotImplementedException(); }
        }

        public IHost Host
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

        public IHost BuildHost(eBuildScript SriptType, string BuildScript, object ImplementationObject)
        {
            throw new NotImplementedException();
        }

        public IHost BuildHost(eBuildScript SriptType, string BuildScript)
        {
            throw new NotImplementedException();
        }

        public bool hasExpressionSupport
        {
            get { throw new NotImplementedException(); }
        }

        public bool supportsImplementation
        {
            get { throw new NotImplementedException(); }
        }

        public bool supportsImplementationAccess
        {
            get { throw new NotImplementedException(); }
        }

        public object HostImplementationObject
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

        public object TemplateImplementationObject
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

        public object ConnectionImplementationObject
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

        public bool Receive(INotify Source, string Event)
        {
            throw new NotImplementedException();
        }

        public bool Receive(INotify Source, IEvent Event)
        {
            throw new NotImplementedException();
        }

        public bool Subscribe(ISubscribe Subscriber, string Eventname)
        {
            throw new NotImplementedException();
        }

        public bool UnSubscribe(ISubscribe Subscriber, string Eventname)
        {
            throw new NotImplementedException();
        }

        public bool Success
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
    }
}
