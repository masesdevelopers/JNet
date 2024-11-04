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

namespace Javax.Xml.Crypto
{
    #region KeySelector declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.html"/>
    /// </summary>
    public partial class KeySelector : MASES.JCOBridge.C2JBridge.JVMBridgeBase<KeySelector>
    {
        const string _bridgeClassName = "javax.xml.crypto.KeySelector";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("KeySelector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public KeySelector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("KeySelector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public KeySelector(params object[] args) : base(args) { }

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
        #region Purpose declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html"/>
        /// </summary>
        public partial class Purpose : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Purpose>
        {
            const string _bridgeClassName = "javax.xml.crypto.KeySelector$Purpose";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Purpose() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Purpose(params object[] args) : base(args) { }

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

    #region KeySelector implementation
    public partial class KeySelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.html#singletonKeySelector(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.KeySelector"/></returns>
        public static Javax.Xml.Crypto.KeySelector SingletonKeySelectorMethod(Java.Security.Key arg0)
        {
            return SExecuteWithSignature<Javax.Xml.Crypto.KeySelector>(LocalBridgeClazz, "singletonKeySelector", "(Ljava/security/Key;)Ljavax/xml/crypto/KeySelector;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.html#select(javax.xml.crypto.dsig.keyinfo.KeyInfo,javax.xml.crypto.KeySelector.Purpose,javax.xml.crypto.AlgorithmMethod,javax.xml.crypto.XMLCryptoContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Crypto.KeySelector.Purpose"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Crypto.AlgorithmMethod"/></param>
        /// <param name="arg3"><see cref="Javax.Xml.Crypto.XMLCryptoContext"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.KeySelectorResult"/></returns>
        /// <exception cref="Javax.Xml.Crypto.KeySelectorException"/>
        public Javax.Xml.Crypto.KeySelectorResult Select(Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo arg0, Javax.Xml.Crypto.KeySelector.Purpose arg1, Javax.Xml.Crypto.AlgorithmMethod arg2, Javax.Xml.Crypto.XMLCryptoContext arg3)
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.KeySelectorResult>("select", "(Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;Ljavax/xml/crypto/KeySelector$Purpose;Ljavax/xml/crypto/AlgorithmMethod;Ljavax/xml/crypto/XMLCryptoContext;)Ljavax/xml/crypto/KeySelectorResult;", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region Purpose implementation
        public partial class Purpose
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#DECRYPT"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose DECRYPT { get { if (!_DECRYPTReady) { _DECRYPTContent = SGetField<Javax.Xml.Crypto.KeySelector.Purpose>(LocalBridgeClazz, "DECRYPT"); _DECRYPTReady = true; } return _DECRYPTContent; } }
            private static Javax.Xml.Crypto.KeySelector.Purpose _DECRYPTContent = default;
            private static bool _DECRYPTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#ENCRYPT"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose ENCRYPT { get { if (!_ENCRYPTReady) { _ENCRYPTContent = SGetField<Javax.Xml.Crypto.KeySelector.Purpose>(LocalBridgeClazz, "ENCRYPT"); _ENCRYPTReady = true; } return _ENCRYPTContent; } }
            private static Javax.Xml.Crypto.KeySelector.Purpose _ENCRYPTContent = default;
            private static bool _ENCRYPTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#SIGN"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose SIGN { get { if (!_SIGNReady) { _SIGNContent = SGetField<Javax.Xml.Crypto.KeySelector.Purpose>(LocalBridgeClazz, "SIGN"); _SIGNReady = true; } return _SIGNContent; } }
            private static Javax.Xml.Crypto.KeySelector.Purpose _SIGNContent = default;
            private static bool _SIGNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/KeySelector.Purpose.html#VERIFY"/>
            /// </summary>
            public static Javax.Xml.Crypto.KeySelector.Purpose VERIFY { get { if (!_VERIFYReady) { _VERIFYContent = SGetField<Javax.Xml.Crypto.KeySelector.Purpose>(LocalBridgeClazz, "VERIFY"); _VERIFYReady = true; } return _VERIFYContent; } }
            private static Javax.Xml.Crypto.KeySelector.Purpose _VERIFYContent = default;
            private static bool _VERIFYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

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