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

namespace Javax.Xml.Crypto.Dsig
{
    #region SignatureMethod declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html"/>
    /// </summary>
    public partial class SignatureMethod : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SignatureMethod>
    {
        const string _bridgeClassName = "javax.xml.crypto.dsig.SignatureMethod";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SignatureMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SignatureMethod() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SignatureMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SignatureMethod(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ISignatureMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISignatureMethod
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#getParameterSpec()"/> 
        /// </summary>
        Java.Security.Spec.AlgorithmParameterSpec ParameterSpec { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SignatureMethod implementation
    public partial class SignatureMethod : Javax.Xml.Crypto.Dsig.ISignatureMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.SignatureMethod"/> to <see cref="Javax.Xml.Crypto.XMLStructure"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.XMLStructure(Javax.Xml.Crypto.Dsig.SignatureMethod t) => t.Cast<Javax.Xml.Crypto.XMLStructure>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.SignatureMethod"/> to <see cref="Javax.Xml.Crypto.AlgorithmMethod"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.AlgorithmMethod(Javax.Xml.Crypto.Dsig.SignatureMethod t) => t.Cast<Javax.Xml.Crypto.AlgorithmMethod>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#DSA_SHA1"/>
        /// </summary>
        public static Java.Lang.String DSA_SHA1 { get { if (!_DSA_SHA1Ready) { _DSA_SHA1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "DSA_SHA1"); _DSA_SHA1Ready = true; } return _DSA_SHA1Content; } }
        private static Java.Lang.String _DSA_SHA1Content = default;
        private static bool _DSA_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#DSA_SHA256"/>
        /// </summary>
        public static Java.Lang.String DSA_SHA256 { get { if (!_DSA_SHA256Ready) { _DSA_SHA256Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "DSA_SHA256"); _DSA_SHA256Ready = true; } return _DSA_SHA256Content; } }
        private static Java.Lang.String _DSA_SHA256Content = default;
        private static bool _DSA_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA1"/>
        /// </summary>
        public static Java.Lang.String ECDSA_SHA1 { get { if (!_ECDSA_SHA1Ready) { _ECDSA_SHA1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "ECDSA_SHA1"); _ECDSA_SHA1Ready = true; } return _ECDSA_SHA1Content; } }
        private static Java.Lang.String _ECDSA_SHA1Content = default;
        private static bool _ECDSA_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA224"/>
        /// </summary>
        public static Java.Lang.String ECDSA_SHA224 { get { if (!_ECDSA_SHA224Ready) { _ECDSA_SHA224Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "ECDSA_SHA224"); _ECDSA_SHA224Ready = true; } return _ECDSA_SHA224Content; } }
        private static Java.Lang.String _ECDSA_SHA224Content = default;
        private static bool _ECDSA_SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA256"/>
        /// </summary>
        public static Java.Lang.String ECDSA_SHA256 { get { if (!_ECDSA_SHA256Ready) { _ECDSA_SHA256Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "ECDSA_SHA256"); _ECDSA_SHA256Ready = true; } return _ECDSA_SHA256Content; } }
        private static Java.Lang.String _ECDSA_SHA256Content = default;
        private static bool _ECDSA_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA384"/>
        /// </summary>
        public static Java.Lang.String ECDSA_SHA384 { get { if (!_ECDSA_SHA384Ready) { _ECDSA_SHA384Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "ECDSA_SHA384"); _ECDSA_SHA384Ready = true; } return _ECDSA_SHA384Content; } }
        private static Java.Lang.String _ECDSA_SHA384Content = default;
        private static bool _ECDSA_SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA512"/>
        /// </summary>
        public static Java.Lang.String ECDSA_SHA512 { get { if (!_ECDSA_SHA512Ready) { _ECDSA_SHA512Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "ECDSA_SHA512"); _ECDSA_SHA512Ready = true; } return _ECDSA_SHA512Content; } }
        private static Java.Lang.String _ECDSA_SHA512Content = default;
        private static bool _ECDSA_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA1"/>
        /// </summary>
        public static Java.Lang.String HMAC_SHA1 { get { if (!_HMAC_SHA1Ready) { _HMAC_SHA1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "HMAC_SHA1"); _HMAC_SHA1Ready = true; } return _HMAC_SHA1Content; } }
        private static Java.Lang.String _HMAC_SHA1Content = default;
        private static bool _HMAC_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA224"/>
        /// </summary>
        public static Java.Lang.String HMAC_SHA224 { get { if (!_HMAC_SHA224Ready) { _HMAC_SHA224Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "HMAC_SHA224"); _HMAC_SHA224Ready = true; } return _HMAC_SHA224Content; } }
        private static Java.Lang.String _HMAC_SHA224Content = default;
        private static bool _HMAC_SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA256"/>
        /// </summary>
        public static Java.Lang.String HMAC_SHA256 { get { if (!_HMAC_SHA256Ready) { _HMAC_SHA256Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "HMAC_SHA256"); _HMAC_SHA256Ready = true; } return _HMAC_SHA256Content; } }
        private static Java.Lang.String _HMAC_SHA256Content = default;
        private static bool _HMAC_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA384"/>
        /// </summary>
        public static Java.Lang.String HMAC_SHA384 { get { if (!_HMAC_SHA384Ready) { _HMAC_SHA384Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "HMAC_SHA384"); _HMAC_SHA384Ready = true; } return _HMAC_SHA384Content; } }
        private static Java.Lang.String _HMAC_SHA384Content = default;
        private static bool _HMAC_SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA512"/>
        /// </summary>
        public static Java.Lang.String HMAC_SHA512 { get { if (!_HMAC_SHA512Ready) { _HMAC_SHA512Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "HMAC_SHA512"); _HMAC_SHA512Ready = true; } return _HMAC_SHA512Content; } }
        private static Java.Lang.String _HMAC_SHA512Content = default;
        private static bool _HMAC_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA1"/>
        /// </summary>
        public static Java.Lang.String RSA_SHA1 { get { if (!_RSA_SHA1Ready) { _RSA_SHA1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "RSA_SHA1"); _RSA_SHA1Ready = true; } return _RSA_SHA1Content; } }
        private static Java.Lang.String _RSA_SHA1Content = default;
        private static bool _RSA_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA224"/>
        /// </summary>
        public static Java.Lang.String RSA_SHA224 { get { if (!_RSA_SHA224Ready) { _RSA_SHA224Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "RSA_SHA224"); _RSA_SHA224Ready = true; } return _RSA_SHA224Content; } }
        private static Java.Lang.String _RSA_SHA224Content = default;
        private static bool _RSA_SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA256"/>
        /// </summary>
        public static Java.Lang.String RSA_SHA256 { get { if (!_RSA_SHA256Ready) { _RSA_SHA256Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "RSA_SHA256"); _RSA_SHA256Ready = true; } return _RSA_SHA256Content; } }
        private static Java.Lang.String _RSA_SHA256Content = default;
        private static bool _RSA_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA384"/>
        /// </summary>
        public static Java.Lang.String RSA_SHA384 { get { if (!_RSA_SHA384Ready) { _RSA_SHA384Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "RSA_SHA384"); _RSA_SHA384Ready = true; } return _RSA_SHA384Content; } }
        private static Java.Lang.String _RSA_SHA384Content = default;
        private static bool _RSA_SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA512"/>
        /// </summary>
        public static Java.Lang.String RSA_SHA512 { get { if (!_RSA_SHA512Ready) { _RSA_SHA512Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "RSA_SHA512"); _RSA_SHA512Ready = true; } return _RSA_SHA512Content; } }
        private static Java.Lang.String _RSA_SHA512Content = default;
        private static bool _RSA_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA1_RSA_MGF1"/>
        /// </summary>
        public static Java.Lang.String SHA1_RSA_MGF1 { get { if (!_SHA1_RSA_MGF1Ready) { _SHA1_RSA_MGF1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA1_RSA_MGF1"); _SHA1_RSA_MGF1Ready = true; } return _SHA1_RSA_MGF1Content; } }
        private static Java.Lang.String _SHA1_RSA_MGF1Content = default;
        private static bool _SHA1_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA224_RSA_MGF1"/>
        /// </summary>
        public static Java.Lang.String SHA224_RSA_MGF1 { get { if (!_SHA224_RSA_MGF1Ready) { _SHA224_RSA_MGF1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA224_RSA_MGF1"); _SHA224_RSA_MGF1Ready = true; } return _SHA224_RSA_MGF1Content; } }
        private static Java.Lang.String _SHA224_RSA_MGF1Content = default;
        private static bool _SHA224_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA256_RSA_MGF1"/>
        /// </summary>
        public static Java.Lang.String SHA256_RSA_MGF1 { get { if (!_SHA256_RSA_MGF1Ready) { _SHA256_RSA_MGF1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA256_RSA_MGF1"); _SHA256_RSA_MGF1Ready = true; } return _SHA256_RSA_MGF1Content; } }
        private static Java.Lang.String _SHA256_RSA_MGF1Content = default;
        private static bool _SHA256_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA384_RSA_MGF1"/>
        /// </summary>
        public static Java.Lang.String SHA384_RSA_MGF1 { get { if (!_SHA384_RSA_MGF1Ready) { _SHA384_RSA_MGF1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA384_RSA_MGF1"); _SHA384_RSA_MGF1Ready = true; } return _SHA384_RSA_MGF1Content; } }
        private static Java.Lang.String _SHA384_RSA_MGF1Content = default;
        private static bool _SHA384_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA512_RSA_MGF1"/>
        /// </summary>
        public static Java.Lang.String SHA512_RSA_MGF1 { get { if (!_SHA512_RSA_MGF1Ready) { _SHA512_RSA_MGF1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SHA512_RSA_MGF1"); _SHA512_RSA_MGF1Ready = true; } return _SHA512_RSA_MGF1Content; } }
        private static Java.Lang.String _SHA512_RSA_MGF1Content = default;
        private static bool _SHA512_RSA_MGF1Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#getParameterSpec()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec ParameterSpec
        {
            get { return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getParameterSpec", "()Ljava/security/spec/AlgorithmParameterSpec;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}