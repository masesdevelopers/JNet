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

namespace Javax.Xml.Crypto.Dsig.Keyinfo
{
    #region IKeyValue
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IKeyValue : Javax.Xml.Crypto.IXMLStructure
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyValue.html#getPublicKey()"/> 
        /// </summary>
        Java.Security.PublicKey PublicKey { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyValue
    public partial class KeyValue : Javax.Xml.Crypto.Dsig.Keyinfo.IKeyValue
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyValue.html#DSA_TYPE"/>
        /// </summary>
        public static Java.Lang.String DSA_TYPE { get { if (!_DSA_TYPEReady) { _DSA_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DSA_TYPE"); _DSA_TYPEReady = true; } return _DSA_TYPEContent; } }
        private static Java.Lang.String _DSA_TYPEContent = default;
        private static bool _DSA_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyValue.html#RSA_TYPE"/>
        /// </summary>
        public static Java.Lang.String RSA_TYPE { get { if (!_RSA_TYPEReady) { _RSA_TYPEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RSA_TYPE"); _RSA_TYPEReady = true; } return _RSA_TYPEContent; } }
        private static Java.Lang.String _RSA_TYPEContent = default;
        private static bool _RSA_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyValue.html#getPublicKey()"/> 
        /// </summary>
        public Java.Security.PublicKey PublicKey
        {
            get { return IExecuteWithSignature<Java.Security.PublicKey>("getPublicKey", "()Ljava/security/PublicKey;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}