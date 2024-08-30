/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset
{
    #region ICachedRowSet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICachedRowSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getKeyColumns()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setKeyColumns(int[])"/>
        /// </summary>
        int[] KeyColumns { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getOriginal()"/> 
        /// </summary>
        Java.Sql.ResultSet Original { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getOriginalRow()"/> 
        /// </summary>
        Java.Sql.ResultSet OriginalRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getPageSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setPageSize(int)"/>
        /// </summary>
        int PageSize { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getRowSetWarnings()"/> 
        /// </summary>
        Javax.Sql.Rowset.RowSetWarning RowSetWarnings { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getShowDeleted()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setShowDeleted(boolean)"/>
        /// </summary>
        bool ShowDeleted { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getSyncProvider()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setSyncProvider(java.lang.String)"/>
        /// </summary>
        Javax.Sql.Rowset.Spi.SyncProvider SyncProvider { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getTableName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setTableName(java.lang.String)"/>
        /// </summary>
        Java.Lang.String TableName { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#columnUpdated(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool ColumnUpdated(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#columnUpdated(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool ColumnUpdated(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#nextPage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool NextPage();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#previousPage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool PreviousPage();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        int Size();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Util.Collection<object> ToCollection();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Util.Collection<object> ToCollection(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Util.Collection<object> ToCollection(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createShared()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.RowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.RowSet CreateShared();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopy()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.CachedRowSet CreateCopy();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopyNoConstraints()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.CachedRowSet CreateCopyNoConstraints();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopySchema()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.Rowset.CachedRowSet CreateCopySchema();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#acceptChanges()"/>
        /// </summary>
        /// <exception cref="Javax.Sql.Rowset.Spi.SyncProviderException"/>
        void AcceptChanges();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#acceptChanges(java.sql.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Connection"/></param>
        /// <exception cref="Javax.Sql.Rowset.Spi.SyncProviderException"/>
        void AcceptChanges(Java.Sql.Connection arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#commit()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void Commit();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#execute(java.sql.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Connection"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void Execute(Java.Sql.Connection arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#populate(java.sql.ResultSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void Populate(Java.Sql.ResultSet arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#populate(java.sql.ResultSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void Populate(Java.Sql.ResultSet arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#release()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void Release();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#restoreOriginal()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void RestoreOriginal();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rollback()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void Rollback();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rollback(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void Rollback(Java.Sql.Savepoint arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rowSetPopulated(javax.sql.RowSetEvent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void RowSetPopulated(Javax.Sql.RowSetEvent arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setMetaData(javax.sql.RowSetMetaData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetMetaData"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void SetMetaData(Javax.Sql.RowSetMetaData arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setOriginalRow()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void SetOriginalRow();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoDelete()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void UndoDelete();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoInsert()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void UndoInsert();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoUpdate()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void UndoUpdate();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CachedRowSet
    public partial class CachedRowSet : Javax.Sql.Rowset.ICachedRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.CachedRowSet"/> to <see cref="Javax.Sql.RowSet"/>
        /// </summary>
        public static implicit operator Javax.Sql.RowSet(Javax.Sql.Rowset.CachedRowSet t) => t.Cast<Javax.Sql.RowSet>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.CachedRowSet"/> to <see cref="Javax.Sql.Rowset.Joinable"/>
        /// </summary>
        public static implicit operator Javax.Sql.Rowset.Joinable(Javax.Sql.Rowset.CachedRowSet t) => t.Cast<Javax.Sql.Rowset.Joinable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getKeyColumns()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setKeyColumns(int[])"/>
        /// </summary>
        public int[] KeyColumns
        {
            get { return IExecuteWithSignatureArray<int>("getKeyColumns", "()[I"); } set { IExecuteWithSignature("setKeyColumns", "([I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getOriginal()"/> 
        /// </summary>
        public Java.Sql.ResultSet Original
        {
            get { return IExecuteWithSignature<Java.Sql.ResultSet>("getOriginal", "()Ljava/sql/ResultSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getOriginalRow()"/> 
        /// </summary>
        public Java.Sql.ResultSet OriginalRow
        {
            get { return IExecuteWithSignature<Java.Sql.ResultSet>("getOriginalRow", "()Ljava/sql/ResultSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getPageSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setPageSize(int)"/>
        /// </summary>
        public int PageSize
        {
            get { return IExecuteWithSignature<int>("getPageSize", "()I"); } set { IExecuteWithSignature("setPageSize", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getRowSetWarnings()"/> 
        /// </summary>
        public Javax.Sql.Rowset.RowSetWarning RowSetWarnings
        {
            get { var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getRowSetWarnings", "()Ljavax/sql/rowset/RowSetWarning;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Javax.Sql.Rowset.RowSetWarning>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getShowDeleted()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setShowDeleted(boolean)"/>
        /// </summary>
        public bool ShowDeleted
        {
            get { return IExecuteWithSignature<bool>("getShowDeleted", "()Z"); } set { IExecuteWithSignature("setShowDeleted", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getSyncProvider()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setSyncProvider(java.lang.String)"/>
        /// </summary>
        public Javax.Sql.Rowset.Spi.SyncProvider SyncProvider
        {
            get { return IExecuteWithSignature<Javax.Sql.Rowset.Spi.SyncProvider>("getSyncProvider", "()Ljavax/sql/rowset/spi/SyncProvider;"); } set { IExecuteWithSignature("setSyncProvider", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getTableName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setTableName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String TableName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTableName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTableName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#columnUpdated(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool ColumnUpdated(int arg0)
        {
            return IExecuteWithSignature<bool>("columnUpdated", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#columnUpdated(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool ColumnUpdated(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("columnUpdated", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#nextPage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool NextPage()
        {
            return IExecuteWithSignature<bool>("nextPage", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#previousPage()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool PreviousPage()
        {
            return IExecuteWithSignature<bool>("previousPage", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Util.Collection<object> ToCollection()
        {
            return IExecuteWithSignature<Java.Util.Collection<object>>("toCollection", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Util.Collection<object> ToCollection(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<object>>("toCollection", "(I)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Util.Collection<object> ToCollection(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<object>>("toCollection", "(Ljava/lang/String;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createShared()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.RowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.RowSet CreateShared()
        {
            return IExecuteWithSignature<Javax.Sql.RowSet>("createShared", "()Ljavax/sql/RowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopy()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCopy()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.CachedRowSet>("createCopy", "()Ljavax/sql/rowset/CachedRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopyNoConstraints()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCopyNoConstraints()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.CachedRowSet>("createCopyNoConstraints", "()Ljavax/sql/rowset/CachedRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopySchema()"/>
        /// </summary>
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCopySchema()
        {
            return IExecuteWithSignature<Javax.Sql.Rowset.CachedRowSet>("createCopySchema", "()Ljavax/sql/rowset/CachedRowSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#acceptChanges()"/>
        /// </summary>
        /// <exception cref="Javax.Sql.Rowset.Spi.SyncProviderException"/>
        public void AcceptChanges()
        {
            IExecuteWithSignature("acceptChanges", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#acceptChanges(java.sql.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Connection"/></param>
        /// <exception cref="Javax.Sql.Rowset.Spi.SyncProviderException"/>
        public void AcceptChanges(Java.Sql.Connection arg0)
        {
            IExecuteWithSignature("acceptChanges", "(Ljava/sql/Connection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#commit()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Commit()
        {
            IExecuteWithSignature("commit", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#execute(java.sql.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Connection"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Execute(Java.Sql.Connection arg0)
        {
            IExecuteWithSignature("execute", "(Ljava/sql/Connection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#populate(java.sql.ResultSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Populate(Java.Sql.ResultSet arg0, int arg1)
        {
            IExecute("populate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#populate(java.sql.ResultSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Populate(Java.Sql.ResultSet arg0)
        {
            IExecuteWithSignature("populate", "(Ljava/sql/ResultSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#release()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#restoreOriginal()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void RestoreOriginal()
        {
            IExecuteWithSignature("restoreOriginal", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rollback()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback()
        {
            IExecuteWithSignature("rollback", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rollback(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback(Java.Sql.Savepoint arg0)
        {
            IExecuteWithSignature("rollback", "(Ljava/sql/Savepoint;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rowSetPopulated(javax.sql.RowSetEvent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void RowSetPopulated(Javax.Sql.RowSetEvent arg0, int arg1)
        {
            IExecute("rowSetPopulated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setMetaData(javax.sql.RowSetMetaData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetMetaData"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetMetaData(Javax.Sql.RowSetMetaData arg0)
        {
            IExecuteWithSignature("setMetaData", "(Ljavax/sql/RowSetMetaData;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setOriginalRow()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetOriginalRow()
        {
            IExecuteWithSignature("setOriginalRow", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoDelete()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void UndoDelete()
        {
            IExecuteWithSignature("undoDelete", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoInsert()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void UndoInsert()
        {
            IExecuteWithSignature("undoInsert", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoUpdate()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void UndoUpdate()
        {
            IExecuteWithSignature("undoUpdate", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}