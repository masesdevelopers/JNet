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
    #region PKIXCertPathChecker declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathChecker.html"/>
    /// </summary>
    public partial class PKIXCertPathChecker : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PKIXCertPathChecker>
    {
        const string _bridgeClassName = "java.security.cert.PKIXCertPathChecker";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PKIXCertPathChecker class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PKIXCertPathChecker() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PKIXCertPathChecker class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PKIXCertPathChecker(params object[] args) : base(args) { }

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

    #region PKIXCertPathChecker implementation
    public partial class PKIXCertPathChecker
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.PKIXCertPathChecker"/> to <see cref="Java.Security.Cert.CertPathChecker"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.CertPathChecker(Java.Security.Cert.PKIXCertPathChecker t) => t.Cast<Java.Security.Cert.CertPathChecker>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.PKIXCertPathChecker"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Security.Cert.PKIXCertPathChecker t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathChecker.html#getSupportedExtensions()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> SupportedExtensions
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSupportedExtensions", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathChecker.html#isForwardCheckingSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsForwardCheckingSupported()
        {
            return IExecuteWithSignature<bool>("isForwardCheckingSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathChecker.html#check(java.security.cert.Certificate,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <exception cref="Java.Security.Cert.CertPathValidatorException"/>
        public void Check(Java.Security.Cert.Certificate arg0, Java.Util.Collection<Java.Lang.String> arg1)
        {
            IExecute("check", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathChecker.html#init(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Security.Cert.CertPathValidatorException"/>
        public void Init(bool arg0)
        {
            IExecuteWithSignature("init", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathChecker.html#check(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.Cert.CertPathValidatorException"/>
        public void Check(Java.Security.Cert.Certificate arg0)
        {
            IExecuteWithSignature("check", "(Ljava/security/cert/Certificate;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}