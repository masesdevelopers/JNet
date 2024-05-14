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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto
{
    #region ExemptionMechanism
    public partial class ExemptionMechanism
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.ExemptionMechanism"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Crypto.ExemptionMechanism GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Crypto.ExemptionMechanism>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Crypto.ExemptionMechanism"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.ExemptionMechanism GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Crypto.ExemptionMechanism>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.ExemptionMechanism"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.ExemptionMechanism GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Crypto.ExemptionMechanism>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#isCryptoAllowed(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Crypto.ExemptionMechanismException"/>
        public bool IsCryptoAllowed(Java.Security.Key arg0)
        {
            return IExecuteWithSignature<bool>("isCryptoAllowed", "(Ljava/security/Key;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#genExemptionBlob()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Javax.Crypto.ExemptionMechanismException"/>
        public byte[] GenExemptionBlob()
        {
            return IExecuteWithSignatureArray<byte>("genExemptionBlob", "()[B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#genExemptionBlob(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.ExemptionMechanismException"/>
        public int GenExemptionBlob(byte[] arg0, int arg1)
        {
            return IExecute<int>("genExemptionBlob", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#genExemptionBlob(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.ExemptionMechanismException"/>
        public int GenExemptionBlob(byte[] arg0)
        {
            return IExecuteWithSignature<int>("genExemptionBlob", "([B)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#getOutputSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public int GetOutputSize(int arg0)
        {
            return IExecuteWithSignature<int>("getOutputSize", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#init(java.security.Key,java.security.AlgorithmParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        /// <exception cref="Javax.Crypto.ExemptionMechanismException"/>
        public void Init(Java.Security.Key arg0, Java.Security.AlgorithmParameters arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#init(java.security.Key,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        /// <exception cref="Javax.Crypto.ExemptionMechanismException"/>
        public void Init(Java.Security.Key arg0, Java.Security.Spec.AlgorithmParameterSpec arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/ExemptionMechanism.html#init(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Javax.Crypto.ExemptionMechanismException"/>
        public void Init(Java.Security.Key arg0)
        {
            IExecuteWithSignature("init", "(Ljava/security/Key;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}