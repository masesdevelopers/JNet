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

namespace Javax.Naming.Ldap
{
    #region StartTlsResponse
    public partial class StartTlsResponse
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#OID"/>
        /// </summary>
        public static Java.Lang.String OID { get { if (!_OIDReady) { _OIDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OID"); _OIDReady = true; } return _OIDContent; } }
        private static Java.Lang.String _OIDContent = default;
        private static bool _OIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#getEncodedValue()"/> 
        /// </summary>
        public byte[] EncodedValue
        {
            get { return IExecuteWithSignatureArray<byte>("getEncodedValue", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#getID()"/> 
        /// </summary>
        public Java.Lang.String ID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#negotiate()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Net.Ssl.SSLSession Negotiate()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("negotiate", "()Ljavax/net/ssl/SSLSession;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#negotiate(javax.net.ssl.SSLSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSocketFactory"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Net.Ssl.SSLSession Negotiate(Javax.Net.Ssl.SSLSocketFactory arg0)
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("negotiate", "(Ljavax/net/ssl/SSLSocketFactory;)Ljavax/net/ssl/SSLSession;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEnabledCipherSuites(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEnabledCipherSuites", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/StartTlsResponse.html#setHostnameVerifier(javax.net.ssl.HostnameVerifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HostnameVerifier"/></param>
        public void SetHostnameVerifier(Javax.Net.Ssl.HostnameVerifier arg0)
        {
            IExecuteWithSignature("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}