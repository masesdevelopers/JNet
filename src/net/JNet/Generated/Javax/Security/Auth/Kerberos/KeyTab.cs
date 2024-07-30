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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Security.Auth.Kerberos
{
    #region KeyTab
    public partial class KeyTab
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance()"/> 
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab Instance
        {
            get { return SExecuteWithSignature<Javax.Security.Auth.Kerberos.KeyTab>(LocalBridgeClazz, "getInstance", "()Ljavax/security/auth/kerberos/KeyTab;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getUnboundInstance()"/> 
        /// </summary>
        public static Javax.Security.Auth.Kerberos.KeyTab UnboundInstance
        {
            get { return SExecuteWithSignature<Javax.Security.Auth.Kerberos.KeyTab>(LocalBridgeClazz, "getUnboundInstance", "()Ljavax/security/auth/kerberos/KeyTab;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Security.Auth.Kerberos.KeyTab"/></returns>
        public static Javax.Security.Auth.Kerberos.KeyTab GetInstance(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Javax.Security.Auth.Kerberos.KeyTab>(LocalBridgeClazz, "getInstance", "(Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance(javax.security.auth.kerberos.KerberosPrincipal,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <param name="arg1"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Security.Auth.Kerberos.KeyTab"/></returns>
        public static Javax.Security.Auth.Kerberos.KeyTab GetInstance(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0, Java.Io.File arg1)
        {
            return SExecute<Javax.Security.Auth.Kerberos.KeyTab>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getInstance(javax.security.auth.kerberos.KerberosPrincipal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <returns><see cref="Javax.Security.Auth.Kerberos.KeyTab"/></returns>
        public static Javax.Security.Auth.Kerberos.KeyTab GetInstance(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0)
        {
            return SExecuteWithSignature<Javax.Security.Auth.Kerberos.KeyTab>(LocalBridgeClazz, "getInstance", "(Ljavax/security/auth/kerberos/KerberosPrincipal;)Ljavax/security/auth/kerberos/KeyTab;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getUnboundInstance(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Security.Auth.Kerberos.KeyTab"/></returns>
        public static Javax.Security.Auth.Kerberos.KeyTab GetUnboundInstance(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Javax.Security.Auth.Kerberos.KeyTab>(LocalBridgeClazz, "getUnboundInstance", "(Ljava/io/File;)Ljavax/security/auth/kerberos/KeyTab;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getPrincipal()"/> 
        /// </summary>
        public Javax.Security.Auth.Kerberos.KerberosPrincipal Principal
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.Kerberos.KerberosPrincipal>("getPrincipal", "()Ljavax/security/auth/kerberos/KerberosPrincipal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#exists()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Exists()
        {
            return IExecuteWithSignature<bool>("exists", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#isBound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecuteWithSignature<bool>("isBound", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/javax/security/auth/kerberos/KeyTab.html#getKeys(javax.security.auth.kerberos.KerberosPrincipal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Kerberos.KerberosPrincipal"/></param>
        /// <returns><see cref="Javax.Security.Auth.Kerberos.KerberosKey"/></returns>
        public Javax.Security.Auth.Kerberos.KerberosKey[] GetKeys(Javax.Security.Auth.Kerberos.KerberosPrincipal arg0)
        {
            return IExecuteWithSignatureArray<Javax.Security.Auth.Kerberos.KerberosKey>("getKeys", "(Ljavax/security/auth/kerberos/KerberosPrincipal;)[Ljavax/security/auth/kerberos/KerberosKey;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}