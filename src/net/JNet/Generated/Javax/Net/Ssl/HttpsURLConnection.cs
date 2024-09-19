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

namespace Javax.Net.Ssl
{
    #region HttpsURLConnection declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html"/>
    /// </summary>
    public partial class HttpsURLConnection : Java.Net.HttpURLConnection
    {
        const string _bridgeClassName = "javax.net.ssl.HttpsURLConnection";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HttpsURLConnection class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpsURLConnection() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HttpsURLConnection class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpsURLConnection(params object[] args) : base(args) { }

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

    #region HttpsURLConnection implementation
    public partial class HttpsURLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getDefaultSSLSocketFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setDefaultSSLSocketFactory(javax.net.ssl.SSLSocketFactory)"/>
        /// </summary>
        public static Javax.Net.Ssl.SSLSocketFactory DefaultSSLSocketFactory
        {
            get { return SExecuteWithSignature<Javax.Net.Ssl.SSLSocketFactory>(LocalBridgeClazz, "getDefaultSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setDefaultSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getDefaultHostnameVerifier()"/> 
        /// </summary>
        public static Javax.Net.Ssl.HostnameVerifier GetDefaultHostnameVerifier
        {
            get { return SExecuteWithSignature<Javax.Net.Ssl.HostnameVerifier>(LocalBridgeClazz, "getDefaultHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setDefaultHostnameVerifier(javax.net.ssl.HostnameVerifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HostnameVerifier"/></param>
        public static void SetDefaultHostnameVerifier(Javax.Net.Ssl.HostnameVerifier arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefaultHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getCipherSuite()"/> 
        /// </summary>
        public Java.Lang.String CipherSuite
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCipherSuite", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getHostnameVerifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setHostnameVerifier(javax.net.ssl.HostnameVerifier)"/>
        /// </summary>
        public Javax.Net.Ssl.HostnameVerifier HostnameVerifier
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.HostnameVerifier>("getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;"); } set { IExecuteWithSignature("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getLocalCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] LocalCertificates
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getLocalCertificates", "()[Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getLocalPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal LocalPrincipal
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getLocalPrincipal", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getPeerPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal PeerPrincipal
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getPeerPrincipal", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getServerCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] ServerCertificates
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getServerCertificates", "()[Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getSSLSocketFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setSSLSocketFactory(javax.net.ssl.SSLSocketFactory)"/>
        /// </summary>
        public Javax.Net.Ssl.SSLSocketFactory SSLSocketFactory
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSocketFactory>("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;"); } set { IExecuteWithSignature("setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}