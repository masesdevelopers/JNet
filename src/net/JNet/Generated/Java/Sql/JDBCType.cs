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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region JDBCType
    public partial class JDBCType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Sql.JDBCType"/> to <see cref="Java.Sql.SQLType"/>
        /// </summary>
        public static implicit operator Java.Sql.SQLType(Java.Sql.JDBCType t) => t.Cast<Java.Sql.SQLType>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ARRAY"/>
        /// </summary>
        public static Java.Sql.JDBCType ARRAY { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "ARRAY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIGINT"/>
        /// </summary>
        public static Java.Sql.JDBCType BIGINT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BIGINT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType BINARY { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BINARY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIT"/>
        /// </summary>
        public static Java.Sql.JDBCType BIT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BIT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType BLOB { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BLOB"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BOOLEAN"/>
        /// </summary>
        public static Java.Sql.JDBCType BOOLEAN { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "BOOLEAN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType CHAR { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "CHAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType CLOB { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "CLOB"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATALINK"/>
        /// </summary>
        public static Java.Sql.JDBCType DATALINK { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DATALINK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATE"/>
        /// </summary>
        public static Java.Sql.JDBCType DATE { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DATE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DECIMAL"/>
        /// </summary>
        public static Java.Sql.JDBCType DECIMAL { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DECIMAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DISTINCT"/>
        /// </summary>
        public static Java.Sql.JDBCType DISTINCT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DISTINCT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DOUBLE"/>
        /// </summary>
        public static Java.Sql.JDBCType DOUBLE { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "DOUBLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#FLOAT"/>
        /// </summary>
        public static Java.Sql.JDBCType FLOAT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "FLOAT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#INTEGER"/>
        /// </summary>
        public static Java.Sql.JDBCType INTEGER { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "INTEGER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#JAVA_OBJECT"/>
        /// </summary>
        public static Java.Sql.JDBCType JAVA_OBJECT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "JAVA_OBJECT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGNVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGNVARCHAR { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "LONGNVARCHAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARBINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGVARBINARY { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "LONGVARBINARY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGVARCHAR { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "LONGVARCHAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType NCHAR { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NCHAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType NCLOB { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NCLOB"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NULL"/>
        /// </summary>
        public static Java.Sql.JDBCType NULL { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NUMERIC"/>
        /// </summary>
        public static Java.Sql.JDBCType NUMERIC { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NUMERIC"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType NVARCHAR { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "NVARCHAR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#OTHER"/>
        /// </summary>
        public static Java.Sql.JDBCType OTHER { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "OTHER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REAL"/>
        /// </summary>
        public static Java.Sql.JDBCType REAL { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "REAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF"/>
        /// </summary>
        public static Java.Sql.JDBCType REF { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "REF"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF_CURSOR"/>
        /// </summary>
        public static Java.Sql.JDBCType REF_CURSOR { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "REF_CURSOR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ROWID"/>
        /// </summary>
        public static Java.Sql.JDBCType ROWID { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "ROWID"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SMALLINT"/>
        /// </summary>
        public static Java.Sql.JDBCType SMALLINT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "SMALLINT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SQLXML"/>
        /// </summary>
        public static Java.Sql.JDBCType SQLXML { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "SQLXML"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#STRUCT"/>
        /// </summary>
        public static Java.Sql.JDBCType STRUCT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "STRUCT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME"/>
        /// </summary>
        public static Java.Sql.JDBCType TIME { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME_WITH_TIMEZONE"/>
        /// </summary>
        public static Java.Sql.JDBCType TIME_WITH_TIMEZONE { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIME_WITH_TIMEZONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP"/>
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIMESTAMP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP_WITH_TIMEZONE"/>
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP_WITH_TIMEZONE { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TIMESTAMP_WITH_TIMEZONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TINYINT"/>
        /// </summary>
        public static Java.Sql.JDBCType TINYINT { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "TINYINT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARBINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType VARBINARY { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "VARBINARY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType VARCHAR { get { return SGetField<Java.Sql.JDBCType>(LocalBridgeClazz, "VARCHAR"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType ValueOf(int arg0)
        {
            return SExecute<Java.Sql.JDBCType>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType ValueOf(string arg0)
        {
            return SExecute<Java.Sql.JDBCType>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType[] Values()
        {
            return SExecuteArray<Java.Sql.JDBCType>(LocalBridgeClazz, "values");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendor()"/> 
        /// </summary>
        public string Vendor
        {
            get { return IExecute<string>("getVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendorTypeNumber()"/> 
        /// </summary>
        public Java.Lang.Integer VendorTypeNumber
        {
            get { return IExecute<Java.Lang.Integer>("getVendorTypeNumber"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}