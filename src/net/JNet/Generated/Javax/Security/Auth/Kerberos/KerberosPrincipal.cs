/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Kerberos
{
    #region KerberosPrincipal
    public partial class KerberosPrincipal
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public KerberosPrincipal(string arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public KerberosPrincipal(string arg0)
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
        public static int KRB_NT_PRINCIPAL { get { return SGetField<int>(LocalBridgeClazz, "KRB_NT_PRINCIPAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_SRV_HST"/>
        /// </summary>
        public static int KRB_NT_SRV_HST { get { return SGetField<int>(LocalBridgeClazz, "KRB_NT_SRV_HST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_SRV_INST"/>
        /// </summary>
        public static int KRB_NT_SRV_INST { get { return SGetField<int>(LocalBridgeClazz, "KRB_NT_SRV_INST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_SRV_XHST"/>
        /// </summary>
        public static int KRB_NT_SRV_XHST { get { return SGetField<int>(LocalBridgeClazz, "KRB_NT_SRV_XHST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_UID"/>
        /// </summary>
        public static int KRB_NT_UID { get { return SGetField<int>(LocalBridgeClazz, "KRB_NT_UID"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#KRB_NT_UNKNOWN"/>
        /// </summary>
        public static int KRB_NT_UNKNOWN { get { return SGetField<int>(LocalBridgeClazz, "KRB_NT_UNKNOWN"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KerberosPrincipal.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
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
        public string Realm
        {
            get { return IExecute<string>("getRealm"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}