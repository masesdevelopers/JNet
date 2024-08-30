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

namespace Java.Util
{
    #region Base64 definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html"/>
    /// </summary>
    public partial class Base64 : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Base64>
    {
        const string _bridgeClassName = "java.util.Base64";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Base64() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Base64(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region Decoder definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html"/>
        /// </summary>
        public partial class Decoder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Decoder>
        {
            const string _bridgeClassName = "java.util.Base64$Decoder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Decoder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Decoder(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Encoder definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html"/>
        /// </summary>
        public partial class Encoder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Encoder>
        {
            const string _bridgeClassName = "java.util.Base64$Encoder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Encoder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Encoder(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region Base64
    public partial class Base64
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getDecoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Decoder GetDecoder
        {
            get { return SExecuteWithSignature<Java.Util.Base64.Decoder>(LocalBridgeClazz, "getDecoder", "()Ljava/util/Base64$Decoder;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getEncoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Encoder GetEncoder
        {
            get { return SExecuteWithSignature<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getEncoder", "()Ljava/util/Base64$Encoder;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getMimeDecoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Decoder MimeDecoder
        {
            get { return SExecuteWithSignature<Java.Util.Base64.Decoder>(LocalBridgeClazz, "getMimeDecoder", "()Ljava/util/Base64$Decoder;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getMimeEncoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Encoder MimeEncoder
        {
            get { return SExecuteWithSignature<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getMimeEncoder", "()Ljava/util/Base64$Encoder;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getUrlDecoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Decoder UrlDecoder
        {
            get { return SExecuteWithSignature<Java.Util.Base64.Decoder>(LocalBridgeClazz, "getUrlDecoder", "()Ljava/util/Base64$Decoder;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getUrlEncoder()"/> 
        /// </summary>
        public static Java.Util.Base64.Encoder UrlEncoder
        {
            get { return SExecuteWithSignature<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getUrlEncoder", "()Ljava/util/Base64$Encoder;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.html#getMimeEncoder(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Util.Base64.Encoder"/></returns>
        public static Java.Util.Base64.Encoder GetMimeEncoder(int arg0, byte[] arg1)
        {
            return SExecute<Java.Util.Base64.Encoder>(LocalBridgeClazz, "getMimeEncoder", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Decoder
        public partial class Decoder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="byte"/></returns>
            public byte[] Decode(byte[] arg0)
            {
                return IExecuteWithSignatureArray<byte>("decode", "([B)[B", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="byte"/></returns>
            public byte[] Decode(Java.Lang.String arg0)
            {
                return IExecuteWithSignatureArray<byte>("decode", "(Ljava/lang/String;)[B", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="int"/></returns>
            public int Decode(byte[] arg0, byte[] arg1)
            {
                return IExecute<int>("decode", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#wrap(java.io.InputStream)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
            /// <returns><see cref="Java.Io.InputStream"/></returns>
            public Java.Io.InputStream Wrap(Java.Io.InputStream arg0)
            {
                return IExecuteWithSignature<Java.Io.InputStream>("wrap", "(Ljava/io/InputStream;)Ljava/io/InputStream;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Decoder.html#decode(java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer Decode(Java.Nio.ByteBuffer arg0)
            {
                return IExecuteWithSignature<Java.Nio.ByteBuffer>("decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Encoder
        public partial class Encoder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encode(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="byte"/></returns>
            public byte[] Encode(byte[] arg0)
            {
                return IExecuteWithSignatureArray<byte>("encode", "([B)[B", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encode(byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="int"/></returns>
            public int Encode(byte[] arg0, byte[] arg1)
            {
                return IExecute<int>("encode", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#wrap(java.io.OutputStream)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
            /// <returns><see cref="Java.Io.OutputStream"/></returns>
            public Java.Io.OutputStream Wrap(Java.Io.OutputStream arg0)
            {
                return IExecuteWithSignature<Java.Io.OutputStream>("wrap", "(Ljava/io/OutputStream;)Ljava/io/OutputStream;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encodeToString(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String EncodeToString(byte[] arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("encodeToString", "([B)Ljava/lang/String;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#encode(java.nio.ByteBuffer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
            public Java.Nio.ByteBuffer Encode(Java.Nio.ByteBuffer arg0)
            {
                return IExecuteWithSignature<Java.Nio.ByteBuffer>("encode", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Base64.Encoder.html#withoutPadding()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Base64.Encoder"/></returns>
            public Java.Util.Base64.Encoder WithoutPadding()
            {
                return IExecuteWithSignature<Java.Util.Base64.Encoder>("withoutPadding", "()Ljava/util/Base64$Encoder;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}