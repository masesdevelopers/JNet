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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset.Serial
{
    #region SerialBlob declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html"/>
    /// </summary>
    public partial class SerialBlob : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SerialBlob>
    {
        const string _bridgeClassName = "javax.sql.rowset.serial.SerialBlob";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SerialBlob() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SerialBlob(params object[] args) : base(args) { }

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

    #region SerialBlob implementation
    public partial class SerialBlob
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public SerialBlob(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#%3Cinit%3E(java.sql.Blob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Blob"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public SerialBlob(Java.Sql.Blob arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialBlob"/> to <see cref="Java.Sql.Blob"/>
        /// </summary>
        public static implicit operator Java.Sql.Blob(Javax.Sql.Rowset.Serial.SerialBlob t) => t.Cast<Java.Sql.Blob>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialBlob"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Sql.Rowset.Serial.SerialBlob t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialBlob"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Sql.Rowset.Serial.SerialBlob t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#getBinaryStream()"/> 
        /// </summary>
        public Java.Io.InputStream BinaryStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getBinaryStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#getBytes(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public byte[] GetBytes(long arg0, int arg1)
        {
            return IExecuteWithSignatureArray<byte>("getBytes", "(JI)[B", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#setBytes(long,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public int SetBytes(long arg0, byte[] arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<int>("setBytes", "(J[BII)I", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#setBytes(long,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public int SetBytes(long arg0, byte[] arg1)
        {
            return IExecuteWithSignature<int>("setBytes", "(J[B)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#getBinaryStream(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.InputStream GetBinaryStream(long arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getBinaryStream", "(JJ)Ljava/io/InputStream;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#setBinaryStream(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.OutputStream SetBinaryStream(long arg0)
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("setBinaryStream", "(J)Ljava/io/OutputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#length()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public long Length()
        {
            return IExecuteWithSignature<long>("length", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#position(byte[],long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public long Position(byte[] arg0, long arg1)
        {
            return IExecuteWithSignature<long>("position", "([BJ)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#position(java.sql.Blob,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Blob"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public long Position(Java.Sql.Blob arg0, long arg1)
        {
            return IExecuteWithSignature<long>("position", "(Ljava/sql/Blob;J)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#free()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Free()
        {
            IExecuteWithSignature("free", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialBlob.html#truncate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public void Truncate(long arg0)
        {
            IExecuteWithSignature("truncate", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}