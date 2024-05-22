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

namespace Java.Security
{
    #region CryptoPrimitive
    public partial class CryptoPrimitive
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#BLOCK_CIPHER"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive BLOCK_CIPHER { get { if (!_BLOCK_CIPHERReady) { _BLOCK_CIPHERContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "BLOCK_CIPHER"); _BLOCK_CIPHERReady = true; } return _BLOCK_CIPHERContent; } }
        private static Java.Security.CryptoPrimitive _BLOCK_CIPHERContent = default;
        private static bool _BLOCK_CIPHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#KEY_AGREEMENT"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive KEY_AGREEMENT { get { if (!_KEY_AGREEMENTReady) { _KEY_AGREEMENTContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "KEY_AGREEMENT"); _KEY_AGREEMENTReady = true; } return _KEY_AGREEMENTContent; } }
        private static Java.Security.CryptoPrimitive _KEY_AGREEMENTContent = default;
        private static bool _KEY_AGREEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#KEY_ENCAPSULATION"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive KEY_ENCAPSULATION { get { if (!_KEY_ENCAPSULATIONReady) { _KEY_ENCAPSULATIONContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "KEY_ENCAPSULATION"); _KEY_ENCAPSULATIONReady = true; } return _KEY_ENCAPSULATIONContent; } }
        private static Java.Security.CryptoPrimitive _KEY_ENCAPSULATIONContent = default;
        private static bool _KEY_ENCAPSULATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#KEY_WRAP"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive KEY_WRAP { get { if (!_KEY_WRAPReady) { _KEY_WRAPContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "KEY_WRAP"); _KEY_WRAPReady = true; } return _KEY_WRAPContent; } }
        private static Java.Security.CryptoPrimitive _KEY_WRAPContent = default;
        private static bool _KEY_WRAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#MAC"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive MAC { get { if (!_MACReady) { _MACContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "MAC"); _MACReady = true; } return _MACContent; } }
        private static Java.Security.CryptoPrimitive _MACContent = default;
        private static bool _MACReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#MESSAGE_DIGEST"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive MESSAGE_DIGEST { get { if (!_MESSAGE_DIGESTReady) { _MESSAGE_DIGESTContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "MESSAGE_DIGEST"); _MESSAGE_DIGESTReady = true; } return _MESSAGE_DIGESTContent; } }
        private static Java.Security.CryptoPrimitive _MESSAGE_DIGESTContent = default;
        private static bool _MESSAGE_DIGESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#PUBLIC_KEY_ENCRYPTION"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive PUBLIC_KEY_ENCRYPTION { get { if (!_PUBLIC_KEY_ENCRYPTIONReady) { _PUBLIC_KEY_ENCRYPTIONContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "PUBLIC_KEY_ENCRYPTION"); _PUBLIC_KEY_ENCRYPTIONReady = true; } return _PUBLIC_KEY_ENCRYPTIONContent; } }
        private static Java.Security.CryptoPrimitive _PUBLIC_KEY_ENCRYPTIONContent = default;
        private static bool _PUBLIC_KEY_ENCRYPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#SECURE_RANDOM"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive SECURE_RANDOM { get { if (!_SECURE_RANDOMReady) { _SECURE_RANDOMContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "SECURE_RANDOM"); _SECURE_RANDOMReady = true; } return _SECURE_RANDOMContent; } }
        private static Java.Security.CryptoPrimitive _SECURE_RANDOMContent = default;
        private static bool _SECURE_RANDOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#SIGNATURE"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive SIGNATURE { get { if (!_SIGNATUREReady) { _SIGNATUREContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "SIGNATURE"); _SIGNATUREReady = true; } return _SIGNATUREContent; } }
        private static Java.Security.CryptoPrimitive _SIGNATUREContent = default;
        private static bool _SIGNATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#STREAM_CIPHER"/>
        /// </summary>
        public static Java.Security.CryptoPrimitive STREAM_CIPHER { get { if (!_STREAM_CIPHERReady) { _STREAM_CIPHERContent = SGetField<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "STREAM_CIPHER"); _STREAM_CIPHERReady = true; } return _STREAM_CIPHERContent; } }
        private static Java.Security.CryptoPrimitive _STREAM_CIPHERContent = default;
        private static bool _STREAM_CIPHERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.CryptoPrimitive"/></returns>
        public static Java.Security.CryptoPrimitive ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/security/CryptoPrimitive;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/CryptoPrimitive.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.CryptoPrimitive"/></returns>
        public static Java.Security.CryptoPrimitive[] Values()
        {
            return SExecuteWithSignatureArray<Java.Security.CryptoPrimitive>(LocalBridgeClazz, "values", "()[Ljava/security/CryptoPrimitive;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}