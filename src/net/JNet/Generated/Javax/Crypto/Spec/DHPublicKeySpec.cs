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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto.Spec
{
    #region DHPublicKeySpec
    public partial class DHPublicKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHPublicKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        public DHPublicKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHPublicKeySpec.html#getG()"/> 
        /// </summary>
        public Java.Math.BigInteger G
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getG", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHPublicKeySpec.html#getP()"/> 
        /// </summary>
        public Java.Math.BigInteger P
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getP", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHPublicKeySpec.html#getY()"/> 
        /// </summary>
        public Java.Math.BigInteger Y
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getY", "()Ljava/math/BigInteger;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}