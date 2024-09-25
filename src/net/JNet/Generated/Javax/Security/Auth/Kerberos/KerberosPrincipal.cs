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

namespace Javax.Security.Auth.Kerberos
{
    #region KerberosPrincipal declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html"/>
    /// </summary>
    public partial class KerberosPrincipal : MASES.JCOBridge.C2JBridge.JVMBridgeBase<KerberosPrincipal>
    {
        const string _bridgeClassName = "javax.security.auth.kerberos.KerberosPrincipal";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KerberosPrincipal() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KerberosPrincipal(params object[] args) : base(args) { }

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

    #region KerberosPrincipal implementation
    public partial class KerberosPrincipal
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public KerberosPrincipal(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public KerberosPrincipal(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/> to <see cref="Java.Security.Principal"/>
        /// </summary>
        public static implicit operator Java.Security.Principal(Javax.Security.Auth.Kerberos.KerberosPrincipal t) => t.Cast<Java.Security.Principal>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Kerberos.KerberosPrincipal t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_PRINCIPAL"/>
        /// </summary>
        public static int KRB_NT_PRINCIPAL { get { if (!_KRB_NT_PRINCIPALReady) { _KRB_NT_PRINCIPALContent = SGetField<int>(LocalBridgeClazz, "KRB_NT_PRINCIPAL"); _KRB_NT_PRINCIPALReady = true; } return _KRB_NT_PRINCIPALContent; } }
        private static int _KRB_NT_PRINCIPALContent = default;
        private static bool _KRB_NT_PRINCIPALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_SRV_HST"/>
        /// </summary>
        public static int KRB_NT_SRV_HST { get { if (!_KRB_NT_SRV_HSTReady) { _KRB_NT_SRV_HSTContent = SGetField<int>(LocalBridgeClazz, "KRB_NT_SRV_HST"); _KRB_NT_SRV_HSTReady = true; } return _KRB_NT_SRV_HSTContent; } }
        private static int _KRB_NT_SRV_HSTContent = default;
        private static bool _KRB_NT_SRV_HSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_SRV_INST"/>
        /// </summary>
        public static int KRB_NT_SRV_INST { get { if (!_KRB_NT_SRV_INSTReady) { _KRB_NT_SRV_INSTContent = SGetField<int>(LocalBridgeClazz, "KRB_NT_SRV_INST"); _KRB_NT_SRV_INSTReady = true; } return _KRB_NT_SRV_INSTContent; } }
        private static int _KRB_NT_SRV_INSTContent = default;
        private static bool _KRB_NT_SRV_INSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_SRV_XHST"/>
        /// </summary>
        public static int KRB_NT_SRV_XHST { get { if (!_KRB_NT_SRV_XHSTReady) { _KRB_NT_SRV_XHSTContent = SGetField<int>(LocalBridgeClazz, "KRB_NT_SRV_XHST"); _KRB_NT_SRV_XHSTReady = true; } return _KRB_NT_SRV_XHSTContent; } }
        private static int _KRB_NT_SRV_XHSTContent = default;
        private static bool _KRB_NT_SRV_XHSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_UID"/>
        /// </summary>
        public static int KRB_NT_UID { get { if (!_KRB_NT_UIDReady) { _KRB_NT_UIDContent = SGetField<int>(LocalBridgeClazz, "KRB_NT_UID"); _KRB_NT_UIDReady = true; } return _KRB_NT_UIDContent; } }
        private static int _KRB_NT_UIDContent = default;
        private static bool _KRB_NT_UIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_UNKNOWN"/>
        /// </summary>
        public static int KRB_NT_UNKNOWN { get { if (!_KRB_NT_UNKNOWNReady) { _KRB_NT_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "KRB_NT_UNKNOWN"); _KRB_NT_UNKNOWNReady = true; } return _KRB_NT_UNKNOWNContent; } }
        private static int _KRB_NT_UNKNOWNContent = default;
        private static bool _KRB_NT_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecute<Java.Lang.String>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#getNameType()"/> 
        /// </summary>
        public int NameType
        {
            get { return IExecute<int>("getNameType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#getRealm()"/> 
        /// </summary>
        public Java.Lang.String Realm
        {
            get { return IExecute<Java.Lang.String>("getRealm"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}