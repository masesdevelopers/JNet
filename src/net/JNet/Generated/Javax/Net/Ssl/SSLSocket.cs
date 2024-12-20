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
    #region SSLSocket declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html"/>
    /// </summary>
    public partial class SSLSocket : Java.Net.Socket
    {
        const string _bridgeClassName = "javax.net.ssl.SSLSocket";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SSLSocket class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SSLSocket() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SSLSocket class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SSLSocket(params object[] args) : base(args) { }

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

    #region SSLSocket implementation
    public partial class SSLSocket
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getApplicationProtocol()"/> 
        /// </summary>
        public Java.Lang.String ApplicationProtocol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getApplicationProtocol", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getEnabledCipherSuites()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] EnabledCipherSuites
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledCipherSuites", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setEnabledCipherSuites", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getEnabledProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] EnabledProtocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledProtocols", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setEnabledProtocols", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getEnableSessionCreation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        public bool EnableSessionCreation
        {
            get { return IExecuteWithSignature<bool>("getEnableSessionCreation", "()Z"); } set { IExecuteWithSignature("setEnableSessionCreation", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getHandshakeApplicationProtocol()"/> 
        /// </summary>
        public Java.Lang.String HandshakeApplicationProtocol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHandshakeApplicationProtocol", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getHandshakeApplicationProtocolSelector()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setHandshakeApplicationProtocolSelector(java.util.function.BiFunction)"/>
        /// </summary>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String> HandshakeApplicationProtocolSelector
        {
            get { return IExecuteWithSignature<Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLSocket, Java.Util.List<Java.Lang.String>, Java.Lang.String>>("getHandshakeApplicationProtocolSelector", "()Ljava/util/function/BiFunction;"); } set { IExecuteWithSignature("setHandshakeApplicationProtocolSelector", "(Ljava/util/function/BiFunction;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getHandshakeSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession HandshakeSession
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getHandshakeSession", "()Ljavax/net/ssl/SSLSession;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getNeedClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z"); } set { IExecuteWithSignature("setNeedClientAuth", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession Session
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getSession", "()Ljavax/net/ssl/SSLSession;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSSLParameters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
        /// </summary>
        public Javax.Net.Ssl.SSLParameters SSLParameters
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;"); } set { IExecuteWithSignature("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSupportedCipherSuites()"/> 
        /// </summary>
        public Java.Lang.String[] SupportedCipherSuites
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedCipherSuites", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getSupportedProtocols()"/> 
        /// </summary>
        public Java.Lang.String[] SupportedProtocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedProtocols", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getUseClientMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setUseClientMode(boolean)"/>
        /// </summary>
        public bool UseClientMode
        {
            get { return IExecuteWithSignature<bool>("getUseClientMode", "()Z"); } set { IExecuteWithSignature("setUseClientMode", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#getWantClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#setWantClientAuth(boolean)"/>
        /// </summary>
        public bool WantClientAuth
        {
            get { return IExecuteWithSignature<bool>("getWantClientAuth", "()Z"); } set { IExecuteWithSignature("setWantClientAuth", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#addHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedListener"/></param>
        public void AddHandshakeCompletedListener(Javax.Net.Ssl.HandshakeCompletedListener arg0)
        {
            IExecuteWithSignature("addHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#removeHandshakeCompletedListener(javax.net.ssl.HandshakeCompletedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HandshakeCompletedListener"/></param>
        public void RemoveHandshakeCompletedListener(Javax.Net.Ssl.HandshakeCompletedListener arg0)
        {
            IExecuteWithSignature("removeHandshakeCompletedListener", "(Ljavax/net/ssl/HandshakeCompletedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSocket.html#startHandshake()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void StartHandshake()
        {
            IExecuteWithSignature("startHandshake", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}