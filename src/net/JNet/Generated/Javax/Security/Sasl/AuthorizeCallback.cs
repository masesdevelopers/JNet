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

namespace Javax.Security.Sasl
{
    #region AuthorizeCallback declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html"/>
    /// </summary>
    public partial class AuthorizeCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AuthorizeCallback>
    {
        const string _bridgeClassName = "javax.security.sasl.AuthorizeCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AuthorizeCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AuthorizeCallback(params object[] args) : base(args) { }

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

    #region AuthorizeCallback implementation
    public partial class AuthorizeCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public AuthorizeCallback(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Sasl.AuthorizeCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Sasl.AuthorizeCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Sasl.AuthorizeCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Sasl.AuthorizeCallback t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html#getAuthenticationID()"/> 
        /// </summary>
        public Java.Lang.String AuthenticationID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAuthenticationID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html#getAuthorizationID()"/> 
        /// </summary>
        public Java.Lang.String AuthorizationID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAuthorizationID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html#getAuthorizedID()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html#setAuthorizedID(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String AuthorizedID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAuthorizedID", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAuthorizedID", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html#isAuthorized()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAuthorized()
        {
            return IExecuteWithSignature<bool>("isAuthorized", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/AuthorizeCallback.html#setAuthorized(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAuthorized(bool arg0)
        {
            IExecuteWithSignature("setAuthorized", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}