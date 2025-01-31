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

namespace Javax.Smartcardio
{
    #region CardTerminals declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html"/>
    /// </summary>
    public partial class CardTerminals : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CardTerminals>
    {
        const string _bridgeClassName = "javax.smartcardio.CardTerminals";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CardTerminals class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CardTerminals() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CardTerminals class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CardTerminals(params object[] args) : base(args) { }

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
        #region State declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html"/>
        /// </summary>
        public partial class State : Java.Lang.Enum<Javax.Smartcardio.CardTerminals.State>
        {
            const string _bridgeClassName = "javax.smartcardio.CardTerminals$State";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public State() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public State(params object[] args) : base(args) { }

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

    #region CardTerminals implementation
    public partial class CardTerminals
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#waitForChange(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public bool WaitForChange(long arg0)
        {
            return IExecuteWithSignature<bool>("waitForChange", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#list(javax.smartcardio.CardTerminals.State)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Smartcardio.CardTerminals.State"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public Java.Util.List<Javax.Smartcardio.CardTerminal> List(Javax.Smartcardio.CardTerminals.State arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Javax.Smartcardio.CardTerminal>>("list", "(Ljavax/smartcardio/CardTerminals$State;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#list()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public Java.Util.List<Javax.Smartcardio.CardTerminal> List()
        {
            return IExecuteWithSignature<Java.Util.List<Javax.Smartcardio.CardTerminal>>("list", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#getTerminal(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Smartcardio.CardTerminal"/></returns>
        public Javax.Smartcardio.CardTerminal GetTerminal(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Smartcardio.CardTerminal>("getTerminal", "(Ljava/lang/String;)Ljavax/smartcardio/CardTerminal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.html#waitForChange()"/>
        /// </summary>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public void WaitForChange()
        {
            IExecuteWithSignature("waitForChange", "()V");
        }

        #endregion

        #region Nested classes
        #region State implementation
        public partial class State
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#ALL"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State ALL { get { if (!_ALLReady) { _ALLContent = SGetField<Javax.Smartcardio.CardTerminals.State>(LocalBridgeClazz, "ALL"); _ALLReady = true; } return _ALLContent; } }
            private static Javax.Smartcardio.CardTerminals.State _ALLContent = default;
            private static bool _ALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_ABSENT"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_ABSENT { get { if (!_CARD_ABSENTReady) { _CARD_ABSENTContent = SGetField<Javax.Smartcardio.CardTerminals.State>(LocalBridgeClazz, "CARD_ABSENT"); _CARD_ABSENTReady = true; } return _CARD_ABSENTContent; } }
            private static Javax.Smartcardio.CardTerminals.State _CARD_ABSENTContent = default;
            private static bool _CARD_ABSENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_INSERTION"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_INSERTION { get { if (!_CARD_INSERTIONReady) { _CARD_INSERTIONContent = SGetField<Javax.Smartcardio.CardTerminals.State>(LocalBridgeClazz, "CARD_INSERTION"); _CARD_INSERTIONReady = true; } return _CARD_INSERTIONContent; } }
            private static Javax.Smartcardio.CardTerminals.State _CARD_INSERTIONContent = default;
            private static bool _CARD_INSERTIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_PRESENT"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_PRESENT { get { if (!_CARD_PRESENTReady) { _CARD_PRESENTContent = SGetField<Javax.Smartcardio.CardTerminals.State>(LocalBridgeClazz, "CARD_PRESENT"); _CARD_PRESENTReady = true; } return _CARD_PRESENTContent; } }
            private static Javax.Smartcardio.CardTerminals.State _CARD_PRESENTContent = default;
            private static bool _CARD_PRESENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#CARD_REMOVAL"/>
            /// </summary>
            public static Javax.Smartcardio.CardTerminals.State CARD_REMOVAL { get { if (!_CARD_REMOVALReady) { _CARD_REMOVALContent = SGetField<Javax.Smartcardio.CardTerminals.State>(LocalBridgeClazz, "CARD_REMOVAL"); _CARD_REMOVALReady = true; } return _CARD_REMOVALContent; } }
            private static Javax.Smartcardio.CardTerminals.State _CARD_REMOVALContent = default;
            private static bool _CARD_REMOVALReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Smartcardio.CardTerminals.State"/></returns>
            public static Javax.Smartcardio.CardTerminals.State ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Smartcardio.CardTerminals.State>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/smartcardio/CardTerminals$State;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminals.State.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Smartcardio.CardTerminals.State"/></returns>
            public static Javax.Smartcardio.CardTerminals.State[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Smartcardio.CardTerminals.State>(LocalBridgeClazz, "values", "()[Ljavax/smartcardio/CardTerminals$State;");
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