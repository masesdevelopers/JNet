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

namespace Javax.Security.Sasl
{
    #region ISaslClientFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISaslClientFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClientFactory.html#getMechanismNames(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String[] GetMechanismNames(Java.Util.Map<Java.Lang.String, object> arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClientFactory.html#createSaslClient(java.lang.String[],java.lang.String,java.lang.String,java.lang.String,java.util.Map,javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Util.Map"/></param>
        /// <param name="arg5"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <returns><see cref="Javax.Security.Sasl.SaslClient"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        Javax.Security.Sasl.SaslClient CreateSaslClient(Java.Lang.String[] arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Util.Map<Java.Lang.String, object> arg4, Javax.Security.Auth.Callback.CallbackHandler arg5);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SaslClientFactory
    public partial class SaslClientFactory : Javax.Security.Sasl.ISaslClientFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClientFactory.html#getMechanismNames(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetMechanismNames(Java.Util.Map<Java.Lang.String, object> arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getMechanismNames", "(Ljava/util/Map;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.sasl/javax/security/sasl/SaslClientFactory.html#createSaslClient(java.lang.String[],java.lang.String,java.lang.String,java.lang.String,java.util.Map,javax.security.auth.callback.CallbackHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Util.Map"/></param>
        /// <param name="arg5"><see cref="Javax.Security.Auth.Callback.CallbackHandler"/></param>
        /// <returns><see cref="Javax.Security.Sasl.SaslClient"/></returns>
        /// <exception cref="Javax.Security.Sasl.SaslException"/>
        public Javax.Security.Sasl.SaslClient CreateSaslClient(Java.Lang.String[] arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Util.Map<Java.Lang.String, object> arg4, Javax.Security.Auth.Callback.CallbackHandler arg5)
        {
            return IExecute<Javax.Security.Sasl.SaslClient>("createSaslClient", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}