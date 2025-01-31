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

namespace Javax.Net.Ssl
{
    #region HandshakeCompletedEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html"/>
    /// </summary>
    public partial class HandshakeCompletedEvent : Java.Util.EventObject
    {
        const string _bridgeClassName = "javax.net.ssl.HandshakeCompletedEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HandshakeCompletedEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HandshakeCompletedEvent(params object[] args) : base(args) { }

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

    #region HandshakeCompletedEvent implementation
    public partial class HandshakeCompletedEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#%3Cinit%3E(javax.net.ssl.SSLSocket,javax.net.ssl.SSLSession)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSocket"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.SSLSession"/></param>
        public HandshakeCompletedEvent(Javax.Net.Ssl.SSLSocket arg0, Javax.Net.Ssl.SSLSession arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#getCipherSuite()"/> 
        /// </summary>
        public Java.Lang.String CipherSuite
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCipherSuite", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#getLocalCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] LocalCertificates
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getLocalCertificates", "()[Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#getLocalPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal LocalPrincipal
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getLocalPrincipal", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#getPeerCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] PeerCertificates
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getPeerCertificates", "()[Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#getPeerPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal PeerPrincipal
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getPeerPrincipal", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#getSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession Session
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getSession", "()Ljavax/net/ssl/SSLSession;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HandshakeCompletedEvent.html#getSocket()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSocket Socket
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSocket>("getSocket", "()Ljavax/net/ssl/SSLSocket;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}