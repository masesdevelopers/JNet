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

namespace Java.Security.Interfaces
{
    #region IXECPrivateKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXECPrivateKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/XECPrivateKey.html#getScalar()"/> 
        /// </summary>
        Java.Util.Optional<byte[]> Scalar { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XECPrivateKey
    public partial class XECPrivateKey : Java.Security.Interfaces.IXECPrivateKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.XECPrivateKey"/> to <see cref="Java.Security.Interfaces.XECKey"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.XECKey(Java.Security.Interfaces.XECPrivateKey t) => t.Cast<Java.Security.Interfaces.XECKey>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.XECPrivateKey"/> to <see cref="Java.Security.PrivateKey"/>
        /// </summary>
        public static implicit operator Java.Security.PrivateKey(Java.Security.Interfaces.XECPrivateKey t) => t.Cast<Java.Security.PrivateKey>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/XECPrivateKey.html#getScalar()"/> 
        /// </summary>
        public Java.Util.Optional<byte[]> Scalar
        {
            get { return IExecuteWithSignature<Java.Util.Optional<byte[]>>("getScalar", "()Ljava/util/Optional;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}