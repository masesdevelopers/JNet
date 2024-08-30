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

namespace Javax.Net.Ssl
{
    #region SSLEngineResult definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html"/>
    /// </summary>
    public partial class SSLEngineResult : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SSLEngineResult>
    {
        const string _bridgeClassName = "javax.net.ssl.SSLEngineResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SSLEngineResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SSLEngineResult(params object[] args) : base(args) { }

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
        #region HandshakeStatus definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html"/>
        /// </summary>
        public partial class HandshakeStatus : Java.Lang.Enum<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>
        {
            const string _bridgeClassName = "javax.net.ssl.SSLEngineResult$HandshakeStatus";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public HandshakeStatus() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public HandshakeStatus(params object[] args) : base(args) { }

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

        #region Status definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html"/>
        /// </summary>
        public partial class Status : Java.Lang.Enum<Javax.Net.Ssl.SSLEngineResult.Status>
        {
            const string _bridgeClassName = "javax.net.ssl.SSLEngineResult$Status";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Status() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Status(params object[] args) : base(args) { }

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

    #region SSLEngineResult
    public partial class SSLEngineResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#%3Cinit%3E(javax.net.ssl.SSLEngineResult.Status,javax.net.ssl.SSLEngineResult.HandshakeStatus,int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        public SSLEngineResult(Javax.Net.Ssl.SSLEngineResult.Status arg0, Javax.Net.Ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3, long arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#%3Cinit%3E(javax.net.ssl.SSLEngineResult.Status,javax.net.ssl.SSLEngineResult.HandshakeStatus,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SSLEngineResult(Javax.Net.Ssl.SSLEngineResult.Status arg0, Javax.Net.Ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#getHandshakeStatus()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLEngineResult.HandshakeStatus GetHandshakeStatus
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#getStatus()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLEngineResult.Status GetStatus
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLEngineResult.Status>("getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#bytesConsumed()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BytesConsumed()
        {
            return IExecuteWithSignature<int>("bytesConsumed", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#bytesProduced()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BytesProduced()
        {
            return IExecuteWithSignature<int>("bytesProduced", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.html#sequenceNumber()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long SequenceNumber()
        {
            return IExecuteWithSignature<long>("sequenceNumber", "()J");
        }

        #endregion

        #region Nested classes
        #region HandshakeStatus
        public partial class HandshakeStatus
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#FINISHED"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus FINISHED { get { if (!_FINISHEDReady) { _FINISHEDContent = SGetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "FINISHED"); _FINISHEDReady = true; } return _FINISHEDContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus _FINISHEDContent = default;
            private static bool _FINISHEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_TASK"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_TASK { get { if (!_NEED_TASKReady) { _NEED_TASKContent = SGetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "NEED_TASK"); _NEED_TASKReady = true; } return _NEED_TASKContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus _NEED_TASKContent = default;
            private static bool _NEED_TASKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_UNWRAP"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP { get { if (!_NEED_UNWRAPReady) { _NEED_UNWRAPContent = SGetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "NEED_UNWRAP"); _NEED_UNWRAPReady = true; } return _NEED_UNWRAPContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus _NEED_UNWRAPContent = default;
            private static bool _NEED_UNWRAPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_UNWRAP_AGAIN"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP_AGAIN { get { if (!_NEED_UNWRAP_AGAINReady) { _NEED_UNWRAP_AGAINContent = SGetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "NEED_UNWRAP_AGAIN"); _NEED_UNWRAP_AGAINReady = true; } return _NEED_UNWRAP_AGAINContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus _NEED_UNWRAP_AGAINContent = default;
            private static bool _NEED_UNWRAP_AGAINReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NEED_WRAP"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NEED_WRAP { get { if (!_NEED_WRAPReady) { _NEED_WRAPContent = SGetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "NEED_WRAP"); _NEED_WRAPReady = true; } return _NEED_WRAPContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus _NEED_WRAPContent = default;
            private static bool _NEED_WRAPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#NOT_HANDSHAKING"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus NOT_HANDSHAKING { get { if (!_NOT_HANDSHAKINGReady) { _NOT_HANDSHAKINGContent = SGetField<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "NOT_HANDSHAKING"); _NOT_HANDSHAKINGReady = true; } return _NOT_HANDSHAKINGContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus _NOT_HANDSHAKINGContent = default;
            private static bool _NOT_HANDSHAKINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.HandshakeStatus.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.HandshakeStatus"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.HandshakeStatus[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>(LocalBridgeClazz, "values", "()[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Status
        public partial class Status
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#BUFFER_OVERFLOW"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status BUFFER_OVERFLOW { get { if (!_BUFFER_OVERFLOWReady) { _BUFFER_OVERFLOWContent = SGetField<Javax.Net.Ssl.SSLEngineResult.Status>(LocalBridgeClazz, "BUFFER_OVERFLOW"); _BUFFER_OVERFLOWReady = true; } return _BUFFER_OVERFLOWContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.Status _BUFFER_OVERFLOWContent = default;
            private static bool _BUFFER_OVERFLOWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#BUFFER_UNDERFLOW"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status BUFFER_UNDERFLOW { get { if (!_BUFFER_UNDERFLOWReady) { _BUFFER_UNDERFLOWContent = SGetField<Javax.Net.Ssl.SSLEngineResult.Status>(LocalBridgeClazz, "BUFFER_UNDERFLOW"); _BUFFER_UNDERFLOWReady = true; } return _BUFFER_UNDERFLOWContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.Status _BUFFER_UNDERFLOWContent = default;
            private static bool _BUFFER_UNDERFLOWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#CLOSED"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status CLOSED { get { if (!_CLOSEDReady) { _CLOSEDContent = SGetField<Javax.Net.Ssl.SSLEngineResult.Status>(LocalBridgeClazz, "CLOSED"); _CLOSEDReady = true; } return _CLOSEDContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.Status _CLOSEDContent = default;
            private static bool _CLOSEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#OK"/>
            /// </summary>
            public static Javax.Net.Ssl.SSLEngineResult.Status OK { get { if (!_OKReady) { _OKContent = SGetField<Javax.Net.Ssl.SSLEngineResult.Status>(LocalBridgeClazz, "OK"); _OKReady = true; } return _OKContent; } }
            private static Javax.Net.Ssl.SSLEngineResult.Status _OKContent = default;
            private static bool _OKReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.Status ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Net.Ssl.SSLEngineResult.Status>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngineResult.Status.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult.Status"/></returns>
            public static Javax.Net.Ssl.SSLEngineResult.Status[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Net.Ssl.SSLEngineResult.Status>(LocalBridgeClazz, "values", "()[Ljavax/net/ssl/SSLEngineResult$Status;");
            }

            #endregion

            #region Instance methods

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