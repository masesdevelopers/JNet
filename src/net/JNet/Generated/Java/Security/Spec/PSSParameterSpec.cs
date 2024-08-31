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

namespace Java.Security.Spec
{
    #region PSSParameterSpec declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html"/>
    /// </summary>
    public partial class PSSParameterSpec : Java.Security.Spec.AlgorithmParameterSpec
    {
        const string _bridgeClassName = "java.security.spec.PSSParameterSpec";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PSSParameterSpec() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PSSParameterSpec(params object[] args) : base(args) { }

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

    #region PSSParameterSpec implementation
    public partial class PSSParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public PSSParameterSpec(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#%3Cinit%3E(java.lang.String,java.lang.String,java.security.spec.AlgorithmParameterSpec,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public PSSParameterSpec(Java.Lang.String arg0, Java.Lang.String arg1, Java.Security.Spec.AlgorithmParameterSpec arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#TRAILER_FIELD_BC"/>
        /// </summary>
        public static int TRAILER_FIELD_BC { get { if (!_TRAILER_FIELD_BCReady) { _TRAILER_FIELD_BCContent = SGetField<int>(LocalBridgeClazz, "TRAILER_FIELD_BC"); _TRAILER_FIELD_BCReady = true; } return _TRAILER_FIELD_BCContent; } }
        private static int _TRAILER_FIELD_BCContent = default;
        private static bool _TRAILER_FIELD_BCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#DEFAULT"/>
        /// </summary>
        public static Java.Security.Spec.PSSParameterSpec DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<Java.Security.Spec.PSSParameterSpec>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static Java.Security.Spec.PSSParameterSpec _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getDigestAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String DigestAlgorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDigestAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getMGFAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String MGFAlgorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMGFAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getMGFParameters()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec MGFParameters
        {
            get { return IExecuteWithSignature<Java.Security.Spec.AlgorithmParameterSpec>("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getSaltLength()"/> 
        /// </summary>
        public int SaltLength
        {
            get { return IExecuteWithSignature<int>("getSaltLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getTrailerField()"/> 
        /// </summary>
        public int TrailerField
        {
            get { return IExecuteWithSignature<int>("getTrailerField", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}