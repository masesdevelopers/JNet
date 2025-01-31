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

namespace Java.Security.Cert
{
    #region X509CertSelector declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html"/>
    /// </summary>
    public partial class X509CertSelector : Java.Security.Cert.CertSelector
    {
        const string _bridgeClassName = "java.security.cert.X509CertSelector";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public X509CertSelector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public X509CertSelector(params object[] args) : base(args) { }

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

    #region X509CertSelector implementation
    public partial class X509CertSelector
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getAuthorityKeyIdentifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setAuthorityKeyIdentifier(byte[])"/>
        /// </summary>
        public byte[] AuthorityKeyIdentifier
        {
            get { return IExecuteWithSignatureArray<byte>("getAuthorityKeyIdentifier", "()[B"); } set { IExecuteWithSignature("setAuthorityKeyIdentifier", "([B)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getBasicConstraints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setBasicConstraints(int)"/>
        /// </summary>
        public int BasicConstraints
        {
            get { return IExecuteWithSignature<int>("getBasicConstraints", "()I"); } set { IExecuteWithSignature("setBasicConstraints", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getCertificate()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setCertificate(java.security.cert.X509Certificate)"/>
        /// </summary>
        public Java.Security.Cert.X509Certificate Certificate
        {
            get { return IExecuteWithSignature<Java.Security.Cert.X509Certificate>("getCertificate", "()Ljava/security/cert/X509Certificate;"); } set { IExecuteWithSignature("setCertificate", "(Ljava/security/cert/X509Certificate;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getCertificateValid()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setCertificateValid(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date CertificateValid
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getCertificateValid", "()Ljava/util/Date;"); } set { IExecuteWithSignature("setCertificateValid", "(Ljava/util/Date;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getExtendedKeyUsage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setExtendedKeyUsage(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<Java.Lang.String> ExtendedKeyUsage
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getExtendedKeyUsage", "()Ljava/util/Set;"); } set { IExecuteWithSignature("setExtendedKeyUsage", "(Ljava/util/Set;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuer()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal Issuer
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getIssuer", "()Ljavax/security/auth/x500/X500Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuerAsBytes()"/> 
        /// </summary>
        public byte[] IssuerAsBytes
        {
            get { return IExecuteWithSignatureArray<byte>("getIssuerAsBytes", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuerAsString()"/> 
        /// </summary>
        public Java.Lang.String IssuerAsString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getIssuerAsString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getKeyUsage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setKeyUsage(boolean[])"/>
        /// </summary>
        public bool[] KeyUsage
        {
            get { return IExecuteWithSignatureArray<bool>("getKeyUsage", "()[Z"); } set { IExecuteWithSignature("setKeyUsage", "([Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getMatchAllSubjectAltNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setMatchAllSubjectAltNames(boolean)"/>
        /// </summary>
        public bool MatchAllSubjectAltNames
        {
            get { return IExecuteWithSignature<bool>("getMatchAllSubjectAltNames", "()Z"); } set { IExecuteWithSignature("setMatchAllSubjectAltNames", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getNameConstraints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setNameConstraints(byte[])"/>
        /// </summary>
        public byte[] NameConstraints
        {
            get { return IExecuteWithSignatureArray<byte>("getNameConstraints", "()[B"); } set { IExecuteWithSignature("setNameConstraints", "([B)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getPathToNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setPathToNames(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection<Java.Util.List<object>> PathToNames
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getPathToNames", "()Ljava/util/Collection;"); } set { IExecuteWithSignature("setPathToNames", "(Ljava/util/Collection;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setPolicy(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<Java.Lang.String> Policy
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getPolicy", "()Ljava/util/Set;"); } set { IExecuteWithSignature("setPolicy", "(Ljava/util/Set;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getPrivateKeyValid()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setPrivateKeyValid(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date PrivateKeyValid
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getPrivateKeyValid", "()Ljava/util/Date;"); } set { IExecuteWithSignature("setPrivateKeyValid", "(Ljava/util/Date;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSerialNumber()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSerialNumber(java.math.BigInteger)"/>
        /// </summary>
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getSerialNumber", "()Ljava/math/BigInteger;"); } set { IExecuteWithSignature("setSerialNumber", "(Ljava/math/BigInteger;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubject()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal Subject
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getSubject", "()Ljavax/security/auth/x500/X500Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAlternativeNames()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectAlternativeNames(java.util.Collection)"/>
        /// </summary>
        public Java.Util.Collection<Java.Util.List<object>> SubjectAlternativeNames
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getSubjectAlternativeNames", "()Ljava/util/Collection;"); } set { IExecuteWithSignature("setSubjectAlternativeNames", "(Ljava/util/Collection;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAsBytes()"/> 
        /// </summary>
        public byte[] SubjectAsBytes
        {
            get { return IExecuteWithSignatureArray<byte>("getSubjectAsBytes", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAsString()"/> 
        /// </summary>
        public Java.Lang.String SubjectAsString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSubjectAsString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectKeyIdentifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectKeyIdentifier(byte[])"/>
        /// </summary>
        public byte[] SubjectKeyIdentifier
        {
            get { return IExecuteWithSignatureArray<byte>("getSubjectKeyIdentifier", "()[B"); } set { IExecuteWithSignature("setSubjectKeyIdentifier", "([B)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectPublicKey()"/> 
        /// </summary>
        public Java.Security.PublicKey SubjectPublicKey
        {
            get { return IExecuteWithSignature<Java.Security.PublicKey>("getSubjectPublicKey", "()Ljava/security/PublicKey;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectPublicKeyAlgID()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKeyAlgID(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String SubjectPublicKeyAlgID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSubjectPublicKeyAlgID", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#match(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Match(Java.Security.Cert.Certificate arg0)
        {
            return IExecuteWithSignature<bool>("match", "(Ljava/security/cert/Certificate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addPathToName(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddPathToName(int arg0, byte[] arg1)
        {
            IExecuteWithSignature("addPathToName", "(I[B)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addPathToName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddPathToName(int arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("addPathToName", "(ILjava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddSubjectAlternativeName(int arg0, byte[] arg1)
        {
            IExecuteWithSignature("addSubjectAlternativeName", "(I[B)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void AddSubjectAlternativeName(int arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("addSubjectAlternativeName", "(ILjava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetIssuer(byte[] arg0)
        {
            IExecuteWithSignature("setIssuer", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetIssuer(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setIssuer", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void SetIssuer(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecuteWithSignature("setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubject(byte[] arg0)
        {
            IExecuteWithSignature("setSubject", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubject(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSubject", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(javax.security.auth.x500.X500Principal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        public void SetSubject(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecuteWithSignature("setSubject", "(Ljavax/security/auth/x500/X500Principal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKey(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetSubjectPublicKey(byte[] arg0)
        {
            IExecuteWithSignature("setSubjectPublicKey", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKey(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        public void SetSubjectPublicKey(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("setSubjectPublicKey", "(Ljava/security/PublicKey;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}