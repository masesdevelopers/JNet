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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region InputStream declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html"/>
    /// </summary>
    public partial class InputStream : Java.Io.Closeable
    {
        const string _bridgeClassName = "java.io.InputStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputStream(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region InputStream implementation
    public partial class InputStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#nullInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public static Java.Io.InputStream NullInputStream()
        {
            return SExecuteWithSignature<Java.Io.InputStream>(LocalBridgeClazz, "nullInputStream", "()Ljava/io/InputStream;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#read()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read()
        {
            return IExecuteWithSignature<int>("read", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#markSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MarkSupported()
        {
            return IExecuteWithSignature<bool>("markSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#readAllBytes()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] ReadAllBytes()
        {
            return IExecuteWithSignatureArray<byte>("readAllBytes", "()[B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#readNBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] ReadNBytes(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("readNBytes", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#available()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Available()
        {
            return IExecuteWithSignature<int>("available", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#read(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<int>("read", "([BII)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#read(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(byte[] arg0)
        {
            return IExecuteWithSignature<int>("read", "([B)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#readNBytes(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadNBytes(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteWithSignature<int>("readNBytes", "([BII)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#skip(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Skip(long arg0)
        {
            return IExecuteWithSignature<long>("skip", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#transferTo(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long TransferTo(Java.Io.OutputStream arg0)
        {
            return IExecuteWithSignature<long>("transferTo", "(Ljava/io/OutputStream;)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#mark(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Mark(int arg0)
        {
            IExecuteWithSignature("mark", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/InputStream.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}