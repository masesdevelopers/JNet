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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region SSLEngine
    public partial class SSLEngine
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getApplicationProtocol()"/> 
        /// </summary>
        public Java.Lang.String ApplicationProtocol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getApplicationProtocol", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getDelegatedTask()"/> 
        /// </summary>
        public Java.Lang.Runnable DelegatedTask
        {
            get { return IExecuteWithSignature<Java.Lang.Runnable>("getDelegatedTask", "()Ljava/lang/Runnable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getEnabledCipherSuites()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] EnabledCipherSuites
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledCipherSuites", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setEnabledCipherSuites", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getEnabledProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] EnabledProtocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledProtocols", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setEnabledProtocols", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getEnableSessionCreation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        public bool EnableSessionCreation
        {
            get { return IExecuteWithSignature<bool>("getEnableSessionCreation", "()Z"); } set { IExecuteWithSignature("setEnableSessionCreation", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeApplicationProtocol()"/> 
        /// </summary>
        public Java.Lang.String HandshakeApplicationProtocol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHandshakeApplicationProtocol", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeApplicationProtocolSelector()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setHandshakeApplicationProtocolSelector(java.util.function.BiFunction)"/>
        /// </summary>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String> HandshakeApplicationProtocolSelector
        {
            get { return IExecuteWithSignature<Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<Java.Lang.String>, Java.Lang.String>>("getHandshakeApplicationProtocolSelector", "()Ljava/util/function/BiFunction;"); } set { IExecuteWithSignature("setHandshakeApplicationProtocolSelector", "(Ljava/util/function/BiFunction;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession HandshakeSession
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getHandshakeSession", "()Ljavax/net/ssl/SSLSession;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeStatus()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLEngineResult.HandshakeStatus HandshakeStatus
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getNeedClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z"); } set { IExecuteWithSignature("setNeedClientAuth", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getPeerHost()"/> 
        /// </summary>
        public Java.Lang.String PeerHost
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPeerHost", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getPeerPort()"/> 
        /// </summary>
        public int PeerPort
        {
            get { return IExecuteWithSignature<int>("getPeerPort", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession Session
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getSession", "()Ljavax/net/ssl/SSLSession;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSSLParameters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
        /// </summary>
        public Javax.Net.Ssl.SSLParameters SSLParameters
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;"); } set { IExecuteWithSignature("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSupportedCipherSuites()"/> 
        /// </summary>
        public Java.Lang.String[] SupportedCipherSuites
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedCipherSuites", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSupportedProtocols()"/> 
        /// </summary>
        public Java.Lang.String[] SupportedProtocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedProtocols", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getUseClientMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setUseClientMode(boolean)"/>
        /// </summary>
        public bool UseClientMode
        {
            get { return IExecuteWithSignature<bool>("getUseClientMode", "()Z"); } set { IExecuteWithSignature("setUseClientMode", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getWantClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setWantClientAuth(boolean)"/>
        /// </summary>
        public bool WantClientAuth
        {
            get { return IExecuteWithSignature<bool>("getWantClientAuth", "()Z"); } set { IExecuteWithSignature("setWantClientAuth", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#isInboundDone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInboundDone()
        {
            return IExecuteWithSignature<bool>("isInboundDone", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#isOutboundDone()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutboundDone()
        {
            return IExecuteWithSignature<bool>("isOutboundDone", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer[] arg1, int arg2, int arg3)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer[],int,int,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2, Java.Nio.ByteBuffer arg3)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#beginHandshake()"/>
        /// </summary>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public void BeginHandshake()
        {
            IExecuteWithSignature("beginHandshake", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#closeInbound()"/>
        /// </summary>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public void CloseInbound()
        {
            IExecuteWithSignature("closeInbound", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#closeOutbound()"/>
        /// </summary>
        public void CloseOutbound()
        {
            IExecuteWithSignature("closeOutbound", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer[] arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer[],java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer[] arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}