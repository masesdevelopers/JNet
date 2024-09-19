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

namespace Javax.Xml.Crypto.Dsig
{
    #region CanonicalizationMethod declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html"/>
    /// </summary>
    public partial class CanonicalizationMethod : Javax.Xml.Crypto.Dsig.Transform
    {
        const string _bridgeClassName = "javax.xml.crypto.dsig.CanonicalizationMethod";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CanonicalizationMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CanonicalizationMethod() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CanonicalizationMethod class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CanonicalizationMethod(params object[] args) : base(args) { }

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

    #region ICanonicalizationMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICanonicalizationMethod : Javax.Xml.Crypto.Dsig.ITransform
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#getParameterSpec()"/> 
        /// </summary>
        Java.Security.Spec.AlgorithmParameterSpec ParameterSpec { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CanonicalizationMethod implementation
    public partial class CanonicalizationMethod : Javax.Xml.Crypto.Dsig.ICanonicalizationMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#EXCLUSIVE"/>
        /// </summary>
        public static Java.Lang.String EXCLUSIVE { get { if (!_EXCLUSIVEReady) { _EXCLUSIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXCLUSIVE"); _EXCLUSIVEReady = true; } return _EXCLUSIVEContent; } }
        private static Java.Lang.String _EXCLUSIVEContent = default;
        private static bool _EXCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#EXCLUSIVE_WITH_COMMENTS"/>
        /// </summary>
        public static Java.Lang.String EXCLUSIVE_WITH_COMMENTS { get { if (!_EXCLUSIVE_WITH_COMMENTSReady) { _EXCLUSIVE_WITH_COMMENTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXCLUSIVE_WITH_COMMENTS"); _EXCLUSIVE_WITH_COMMENTSReady = true; } return _EXCLUSIVE_WITH_COMMENTSContent; } }
        private static Java.Lang.String _EXCLUSIVE_WITH_COMMENTSContent = default;
        private static bool _EXCLUSIVE_WITH_COMMENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#INCLUSIVE"/>
        /// </summary>
        public static Java.Lang.String INCLUSIVE { get { if (!_INCLUSIVEReady) { _INCLUSIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INCLUSIVE"); _INCLUSIVEReady = true; } return _INCLUSIVEContent; } }
        private static Java.Lang.String _INCLUSIVEContent = default;
        private static bool _INCLUSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#INCLUSIVE_WITH_COMMENTS"/>
        /// </summary>
        public static Java.Lang.String INCLUSIVE_WITH_COMMENTS { get { if (!_INCLUSIVE_WITH_COMMENTSReady) { _INCLUSIVE_WITH_COMMENTSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INCLUSIVE_WITH_COMMENTS"); _INCLUSIVE_WITH_COMMENTSReady = true; } return _INCLUSIVE_WITH_COMMENTSContent; } }
        private static Java.Lang.String _INCLUSIVE_WITH_COMMENTSContent = default;
        private static bool _INCLUSIVE_WITH_COMMENTSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/CanonicalizationMethod.html#getParameterSpec()"/> 
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