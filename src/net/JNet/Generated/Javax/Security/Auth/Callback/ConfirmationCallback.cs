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

namespace Javax.Security.Auth.Callback
{
    #region ConfirmationCallback declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html"/>
    /// </summary>
    public partial class ConfirmationCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConfirmationCallback>
    {
        const string _bridgeClassName = "javax.security.auth.callback.ConfirmationCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConfirmationCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConfirmationCallback(params object[] args) : base(args) { }

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

    #region ConfirmationCallback implementation
    public partial class ConfirmationCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ConfirmationCallback(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(int,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ConfirmationCallback(int arg0, Java.Lang.String[] arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ConfirmationCallback(Java.Lang.String arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(java.lang.String,int,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ConfirmationCallback(Java.Lang.String arg0, int arg1, Java.Lang.String[] arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ConfirmationCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.ConfirmationCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ConfirmationCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.ConfirmationCallback t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#CANCEL"/>
        /// </summary>
        public static int CANCEL { get { if (!_CANCELReady) { _CANCELContent = SGetField<int>(LocalBridgeClazz, "CANCEL"); _CANCELReady = true; } return _CANCELContent; } }
        private static int _CANCELContent = default;
        private static bool _CANCELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#ERROR"/>
        /// </summary>
        public static int ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
        private static int _ERRORContent = default;
        private static bool _ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#INFORMATION"/>
        /// </summary>
        public static int INFORMATION { get { if (!_INFORMATIONReady) { _INFORMATIONContent = SGetField<int>(LocalBridgeClazz, "INFORMATION"); _INFORMATIONReady = true; } return _INFORMATIONContent; } }
        private static int _INFORMATIONContent = default;
        private static bool _INFORMATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#NO"/>
        /// </summary>
        public static int NO { get { if (!_NOReady) { _NOContent = SGetField<int>(LocalBridgeClazz, "NO"); _NOReady = true; } return _NOContent; } }
        private static int _NOContent = default;
        private static bool _NOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#OK"/>
        /// </summary>
        public static int OK { get { if (!_OKReady) { _OKContent = SGetField<int>(LocalBridgeClazz, "OK"); _OKReady = true; } return _OKContent; } }
        private static int _OKContent = default;
        private static bool _OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#OK_CANCEL_OPTION"/>
        /// </summary>
        public static int OK_CANCEL_OPTION { get { if (!_OK_CANCEL_OPTIONReady) { _OK_CANCEL_OPTIONContent = SGetField<int>(LocalBridgeClazz, "OK_CANCEL_OPTION"); _OK_CANCEL_OPTIONReady = true; } return _OK_CANCEL_OPTIONContent; } }
        private static int _OK_CANCEL_OPTIONContent = default;
        private static bool _OK_CANCEL_OPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#UNSPECIFIED_OPTION"/>
        /// </summary>
        public static int UNSPECIFIED_OPTION { get { if (!_UNSPECIFIED_OPTIONReady) { _UNSPECIFIED_OPTIONContent = SGetField<int>(LocalBridgeClazz, "UNSPECIFIED_OPTION"); _UNSPECIFIED_OPTIONReady = true; } return _UNSPECIFIED_OPTIONContent; } }
        private static int _UNSPECIFIED_OPTIONContent = default;
        private static bool _UNSPECIFIED_OPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#WARNING"/>
        /// </summary>
        public static int WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<int>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
        private static int _WARNINGContent = default;
        private static bool _WARNINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#YES"/>
        /// </summary>
        public static int YES { get { if (!_YESReady) { _YESContent = SGetField<int>(LocalBridgeClazz, "YES"); _YESReady = true; } return _YESContent; } }
        private static int _YESContent = default;
        private static bool _YESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#YES_NO_CANCEL_OPTION"/>
        /// </summary>
        public static int YES_NO_CANCEL_OPTION { get { if (!_YES_NO_CANCEL_OPTIONReady) { _YES_NO_CANCEL_OPTIONContent = SGetField<int>(LocalBridgeClazz, "YES_NO_CANCEL_OPTION"); _YES_NO_CANCEL_OPTIONReady = true; } return _YES_NO_CANCEL_OPTIONContent; } }
        private static int _YES_NO_CANCEL_OPTIONContent = default;
        private static bool _YES_NO_CANCEL_OPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#YES_NO_OPTION"/>
        /// </summary>
        public static int YES_NO_OPTION { get { if (!_YES_NO_OPTIONReady) { _YES_NO_OPTIONContent = SGetField<int>(LocalBridgeClazz, "YES_NO_OPTION"); _YES_NO_OPTIONReady = true; } return _YES_NO_OPTIONContent; } }
        private static int _YES_NO_OPTIONContent = default;
        private static bool _YES_NO_OPTIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getDefaultOption()"/> 
        /// </summary>
        public int DefaultOption
        {
            get { return IExecuteWithSignature<int>("getDefaultOption", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getMessageType()"/> 
        /// </summary>
        public int MessageType
        {
            get { return IExecuteWithSignature<int>("getMessageType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getOptions()"/> 
        /// </summary>
        public Java.Lang.String[] Options
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getOptions", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getOptionType()"/> 
        /// </summary>
        public int OptionType
        {
            get { return IExecuteWithSignature<int>("getOptionType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getPrompt()"/> 
        /// </summary>
        public Java.Lang.String Prompt
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrompt", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getSelectedIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#setSelectedIndex(int)"/>
        /// </summary>
        public int SelectedIndex
        {
            get { return IExecuteWithSignature<int>("getSelectedIndex", "()I"); } set { IExecuteWithSignature("setSelectedIndex", "(I)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}