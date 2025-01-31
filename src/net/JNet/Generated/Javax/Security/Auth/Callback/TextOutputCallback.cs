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

namespace Javax.Security.Auth.Callback
{
    #region TextOutputCallback declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextOutputCallback.html"/>
    /// </summary>
    public partial class TextOutputCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TextOutputCallback>
    {
        const string _bridgeClassName = "javax.security.auth.callback.TextOutputCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextOutputCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextOutputCallback(params object[] args) : base(args) { }

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

    #region TextOutputCallback implementation
    public partial class TextOutputCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextOutputCallback.html#%3Cinit%3E(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public TextOutputCallback(int arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.TextOutputCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.TextOutputCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.TextOutputCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.TextOutputCallback t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextOutputCallback.html#ERROR"/>
        /// </summary>
        public static int ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
        private static int _ERRORContent = default;
        private static bool _ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextOutputCallback.html#INFORMATION"/>
        /// </summary>
        public static int INFORMATION { get { if (!_INFORMATIONReady) { _INFORMATIONContent = SGetField<int>(LocalBridgeClazz, "INFORMATION"); _INFORMATIONReady = true; } return _INFORMATIONContent; } }
        private static int _INFORMATIONContent = default;
        private static bool _INFORMATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextOutputCallback.html#WARNING"/>
        /// </summary>
        public static int WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<int>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
        private static int _WARNINGContent = default;
        private static bool _WARNINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextOutputCallback.html#getMessage()"/> 
        /// </summary>
        public Java.Lang.String Message
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMessage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/TextOutputCallback.html#getMessageType()"/> 
        /// </summary>
        public int MessageType
        {
            get { return IExecuteWithSignature<int>("getMessageType", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}