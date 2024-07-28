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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset
{
    #region RowSetMetaDataImpl
    public partial class RowSetMetaDataImpl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.RowSetMetaDataImpl"/> to <see cref="Javax.Sql.RowSetMetaData"/>
        /// </summary>
        public static implicit operator Javax.Sql.RowSetMetaData(Javax.Sql.Rowset.RowSetMetaDataImpl t) => t.Cast<Javax.Sql.RowSetMetaData>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.RowSetMetaDataImpl"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Sql.Rowset.RowSetMetaDataImpl t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getColumnCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setColumnCount(int)"/>
        /// </summary>
        public int ColumnCount
        {
            get { return IExecuteWithSignature<int>("getColumnCount", "()I"); } set { IExecuteWithSignature("setColumnCount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#unwrap(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public T Unwrap<T>(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<T>("unwrap", "(Ljava/lang/Class;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isAutoIncrement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsAutoIncrement(int arg0)
        {
            return IExecuteWithSignature<bool>("isAutoIncrement", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isCaseSensitive(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsCaseSensitive(int arg0)
        {
            return IExecuteWithSignature<bool>("isCaseSensitive", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isCurrency(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsCurrency(int arg0)
        {
            return IExecuteWithSignature<bool>("isCurrency", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isDefinitelyWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsDefinitelyWritable(int arg0)
        {
            return IExecuteWithSignature<bool>("isDefinitelyWritable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isReadOnly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsReadOnly(int arg0)
        {
            return IExecuteWithSignature<bool>("isReadOnly", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isSearchable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSearchable(int arg0)
        {
            return IExecuteWithSignature<bool>("isSearchable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isSigned(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSigned(int arg0)
        {
            return IExecuteWithSignature<bool>("isSigned", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isWrapperFor(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsWrapperFor(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("isWrapperFor", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsWritable(int arg0)
        {
            return IExecuteWithSignature<bool>("isWritable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getColumnDisplaySize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetColumnDisplaySize(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnDisplaySize", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getColumnType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetColumnType(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getPrecision(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetPrecision(int arg0)
        {
            return IExecuteWithSignature<int>("getPrecision", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetScale(int arg0)
        {
            return IExecuteWithSignature<int>("getScale", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#isNullable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int IsNullable(int arg0)
        {
            return IExecuteWithSignature<int>("isNullable", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getCatalogName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetCatalogName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getCatalogName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getColumnClassName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnClassName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnClassName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getColumnLabel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnLabel(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnLabel", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getColumnName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getColumnTypeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetColumnTypeName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnTypeName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getSchemaName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetSchemaName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getSchemaName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#getTableName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetTableName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getTableName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setAutoIncrement(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetAutoIncrement(int arg0, bool arg1)
        {
            IExecute("setAutoIncrement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setCaseSensitive(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCaseSensitive(int arg0, bool arg1)
        {
            IExecute("setCaseSensitive", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setCatalogName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCatalogName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setCatalogName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setColumnDisplaySize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnDisplaySize(int arg0, int arg1)
        {
            IExecute("setColumnDisplaySize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setColumnLabel(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnLabel(int arg0, Java.Lang.String arg1)
        {
            IExecute("setColumnLabel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setColumnName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setColumnName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setColumnType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnType(int arg0, int arg1)
        {
            IExecute("setColumnType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setColumnTypeName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnTypeName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setColumnTypeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setCurrency(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCurrency(int arg0, bool arg1)
        {
            IExecute("setCurrency", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setNullable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNullable(int arg0, int arg1)
        {
            IExecute("setNullable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setPrecision(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetPrecision(int arg0, int arg1)
        {
            IExecute("setPrecision", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setScale(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetScale(int arg0, int arg1)
        {
            IExecute("setScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setSchemaName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetSchemaName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setSchemaName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setSearchable(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetSearchable(int arg0, bool arg1)
        {
            IExecute("setSearchable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setSigned(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetSigned(int arg0, bool arg1)
        {
            IExecute("setSigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/RowSetMetaDataImpl.html#setTableName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetTableName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setTableName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}