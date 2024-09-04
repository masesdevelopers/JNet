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
    #region PKIXRevocationChecker declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html"/>
    /// </summary>
    public partial class PKIXRevocationChecker : Java.Security.Cert.PKIXCertPathChecker
    {
        const string _bridgeClassName = "java.security.cert.PKIXRevocationChecker";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PKIXRevocationChecker class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PKIXRevocationChecker() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PKIXRevocationChecker class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PKIXRevocationChecker(params object[] args) : base(args) { }

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
        #region Option declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html"/>
        /// </summary>
        public partial class Option : Java.Lang.Enum<Java.Security.Cert.PKIXRevocationChecker.Option>
        {
            const string _bridgeClassName = "java.security.cert.PKIXRevocationChecker$Option";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Option() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Option(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region PKIXRevocationChecker implementation
    public partial class PKIXRevocationChecker
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspExtensions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspExtensions(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Security.Cert.Extension> OcspExtensions
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.Extension>>("getOcspExtensions", "()Ljava/util/List;"); } set { IExecuteWithSignature("setOcspExtensions", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspResponder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspResponder(java.net.URI)"/>
        /// </summary>
        public Java.Net.URI OcspResponder
        {
            get { return IExecuteWithSignature<Java.Net.URI>("getOcspResponder", "()Ljava/net/URI;"); } set { IExecuteWithSignature("setOcspResponder", "(Ljava/net/URI;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspResponderCert()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspResponderCert(java.security.cert.X509Certificate)"/>
        /// </summary>
        public Java.Security.Cert.X509Certificate OcspResponderCert
        {
            get { return IExecuteWithSignature<Java.Security.Cert.X509Certificate>("getOcspResponderCert", "()Ljava/security/cert/X509Certificate;"); } set { IExecuteWithSignature("setOcspResponderCert", "(Ljava/security/cert/X509Certificate;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspResponses()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspResponses(java.util.Map)"/>
        /// </summary>
        public Java.Util.Map<Java.Security.Cert.X509Certificate, byte[]> OcspResponses
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Security.Cert.X509Certificate, byte[]>>("getOcspResponses", "()Ljava/util/Map;"); } set { IExecuteWithSignature("setOcspResponses", "(Ljava/util/Map;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOptions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOptions(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<Java.Security.Cert.PKIXRevocationChecker.Option> Options
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Security.Cert.PKIXRevocationChecker.Option>>("getOptions", "()Ljava/util/Set;"); } set { IExecuteWithSignature("setOptions", "(Ljava/util/Set;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getSoftFailExceptions()"/> 
        /// </summary>
        public Java.Util.List<Java.Security.Cert.CertPathValidatorException> SoftFailExceptions
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Security.Cert.CertPathValidatorException>>("getSoftFailExceptions", "()Ljava/util/List;"); }
        }

        #endregion

        #region Nested classes
        #region Option implementation
        public partial class Option
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#NO_FALLBACK"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option NO_FALLBACK { get { if (!_NO_FALLBACKReady) { _NO_FALLBACKContent = SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "NO_FALLBACK"); _NO_FALLBACKReady = true; } return _NO_FALLBACKContent; } }
            private static Java.Security.Cert.PKIXRevocationChecker.Option _NO_FALLBACKContent = default;
            private static bool _NO_FALLBACKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#ONLY_END_ENTITY"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option ONLY_END_ENTITY { get { if (!_ONLY_END_ENTITYReady) { _ONLY_END_ENTITYContent = SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "ONLY_END_ENTITY"); _ONLY_END_ENTITYReady = true; } return _ONLY_END_ENTITYContent; } }
            private static Java.Security.Cert.PKIXRevocationChecker.Option _ONLY_END_ENTITYContent = default;
            private static bool _ONLY_END_ENTITYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#PREFER_CRLS"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option PREFER_CRLS { get { if (!_PREFER_CRLSReady) { _PREFER_CRLSContent = SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "PREFER_CRLS"); _PREFER_CRLSReady = true; } return _PREFER_CRLSContent; } }
            private static Java.Security.Cert.PKIXRevocationChecker.Option _PREFER_CRLSContent = default;
            private static bool _PREFER_CRLSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#SOFT_FAIL"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option SOFT_FAIL { get { if (!_SOFT_FAILReady) { _SOFT_FAILContent = SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "SOFT_FAIL"); _SOFT_FAILReady = true; } return _SOFT_FAILContent; } }
            private static Java.Security.Cert.PKIXRevocationChecker.Option _SOFT_FAILContent = default;
            private static bool _SOFT_FAILReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Security.Cert.PKIXRevocationChecker.Option"/></returns>
            public static Java.Security.Cert.PKIXRevocationChecker.Option ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/security/cert/PKIXRevocationChecker$Option;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Security.Cert.PKIXRevocationChecker.Option"/></returns>
            public static Java.Security.Cert.PKIXRevocationChecker.Option[] Values()
            {
                return SExecuteWithSignatureArray<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "values", "()[Ljava/security/cert/PKIXRevocationChecker$Option;");
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