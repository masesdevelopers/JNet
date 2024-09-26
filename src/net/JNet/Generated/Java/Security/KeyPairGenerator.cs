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

namespace Java.Security
{
    #region KeyPairGenerator declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html"/>
    /// </summary>
    public partial class KeyPairGenerator : Java.Security.KeyPairGeneratorSpi
    {
        const string _bridgeClassName = "java.security.KeyPairGenerator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("KeyPairGenerator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public KeyPairGenerator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("KeyPairGenerator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public KeyPairGenerator(params object[] args) : base(args) { }

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

    #region KeyPairGenerator implementation
    public partial class KeyPairGenerator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.KeyPairGenerator"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.KeyPairGenerator GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Security.KeyPairGenerator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyPairGenerator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.KeyPairGenerator"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.KeyPairGenerator GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecuteWithSignature<Java.Security.KeyPairGenerator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyPairGenerator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.KeyPairGenerator"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.KeyPairGenerator GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.KeyPairGenerator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyPairGenerator;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#getAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String Algorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#genKeyPair()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.KeyPair"/></returns>
        public Java.Security.KeyPair GenKeyPair()
        {
            return IExecuteWithSignature<Java.Security.KeyPair>("genKeyPair", "()Ljava/security/KeyPair;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#initialize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Initialize(int arg0)
        {
            IExecuteWithSignature("initialize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGenerator.html#initialize(java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Initialize(Java.Security.Spec.AlgorithmParameterSpec arg0)
        {
            IExecuteWithSignature("initialize", "(Ljava/security/spec/AlgorithmParameterSpec;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}