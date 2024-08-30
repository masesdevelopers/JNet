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

namespace Javax.Security.Auth.Login
{
    #region AppConfigurationEntry declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html"/>
    /// </summary>
    public partial class AppConfigurationEntry : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AppConfigurationEntry>
    {
        const string _bridgeClassName = "javax.security.auth.login.AppConfigurationEntry";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AppConfigurationEntry() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AppConfigurationEntry(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region LoginModuleControlFlag declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html"/>
        /// </summary>
        public partial class LoginModuleControlFlag : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LoginModuleControlFlag>
        {
            const string _bridgeClassName = "javax.security.auth.login.AppConfigurationEntry$LoginModuleControlFlag";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public LoginModuleControlFlag() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public LoginModuleControlFlag(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region AppConfigurationEntry implementation
    public partial class AppConfigurationEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#%3Cinit%3E(java.lang.String,javax.security.auth.login.AppConfigurationEntry.LoginModuleControlFlag,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public AppConfigurationEntry(Java.Lang.String arg0, Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag arg1, Java.Util.Map<Java.Lang.String, object> arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#getControlFlag()"/> 
        /// </summary>
        public Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag ControlFlag
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>("getControlFlag", "()Ljavax/security/auth/login/AppConfigurationEntry$LoginModuleControlFlag;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#getLoginModuleName()"/> 
        /// </summary>
        public Java.Lang.String LoginModuleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLoginModuleName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.html#getOptions()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, object> Options
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("getOptions", "()Ljava/util/Map;"); }
        }

        #endregion

        #region Nested classes
        #region LoginModuleControlFlag implementation
        public partial class LoginModuleControlFlag
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#OPTIONAL"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag OPTIONAL { get { if (!_OPTIONALReady) { _OPTIONALContent = SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "OPTIONAL"); _OPTIONALReady = true; } return _OPTIONALContent; } }
            private static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag _OPTIONALContent = default;
            private static bool _OPTIONALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#REQUIRED"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag REQUIRED { get { if (!_REQUIREDReady) { _REQUIREDContent = SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "REQUIRED"); _REQUIREDReady = true; } return _REQUIREDContent; } }
            private static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag _REQUIREDContent = default;
            private static bool _REQUIREDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#REQUISITE"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag REQUISITE { get { if (!_REQUISITEReady) { _REQUISITEContent = SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "REQUISITE"); _REQUISITEReady = true; } return _REQUISITEContent; } }
            private static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag _REQUISITEContent = default;
            private static bool _REQUISITEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/login/AppConfigurationEntry.LoginModuleControlFlag.html#SUFFICIENT"/>
            /// </summary>
            public static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag SUFFICIENT { get { if (!_SUFFICIENTReady) { _SUFFICIENTContent = SGetField<Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag>(LocalBridgeClazz, "SUFFICIENT"); _SUFFICIENTReady = true; } return _SUFFICIENTContent; } }
            private static Javax.Security.Auth.Login.AppConfigurationEntry.LoginModuleControlFlag _SUFFICIENTContent = default;
            private static bool _SUFFICIENTReady = false; // this is used because in case of generics 

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