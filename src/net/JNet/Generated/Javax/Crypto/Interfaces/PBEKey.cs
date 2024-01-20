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

namespace Javax.Crypto.Interfaces
{
    #region IPBEKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPBEKey : Javax.Crypto.ISecretKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/PBEKey.html#getIterationCount()"/> 
        /// </summary>
        int IterationCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/PBEKey.html#getPassword()"/> 
        /// </summary>
        char[] Password { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/PBEKey.html#getSalt()"/> 
        /// </summary>
        byte[] Salt { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PBEKey
    public partial class PBEKey : Javax.Crypto.Interfaces.IPBEKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/PBEKey.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { return SGetField<long>(LocalBridgeClazz, "serialVersionUID"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/PBEKey.html#getIterationCount()"/> 
        /// </summary>
        public int IterationCount
        {
            get { return IExecute<int>("getIterationCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/PBEKey.html#getPassword()"/> 
        /// </summary>
        public char[] Password
        {
            get { return IExecuteArray<char>("getPassword"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/interfaces/PBEKey.html#getSalt()"/> 
        /// </summary>
        public byte[] Salt
        {
            get { return IExecuteArray<byte>("getSalt"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}