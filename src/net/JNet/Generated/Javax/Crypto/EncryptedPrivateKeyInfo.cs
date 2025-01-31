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

namespace Javax.Crypto
{
    #region EncryptedPrivateKeyInfo declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html"/>
    /// </summary>
    public partial class EncryptedPrivateKeyInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EncryptedPrivateKeyInfo>
    {
        const string _bridgeClassName = "javax.crypto.EncryptedPrivateKeyInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EncryptedPrivateKeyInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EncryptedPrivateKeyInfo(params object[] args) : base(args) { }

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

    #region EncryptedPrivateKeyInfo implementation
    public partial class EncryptedPrivateKeyInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public EncryptedPrivateKeyInfo(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#%3Cinit%3E(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public EncryptedPrivateKeyInfo(Java.Lang.String arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#%3Cinit%3E(java.security.AlgorithmParameters,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public EncryptedPrivateKeyInfo(Java.Security.AlgorithmParameters arg0, byte[] arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getAlgName()"/> 
        /// </summary>
        public Java.Lang.String AlgName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlgName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getAlgParameters()"/> 
        /// </summary>
        public Java.Security.AlgorithmParameters AlgParameters
        {
            get { return IExecuteWithSignature<Java.Security.AlgorithmParameters>("getAlgParameters", "()Ljava/security/AlgorithmParameters;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteWithSignatureArray<byte>("getEncoded", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getEncryptedData()"/> 
        /// </summary>
        public byte[] EncryptedData
        {
            get { return IExecuteWithSignatureArray<byte>("getEncryptedData", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getKeySpec(java.security.Key,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Spec.PKCS8EncodedKeySpec"/></returns>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(Java.Security.Key arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Security.Spec.PKCS8EncodedKeySpec>("getKeySpec", "(Ljava/security/Key;Ljava/lang/String;)Ljava/security/spec/PKCS8EncodedKeySpec;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getKeySpec(java.security.Key,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.Spec.PKCS8EncodedKeySpec"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(Java.Security.Key arg0, Java.Security.Provider arg1)
        {
            return IExecuteWithSignature<Java.Security.Spec.PKCS8EncodedKeySpec>("getKeySpec", "(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeySpec;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getKeySpec(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="Java.Security.Spec.PKCS8EncodedKeySpec"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(Java.Security.Key arg0)
        {
            return IExecuteWithSignature<Java.Security.Spec.PKCS8EncodedKeySpec>("getKeySpec", "(Ljava/security/Key;)Ljava/security/spec/PKCS8EncodedKeySpec;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getKeySpec(javax.crypto.Cipher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Crypto.Cipher"/></param>
        /// <returns><see cref="Java.Security.Spec.PKCS8EncodedKeySpec"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(Javax.Crypto.Cipher arg0)
        {
            return IExecuteWithSignature<Java.Security.Spec.PKCS8EncodedKeySpec>("getKeySpec", "(Ljavax/crypto/Cipher;)Ljava/security/spec/PKCS8EncodedKeySpec;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}