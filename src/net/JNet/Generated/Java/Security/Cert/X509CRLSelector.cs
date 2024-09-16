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

namespace Java.Security.Cert
{
    #region X509CRLSelector declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html"/>
    /// </summary>
    public partial class X509CRLSelector : Java.Security.Cert.CRLSelector
    {
        const string _bridgeClassName = "java.security.cert.X509CRLSelector";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public X509CRLSelector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public X509CRLSelector(params object[] args) : base(args) { }

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

    #region X509CRLSelector implementation
    public partial class X509CRLSelector
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getCertificateChecking()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setCertificateChecking(java.security.cert.X509Certificate)"/>
        /// </summary>
        public Java.Security.Cert.X509Certificate CertificateChecking
        {
            get { return IExecuteWithSignature<Java.Security.Cert.X509Certificate>("getCertificateChecking", "()Ljava/security/cert/X509Certificate;"); } set { IExecuteWithSignature("setCertificateChecking", "(Ljava/security/cert/X509Certificate;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getDateAndTime()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setDateAndTime(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date DateAndTime
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getDateAndTime", "()Ljava/util/Date;"); } set { IExecuteWithSignature("setDateAndTime", "(Ljava/util/Date;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getIssuerNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setIssuerNames(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection<object> IssuerNames
        {
            get { return IExecuteWithSignature<Java.Util.Collection<object>>("getIssuerNames", "()Ljava/util/Collection;"); } set { IExecuteWithSignature("setIssuerNames", "(Ljava/util/Collection;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getIssuers()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setIssuers(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection<Javax.Security.Auth.X500.X500Principal> Issuers
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Javax.Security.Auth.X500.X500Principal>>("getIssuers", "()Ljava/util/Collection;"); } set { IExecuteWithSignature("setIssuers", "(Ljava/util/Collection;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getMaxCRL()"/> 
        /// </summary>
        public Java.Math.BigInteger MaxCRL
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getMaxCRL", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#getMinCRL()"/> 
        /// </summary>
        public Java.Math.BigInteger MinCRL
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getMinCRL", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#match(java.security.cert.CRL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CRL"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Match(Java.Security.Cert.CRL arg0)
        {
            return IExecuteWithSignature<bool>("match", "(Ljava/security/cert/CRL;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#addIssuer(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void AddIssuer(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecuteWithSignature("addIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#addIssuerName(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddIssuerName(byte[] arg0)
        {
            IExecuteWithSignature("addIssuerName", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#addIssuerName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddIssuerName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addIssuerName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setMaxCRLNumber(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public void SetMaxCRLNumber(Java.Math.BigInteger arg0)
        {
            IExecuteWithSignature("setMaxCRLNumber", "(Ljava/math/BigInteger;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLSelector.html#setMinCRLNumber(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public void SetMinCRLNumber(Java.Math.BigInteger arg0)
        {
            IExecuteWithSignature("setMinCRLNumber", "(Ljava/math/BigInteger;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}