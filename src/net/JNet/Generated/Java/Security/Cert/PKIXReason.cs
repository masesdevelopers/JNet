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

namespace Java.Security.Cert
{
    #region PKIXReason
    public partial class PKIXReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#INVALID_KEY_USAGE"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason INVALID_KEY_USAGE { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "INVALID_KEY_USAGE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#INVALID_NAME"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason INVALID_NAME { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "INVALID_NAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#INVALID_POLICY"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason INVALID_POLICY { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "INVALID_POLICY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#NAME_CHAINING"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason NAME_CHAINING { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "NAME_CHAINING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#NO_TRUST_ANCHOR"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason NO_TRUST_ANCHOR { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "NO_TRUST_ANCHOR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#NOT_CA_CERT"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason NOT_CA_CERT { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "NOT_CA_CERT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#PATH_TOO_LONG"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason PATH_TOO_LONG { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "PATH_TOO_LONG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#UNRECOGNIZED_CRIT_EXT"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason UNRECOGNIZED_CRIT_EXT { get { return SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "UNRECOGNIZED_CRIT_EXT"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.PKIXReason"/></returns>
        public static Java.Security.Cert.PKIXReason ValueOf(string arg0)
        {
            return SExecute<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Security.Cert.PKIXReason"/></returns>
        public static Java.Security.Cert.PKIXReason[] Values()
        {
            return SExecuteArray<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "values");
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