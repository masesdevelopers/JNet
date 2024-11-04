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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region X509CRL declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html"/>
    /// </summary>
    public partial class X509CRL : Java.Security.Cert.CRL
    {
        const string _bridgeClassName = "java.security.cert.X509CRL";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("X509CRL class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public X509CRL() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("X509CRL class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public X509CRL(params object[] args) : base(args) { }

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

    #region X509CRL implementation
    public partial class X509CRL
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509CRL"/> to <see cref="Java.Security.Cert.X509Extension"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.X509Extension(Java.Security.Cert.X509CRL t) => t.Cast<Java.Security.Cert.X509Extension>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteWithSignatureArray<byte>("getEncoded", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getIssuerDN()"/> 
        /// </summary>
        public Java.Security.Principal IssuerDN
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getIssuerDN", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getIssuerX500Principal()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal IssuerX500Principal
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getNextUpdate()"/> 
        /// </summary>
        public Java.Util.Date NextUpdate
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getNextUpdate", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getRevokedCertificates()"/> 
        /// </summary>
        public Java.Util.Set RevokedCertificates
        {
            get { return IExecuteWithSignature<Java.Util.Set>("getRevokedCertificates", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getSigAlgName()"/> 
        /// </summary>
        public Java.Lang.String SigAlgName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSigAlgName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getSigAlgOID()"/> 
        /// </summary>
        public Java.Lang.String SigAlgOID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSigAlgOID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getSigAlgParams()"/> 
        /// </summary>
        public byte[] SigAlgParams
        {
            get { return IExecuteWithSignatureArray<byte>("getSigAlgParams", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getSignature()"/> 
        /// </summary>
        public byte[] Signature
        {
            get { return IExecuteWithSignatureArray<byte>("getSignature", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getTBSCertList()"/> 
        /// </summary>
        public byte[] TBSCertList
        {
            get { return IExecuteWithSignatureArray<byte>("getTBSCertList", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getThisUpdate()"/> 
        /// </summary>
        public Java.Util.Date ThisUpdate
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getThisUpdate", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getVersion()"/> 
        /// </summary>
        public int Version
        {
            get { return IExecuteWithSignature<int>("getVersion", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getRevokedCertificate(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Security.Cert.X509CRLEntry"/></returns>
        public Java.Security.Cert.X509CRLEntry GetRevokedCertificate(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.X509CRLEntry>("getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#verify(java.security.PublicKey,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#verify(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("verify", "(Ljava/security/PublicKey;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#getRevokedCertificate(java.security.cert.X509Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <returns><see cref="Java.Security.Cert.X509CRLEntry"/></returns>
        public Java.Security.Cert.X509CRLEntry GetRevokedCertificate(Java.Security.Cert.X509Certificate arg0)
        {
            return IExecuteWithSignature<Java.Security.Cert.X509CRLEntry>("getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRL.html#verify(java.security.PublicKey,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <exception cref="Java.Security.Cert.CRLException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Verify(Java.Security.PublicKey arg0, Java.Security.Provider arg1)
        {
            IExecuteWithSignature("verify", "(Ljava/security/PublicKey;Ljava/security/Provider;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}