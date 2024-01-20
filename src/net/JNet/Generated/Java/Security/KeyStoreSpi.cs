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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region KeyStoreSpi
    public partial class KeyStoreSpi
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineContainsAlias(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineContainsAlias(string arg0)
        {
            return IExecute<bool>("engineContainsAlias", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineIsCertificateEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineIsCertificateEntry(string arg0)
        {
            return IExecute<bool>("engineIsCertificateEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineIsKeyEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineIsKeyEntry(string arg0)
        {
            return IExecute<bool>("engineIsKeyEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSize()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int EngineSize()
        {
            return IExecute<int>("engineSize");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCertificateAlias(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <returns><see cref="string"/></returns>
        public string EngineGetCertificateAlias(Java.Security.Cert.Certificate arg0)
        {
            return IExecute<string>("engineGetCertificateAlias", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCertificate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        public Java.Security.Cert.Certificate EngineGetCertificate(string arg0)
        {
            return IExecute<Java.Security.Cert.Certificate>("engineGetCertificate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCertificateChain(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.Certificate"/></returns>
        public Java.Security.Cert.Certificate[] EngineGetCertificateChain(string arg0)
        {
            return IExecuteArray<Java.Security.Cert.Certificate>("engineGetCertificateChain", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetKey(java.lang.String,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="Java.Security.Key"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        public Java.Security.Key EngineGetKey(string arg0, char[] arg1)
        {
            return IExecute<Java.Security.Key>("engineGetKey", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetCreationDate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date EngineGetCreationDate(string arg0)
        {
            return IExecute<Java.Util.Date>("engineGetCreationDate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineAliases()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<string> EngineAliases()
        {
            return IExecute<Java.Util.Enumeration<string>>("engineAliases");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineDeleteEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineDeleteEntry(string arg0)
        {
            IExecute("engineDeleteEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineLoad(java.io.InputStream,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineLoad(Java.Io.InputStream arg0, char[] arg1)
        {
            IExecute("engineLoad", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetCertificateEntry(java.lang.String,java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetCertificateEntry(string arg0, Java.Security.Cert.Certificate arg1)
        {
            IExecute("engineSetCertificateEntry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetKeyEntry(java.lang.String,byte[],java.security.cert.Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetKeyEntry(string arg0, byte[] arg1, Java.Security.Cert.Certificate[] arg2)
        {
            IExecute("engineSetKeyEntry", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetKeyEntry(java.lang.String,java.security.Key,char[],java.security.cert.Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="char"/></param>
        /// <param name="arg3"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetKeyEntry(string arg0, Java.Security.Key arg1, char[] arg2, Java.Security.Cert.Certificate[] arg3)
        {
            IExecute("engineSetKeyEntry", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineStore(java.io.OutputStream,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineStore(Java.Io.OutputStream arg0, char[] arg1)
        {
            IExecute("engineStore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineEntryInstanceOf(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EngineEntryInstanceOf(string arg0, Java.Lang.Class arg1)
        {
            return IExecute<bool>("engineEntryInstanceOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineProbe(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool EngineProbe(Java.Io.InputStream arg0)
        {
            return IExecute<bool>("engineProbe", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineGetEntry(java.lang.String,java.security.KeyStore.ProtectionParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.KeyStore.ProtectionParameter"/></param>
        /// <returns><see cref="Java.Security.KeyStore.Entry"/></returns>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableEntryException"/>
        public Java.Security.KeyStore.Entry EngineGetEntry(string arg0, Java.Security.KeyStore.ProtectionParameter arg1)
        {
            return IExecute<Java.Security.KeyStore.Entry>("engineGetEntry", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineLoad(java.security.KeyStore.LoadStoreParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore.LoadStoreParameter"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineLoad(Java.Security.KeyStore.LoadStoreParameter arg0)
        {
            IExecute("engineLoad", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineSetEntry(java.lang.String,java.security.KeyStore.Entry,java.security.KeyStore.ProtectionParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.KeyStore.Entry"/></param>
        /// <param name="arg2"><see cref="Java.Security.KeyStore.ProtectionParameter"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        public void EngineSetEntry(string arg0, Java.Security.KeyStore.Entry arg1, Java.Security.KeyStore.ProtectionParameter arg2)
        {
            IExecute("engineSetEntry", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyStoreSpi.html#engineStore(java.security.KeyStore.LoadStoreParameter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore.LoadStoreParameter"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.Cert.CertificateException"/>
        public void EngineStore(Java.Security.KeyStore.LoadStoreParameter arg0)
        {
            IExecute("engineStore", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}