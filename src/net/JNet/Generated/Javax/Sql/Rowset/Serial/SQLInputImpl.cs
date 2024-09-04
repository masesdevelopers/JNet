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

namespace Javax.Sql.Rowset.Serial
{
    #region SQLInputImpl declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html"/>
    /// </summary>
    public partial class SQLInputImpl : Java.Sql.SQLInput
    {
        const string _bridgeClassName = "javax.sql.rowset.serial.SQLInputImpl";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SQLInputImpl() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SQLInputImpl(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SQLInputImpl implementation
    public partial class SQLInputImpl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool ReadBoolean()
        {
            return IExecuteWithSignature<bool>("readBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#wasNull()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool WasNull()
        {
            return IExecuteWithSignature<bool>("wasNull", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public byte ReadByte()
        {
            return IExecuteWithSignature<byte>("readByte", "()B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readBytes()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public byte[] ReadBytes()
        {
            return IExecuteWithSignatureArray<byte>("readBytes", "()[B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public double ReadDouble()
        {
            return IExecuteWithSignature<double>("readDouble", "()D");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public float ReadFloat()
        {
            return IExecuteWithSignature<float>("readFloat", "()F");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ReadInt()
        {
            return IExecuteWithSignature<int>("readInt", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readAsciiStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.InputStream ReadAsciiStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("readAsciiStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readBinaryStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.InputStream ReadBinaryStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("readBinaryStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readCharacterStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Reader ReadCharacterStream()
        {
            return IExecuteWithSignature<Java.Io.Reader>("readCharacterStream", "()Ljava/io/Reader;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readObject()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object ReadObject()
        {
            return IExecuteWithSignature("readObject", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readNString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String ReadNString()
        {
            return IExecuteWithSignature<Java.Lang.String>("readNString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String ReadString()
        {
            return IExecuteWithSignature<Java.Lang.String>("readString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Math.BigDecimal ReadBigDecimal()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("readBigDecimal", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readURL()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Net.URL ReadURL()
        {
            return IExecuteWithSignature<Java.Net.URL>("readURL", "()Ljava/net/URL;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readArray()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Array"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Array ReadArray()
        {
            return IExecuteWithSignature<Java.Sql.Array>("readArray", "()Ljava/sql/Array;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readBlob()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Blob"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Blob ReadBlob()
        {
            return IExecuteWithSignature<Java.Sql.Blob>("readBlob", "()Ljava/sql/Blob;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readClob()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Clob"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Clob ReadClob()
        {
            return IExecuteWithSignature<Java.Sql.Clob>("readClob", "()Ljava/sql/Clob;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Date"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Date ReadDate()
        {
            return IExecuteWithSignature<Java.Sql.Date>("readDate", "()Ljava/sql/Date;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readNClob()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.NClob"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.NClob ReadNClob()
        {
            return IExecuteWithSignature<Java.Sql.NClob>("readNClob", "()Ljava/sql/NClob;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readRef()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Ref"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Ref ReadRef()
        {
            return IExecuteWithSignature<Java.Sql.Ref>("readRef", "()Ljava/sql/Ref;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readRowId()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.RowId"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.RowId ReadRowId()
        {
            return IExecuteWithSignature<Java.Sql.RowId>("readRowId", "()Ljava/sql/RowId;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readSQLXML()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.SQLXML"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.SQLXML ReadSQLXML()
        {
            return IExecuteWithSignature<Java.Sql.SQLXML>("readSQLXML", "()Ljava/sql/SQLXML;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Time"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Time ReadTime()
        {
            return IExecuteWithSignature<Java.Sql.Time>("readTime", "()Ljava/sql/Time;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readTimestamp()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Timestamp"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Timestamp ReadTimestamp()
        {
            return IExecuteWithSignature<Java.Sql.Timestamp>("readTimestamp", "()Ljava/sql/Timestamp;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ReadLong()
        {
            return IExecuteWithSignature<long>("readLong", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLInputImpl.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public short ReadShort()
        {
            return IExecuteWithSignature<short>("readShort", "()S");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}