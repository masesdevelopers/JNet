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

namespace Java.Security.Cert
{
    #region PKIXCertPathBuilderResult
    public partial class PKIXCertPathBuilderResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathBuilderResult.html#%3Cinit%3E(java.security.cert.CertPath,java.security.cert.TrustAnchor,java.security.cert.PolicyNode,java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertPath"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.TrustAnchor"/></param>
        /// <param name="arg2"><see cref="Java.Security.Cert.PolicyNode"/></param>
        /// <param name="arg3"><see cref="Java.Security.PublicKey"/></param>
        public PKIXCertPathBuilderResult(Java.Security.Cert.CertPath arg0, Java.Security.Cert.TrustAnchor arg1, Java.Security.Cert.PolicyNode arg2, Java.Security.PublicKey arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.PKIXCertPathBuilderResult"/> to <see cref="Java.Security.Cert.CertPathBuilderResult"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.CertPathBuilderResult(Java.Security.Cert.PKIXCertPathBuilderResult t) => t.Cast<Java.Security.Cert.CertPathBuilderResult>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXCertPathBuilderResult.html#getCertPath()"/> 
        /// </summary>
        public Java.Security.Cert.CertPath CertPath
        {
            get { return IExecuteWithSignature<Java.Security.Cert.CertPath>("getCertPath", "()Ljava/security/cert/CertPath;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}