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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region UnresolvedPermission
    public partial class UnresolvedPermission
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/UnresolvedPermission.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.security.cert.Certificate[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Security.Cert.Certificate"/></param>
        public UnresolvedPermission(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Security.Cert.Certificate[] arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/UnresolvedPermission.html#getUnresolvedActions()"/> 
        /// </summary>
        public Java.Lang.String UnresolvedActions
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUnresolvedActions", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/UnresolvedPermission.html#getUnresolvedCerts()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] UnresolvedCerts
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getUnresolvedCerts", "()[Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/UnresolvedPermission.html#getUnresolvedName()"/> 
        /// </summary>
        public Java.Lang.String UnresolvedName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUnresolvedName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/UnresolvedPermission.html#getUnresolvedType()"/> 
        /// </summary>
        public Java.Lang.String UnresolvedType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUnresolvedType", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}