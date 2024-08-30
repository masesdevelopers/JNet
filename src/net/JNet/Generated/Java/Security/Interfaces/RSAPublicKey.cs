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

namespace Java.Security.Interfaces
{
    #region RSAPublicKey declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAPublicKey.html"/>
    /// </summary>
    public partial class RSAPublicKey : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RSAPublicKey>
    {
        const string _bridgeClassName = "java.security.interfaces.RSAPublicKey";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RSAPublicKey class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RSAPublicKey() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RSAPublicKey class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RSAPublicKey(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IRSAPublicKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRSAPublicKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAPublicKey.html#getPublicExponent()"/> 
        /// </summary>
        Java.Math.BigInteger PublicExponent { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RSAPublicKey implementation
    public partial class RSAPublicKey : Java.Security.Interfaces.IRSAPublicKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.RSAPublicKey"/> to <see cref="Java.Security.PublicKey"/>
        /// </summary>
        public static implicit operator Java.Security.PublicKey(Java.Security.Interfaces.RSAPublicKey t) => t.Cast<Java.Security.PublicKey>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.RSAPublicKey"/> to <see cref="Java.Security.Interfaces.RSAKey"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.RSAKey(Java.Security.Interfaces.RSAPublicKey t) => t.Cast<Java.Security.Interfaces.RSAKey>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAPublicKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { if (!_serialVersionUIDReady) { _serialVersionUIDContent = SGetField<long>(LocalBridgeClazz, "serialVersionUID"); _serialVersionUIDReady = true; } return _serialVersionUIDContent; } }
        private static long _serialVersionUIDContent = default;
        private static bool _serialVersionUIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/RSAPublicKey.html#getPublicExponent()"/> 
        /// </summary>
        public Java.Math.BigInteger PublicExponent
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPublicExponent", "()Ljava/math/BigInteger;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}