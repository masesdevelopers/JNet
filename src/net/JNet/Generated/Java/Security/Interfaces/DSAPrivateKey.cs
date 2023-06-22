/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Interfaces
{
    #region IDSAPrivateKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDSAPrivateKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAPrivateKey.html#getX()"/> 
        /// </summary>
        Java.Math.BigInteger X { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DSAPrivateKey
    public partial class DSAPrivateKey : Java.Security.Interfaces.IDSAPrivateKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.DSAPrivateKey"/> to <see cref="Java.Security.Interfaces.DSAKey"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.DSAKey(Java.Security.Interfaces.DSAPrivateKey t) => t.Cast<Java.Security.Interfaces.DSAKey>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.DSAPrivateKey"/> to <see cref="Java.Security.PrivateKey"/>
        /// </summary>
        public static implicit operator Java.Security.PrivateKey(Java.Security.Interfaces.DSAPrivateKey t) => t.Cast<Java.Security.PrivateKey>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAPrivateKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { return SGetField<long>(LocalBridgeClazz, "serialVersionUID"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/interfaces/DSAPrivateKey.html#getX()"/> 
        /// </summary>
        public Java.Math.BigInteger X
        {
            get { return IExecute<Java.Math.BigInteger>("getX"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}